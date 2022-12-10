using WinFormsApplication.Controllers;
using WinFormsApplication.Enums;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm;
using WinFormsApplication.Forms.MainForm.Drawers.NewUserForm;
using WinFormsApplication.Forms.MainForm.Drawers.PetCardForm;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class AllAdsForm : Form
    {
        List<Role> rolesList; //Кэш ролей чтобы каждый раз к БД не обращаться будем хранить тута +- константа
        List<Advertisment>? advertisments; //Кэш объявлений, чтобы полную загрузку делать только при небходимости, а не например при фильтрации
        List<Settlement> settlementsList; //Кэш населенных пунктов. +- константа

        private AuthForm authForm;
        private Filter filterForm;
        internal Models.Classes.Filter filter;
        private User? user;

        SettlementsController settlementsController;
        AdvertismentsController advertismentsController;
        internal PetCategoriesController petCategoriesController;
        internal AllAdsForm(AuthForm authForm, User? user = null)
        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;

            this.user = user;
            this.authForm = authForm;

            settlementsController = new SettlementsController();
            advertismentsController = new AdvertismentsController();
            petCategoriesController = new PetCategoriesController();

            this.filter = new Models.Classes.Filter();
            this.filterForm = new Filter(this);
            this.settlementsList = settlementsController.GetSettlementsList();


            this.rerenderPermittedButtons(this.user?.RoleId);

            this.advertisments = advertismentsController.getAllAdvertisments();

            (this.dataViewTable.Columns["petPhoto"] as DataGridViewImageColumn).Width = 120;
            rerenderDataGridViewTable();
        }

        internal void rerenderDataGridViewTable()
        {
            this.dataViewTable.Rows.Clear();

            var toView = this.advertisments?.ToList();

            if (this.filter.displayOnlyMy)
                toView = toView?.Where((ad) => ad.PetOwnerId == this.user?.Id)?.ToList();

            if (this.filter.isSettlementsFilterActive)
            {
                var settlementsIds = settlementsList.Where((settlement) => this.filter.SettlementsName.Contains(settlement?.Name ?? ""))
                    .Select((setl) => setl.Id).ToList();

                toView = toView?.Where((ad) => settlementsIds.Contains(ad.SettlementId))?.ToList();
            }

            if (this.filter.isPetCategoryFilterActive)
                toView = toView?.Where((ad) => ad.PetCategoryId == this.filter.PetCategoryId)?.ToList();

            if (this.filter.isLostDatesFilterActive)
                this.filter.LostDates.ForEach((date) =>
                {
                    toView = ReturnFilteredByDateAdsList(toView, date.Item2, date.Item1);
                });

            toView?.ForEach((advertisment) =>
            {
                var getPhoto = advertisment.Photographies.FirstOrDefault();

                Image img;  try { img = getPhoto == null ? Image.FromFile("../../../withoutPhoto.jpg") : Image.FromFile(getPhoto.Filepath); } catch { img = null; };

                this.dataViewTable.Rows.Add(
                    advertisment.Id,
                    advertisment.CreationDateTime,
                    img, advertisment.BreedName,
                    advertisment.PetSex,
                    this.settlementsList.Find((settl) => settl.Id == advertisment?.SettlementId)?.Name,
                    advertisment.PetName,
                    advertisment.PetBirthDate
                );
            });
        }

        bool HandleUnauthorisedUsers()
        {
            var dialogResult = MessageBox.Show("Вы не авторизованы. Хотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NewUserForm newUser = new NewUserForm();
                var result = newUser.ShowDialog();
                if (result != DialogResult.Continue) return false;
                this.user = newUser.user;
                this.rerenderPermittedButtons(user?.RoleId);
                return true;
            }
            else return false;
        }

        private void rerenderPermittedButtons(long? roleId)
        {
            switch (roleId)
            {
                case null:
                    this.displayMyCheckbox.Enabled = false;
                    this.myPetsButton.Enabled = false;
                    this.chngAdButton.Enabled = false;
                    this.delAddButton.Enabled = false;
                    break;
                case (long)Roles.OWNER:
                    this.myPetsButton.Enabled = true;
                    break;
                case (long)Roles.ADMIN:
                    this.myPetsButton.Enabled = false;
                    break;
            }
        }

        private void rerenderDGVButtons()
        {
            //todo кнопки открыть изменить.
        }

        private void openAdButton_Click(object sender, EventArgs e)
        {
            var curRowId = this.dataViewTable.CurrentRow?.Cells["id"]?.Value;
            if (curRowId == null) return;

            PetCardForm petCardForm = new PetCardForm(this.advertisments?.First((ad)=>ad.Id == (long)curRowId), this.user); 
            petCardForm.ShowDialog();
        }

        private void AllAdsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.authForm.Show();
        }

        private void addAdButton_Click(object sender, EventArgs e)
        {
            if (this.user == null && !this.HandleUnauthorisedUsers())
                return;

            OwnPetsController ownPetsController = new OwnPetsController();
            if ( ownPetsController.getUserAnimals(user.Id).Count() > 0)
            {
                if (Utils.Utils.Confirm("Найдены ваши домашние животные. Хотите подставить?", "Подстановка ДЖ"))
                {
                    MyPets myPets = new MyPets(user, true);
                    myPets.ShowDialog();
                }
                else
                {
                    AddChangeAdForm addChangeAdForm = new AddChangeAdForm(user);
                    if (addChangeAdForm.ShowDialog() == DialogResult.OK)
                    {
                        this.advertisments = advertismentsController.getAllAdvertisments();
                        this.rerenderDataGridViewTable();
                    }
                }
            }
            else
            {
                AddChangeAdForm addChangeAdForm = new AddChangeAdForm(user);
                if (addChangeAdForm.ShowDialog() == DialogResult.OK)
                {
                    this.advertisments = advertismentsController.getAllAdvertisments();
                    this.rerenderDataGridViewTable();
                }
            }

            

            
        }

        private void chngAdButton_Click(object sender, EventArgs e)
        {
            var curRowId = this.dataViewTable.CurrentRow?.Cells["id"]?.Value;
            if (curRowId == null) return;

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(user, this.advertisments?.Find((ad)=>ad.Id == (long)curRowId));
            if(addChangeAdForm.ShowDialog() == DialogResult.OK)
            {
                this.advertisments = advertismentsController.getAllAdvertisments();
                this.rerenderDataGridViewTable();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterForm.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            filterForm.StartPosition = FormStartPosition.Manual;

            if (filterForm.Location.X + filterForm.Width >= SystemInformation.PrimaryMonitorSize.Width)
                filterForm.Location = new Point(SystemInformation.PrimaryMonitorSize.Width - filterForm.Width, filterForm.Location.Y);
            if (filterForm.Location.Y + filterForm.Height >= SystemInformation.PrimaryMonitorSize.Height)
                filterForm.Location = new Point(filterForm.Location.X, SystemInformation.PrimaryMonitorSize.Height - filterForm.Height - 50);

            filterForm.ShowDialog();
        }

        private void myPetsButton_Click(object sender, EventArgs e)
        {
            if (this.user == null && !this.HandleUnauthorisedUsers())
                return;

            MyPets myPets = new MyPets(user); //TODO по юзеру цеплять
            myPets.ShowDialog();
        }

        private void dataViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rerenderDGVButtons();
        }

        private void refreshTableButton_Click(object sender, EventArgs e)
        {
            this.advertisments = advertismentsController.getAllAdvertisments();
            this.rerenderDataGridViewTable();
        }

        private void displayMyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.filter.displayOnlyMy = this.displayMyCheckbox.Checked;
            this.rerenderDataGridViewTable();
        }

        private List <Advertisment>? ReturnFilteredByDateAdsList(List <Advertisment>? advertisments, string date, string operand)
        {
            var comparedDateTime = Convert.ToDateTime(date);
            switch (operand)
            {
                case ">=":
                    return advertisments?.Where((ad) => Convert.ToDateTime(ad.CreationDateTime) >= comparedDateTime)?.ToList();
                case "<=":
                    return advertisments?.Where((ad) => Convert.ToDateTime(ad.CreationDateTime) <= comparedDateTime)?.ToList();
                case ">":
                    return advertisments?.Where((ad) => Convert.ToDateTime(ad.CreationDateTime) > comparedDateTime)?.ToList();
                case "<":
                    return advertisments?.Where((ad) => Convert.ToDateTime(ad.CreationDateTime) < comparedDateTime)?.ToList();
                case "=":
                    return advertisments?.Where((ad) => Convert.ToDateTime(ad.CreationDateTime) == comparedDateTime)?.ToList();
                default:
                    throw new Exception("Undefined operand");
            }
        }

        private void dataViewTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRowId = this.dataViewTable.CurrentRow?.Cells["id"]?.Value;
            if (curRowId == null) return;

            PetCardForm petCardForm = new PetCardForm(this.advertisments?.First((ad) => ad.Id == (long)curRowId), this.user);
            petCardForm.ShowDialog();
        }

        private void delAddButton_Click(object sender, EventArgs e)
        {
            var curRowId = int.Parse(this.dataViewTable.CurrentRow?.Cells["id"]?.Value.ToString());
            if (curRowId != null)
            {
                advertismentsController.DeleteAdvertisment(curRowId);
            }
            this.advertisments = advertismentsController.getAllAdvertisments();
            this.rerenderDataGridViewTable();
        }
    }
}
