﻿using WinFormsApplication.Controllers;
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
        internal DatabaseController dbController;

        internal AllAdsForm(DatabaseController databaseController, AuthForm authForm, User? user = null)
        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;

            this.user = user;
            this.authForm = authForm;
            this.dbController = databaseController;

            this.filterForm = new Filter(this);
            this.filter = new Models.Classes.Filter();
            this.rolesList = dbController.getAllRoles();
            this.settlementsList = dbController.getAllSettlements();

            this.rerenderPermittedButtons(this.user?.RoleId);

            this.advertisments = dbController.getAllAdvertisments();
            rerenderDataGridViewTable();
        }

        internal void rerenderDataGridViewTable()
        {
            this.dataViewTable.Rows.Clear();
            //todo прикрутить фильтр
            if (this.filter.displayOnlyMy)
            {
                this.advertisments?.Where((ad) => ad.PetOwnerId == this.user?.Id).ToList().ForEach((advertisment) =>
                {
                    this.dataViewTable.Rows.Add(
                        advertisment.Id,
                        advertisment.CreationDateTime,
                        null, advertisment.BreedName,
                        advertisment.PetSex,
                        this.settlementsList.Find((settl) => settl.Id == advertisment?.SettlementId)?.Name
                    );
                });
            }
            else
            {
                this.advertisments?.ForEach((advertisment) =>
                {
                    this.dataViewTable.Rows.Add(
                        advertisment.Id,
                        advertisment.CreationDateTime,
                        null, advertisment.BreedName,
                        advertisment.PetSex,
                        this.settlementsList.Find((settl) => settl.Id == advertisment?.SettlementId)?.Name
                    );
                });
            }


        }

        bool HandleUnauthorisedUsers()
        {
            var dialogResult = MessageBox.Show("Вы не авторизованы. Хотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NewUserForm newUser = new NewUserForm(dbController, rolesList.First((role) => role.Name == "owner").Id);
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
            var role = this.rolesList?.Find((role) => role.Id == roleId);
            switch (role?.Name)
            {
                case null:
                    //todo гость
                    this.displayMyCheckbox.Enabled = false;
                    this.myPetsButton.Enabled = false;
                    break;
                case "owner":
                    //todo владелец
                    this.myPetsButton.Enabled = true;
                    break;
                case "admin":
                    this.myPetsButton.Enabled = false;
                    //todo админ
                    break;
                    //todo ещё роли
            }
        }

        private void rerenderDGVButtons()
        {
            //todo кнопки открыть изменить.
        }

        private void openAdButton_Click(object sender, EventArgs e)
        {
            PetCardForm petCardForm = new PetCardForm(this.dbController, this.advertisments?.FirstOrDefault(), this.user); //TODO переделать на currentRow. 
            petCardForm.ShowDialog();
            //todo может любой
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

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(dbController, user);
            addChangeAdForm.ShowDialog();
        }

        private void chngAdButton_Click(object sender, EventArgs e)
        {
            var curAdd = this.advertisments?.FirstOrDefault();//TODO currentrow
            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(dbController, user, curAdd);
            addChangeAdForm.ShowDialog();
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

            MyPets myPets = new MyPets(); //TODO по юзеру цеплять
            myPets.ShowDialog();
        }

        private void dataViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rerenderDGVButtons();
        }

        private void refreshTableButton_Click(object sender, EventArgs e)
        {
            this.advertisments = this.dbController.getAllAdvertisments();
            this.rerenderDataGridViewTable();
        }

        private void displayMyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.filter.displayOnlyMy = this.displayMyCheckbox.Checked;
            this.rerenderDataGridViewTable();
        }
    }
}
