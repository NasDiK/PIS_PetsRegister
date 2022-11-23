using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Utils;
using System.Linq;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm
{
    public partial class AddChangeAdForm : Form
    {
        DatabaseController dbController;
        User? user;

        /*
            На обсуждение: точно ли мы ФИО вписываем? Как мы будем цеплять к конкретному владельцу.
            Или у нас авторизовываются нашедшие
         */


        Advertisment? advertisment;
        internal AddChangeAdForm(DatabaseController databaseController, User? user, Advertisment? advertisment = null)
        {
            InitializeComponent();
            this.advertisment = advertisment;
            this.dbController = databaseController;
            this.user = user;

            this.init();
        }

        private void init()
        {
            var petCategories = dbController.getAllPetCategories();
            this.petCategoryComboBox.DisplayMember = "Name";
            this.petCategoryComboBox.ValueMember = "Id";
            this.petCategoryComboBox.DataSource = petCategories;

            var settlements = dbController.getAllSettlements();
            this.settlementCombobox.DisplayMember = "Name";
            this.settlementCombobox.ValueMember = "Id";
            this.settlementCombobox.DataSource = settlements;

            if(this.advertisment != null)
            {
                this.petCategoryComboBox.SelectedValue = this.advertisment?.PetCategoryId;
                this.petNameTextBox.Text = this.advertisment?.PetName;
                this.petBirthDateMaskedTextbox.Text = this.advertisment?.PetBirthDate;
                this.breedTextBox.Text = this.advertisment?.BreedName;
                this.registrationPetDateMaskedTextBox.Text = this.advertisment?.RegisterDate;
                this.passportNumberTextBox.Text = this.advertisment?.PetPassportNumber;
                this.petSexCombobox.SelectedItem = this.advertisment?.PetSex;
                this.settlementCombobox.SelectedValue = this.advertisment?.SettlementId;
                this.additionalInformationTextBox.Text = this.advertisment?.AdditionalInformation;
                this.Text = "Изменить объявление - " + Properties.Resources.applicationCaption;
            }
            else
            {
                this.Text = "Подать объявление - " + Properties.Resources.applicationCaption;
                this.petSexCombobox.SelectedIndex = 0;
            }
        }

        private void clearFields()
        {
            this.petCategoryComboBox.SelectedIndex = 0;
            this.petNameTextBox.Text = "";
            this.petBirthDateMaskedTextbox.Text = "";
            this.breedTextBox.Text = "";
            this.registrationPetDateMaskedTextBox.Text = "";
            this.passportNumberTextBox.Text = "";
            this.petSexCombobox.SelectedIndex = 0;
            this.settlementCombobox.SelectedIndex = 0;
            this.additionalInformationTextBox.Text = "";
        }

        private bool ValidateFields()
        {

            try
            {
                if (this.petCategoryComboBox.SelectedValue == null)
                    throw new ArgumentNullException("Unexpected pet category");
                if (Validator.isTextBeginsWithSpaceOrEmpty(this.petNameTextBox.Text))
                    throw new ArgumentNullException("Unexpected pet name");
                if (this.petBirthDateMaskedTextbox.ValidateText() == null)
                    throw new ArgumentNullException("Invalidate pet birhtdate");
                if (Validator.isTextBeginsWithSpaceOrEmpty(this.breedTextBox.Text))
                    throw new ArgumentNullException("Unexpected pet breed");
                if (this.registrationPetDateMaskedTextBox.ValidateText() == null)
                    throw new ArgumentNullException("Invalidate pet register date");
                if (Validator.isTextBeginsWithSpaceOrEmpty(this.passportNumberTextBox.Text))
                    throw new ArgumentNullException("Unexpected pet pasport number");
                if (!this.petSexCombobox.SelectedItem.Equals("Мальчик") && !this.petSexCombobox.SelectedItem.Equals("Девочка"))
                    throw new ArgumentNullException("Unexpected pet sex");
                if (this.settlementCombobox.SelectedValue == null)
                    throw new ArgumentNullException("Unexpected settlement");
                if (Validator.isTextBeginsWithSpaceOrEmpty(this.additionalInformationTextBox.Text))
                    throw new ArgumentNullException("Unexpected additionalInformation");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields()) return;

            try
            {
                if (this.advertisment == null)
                {
                    //TODO add
                    var createdAdvertisment = this.dbController.createAdvertisment(new Advertisment()
                    {
                        PetCategoryId = (long)this.petCategoryComboBox.SelectedValue,
                        PetName = this.petNameTextBox.Text,
                        PetBirthDate = this.petBirthDateMaskedTextbox.Text,
                        SettlementId = (long)this.settlementCombobox.SelectedValue,
                        PetOwnerId = this.user?.Id == null ? 0 : this.user.Id,
                        RegisterDate = this.registrationPetDateMaskedTextBox.Text,
                        PetPassportNumber = this.passportNumberTextBox.Text,
                        BreedName = this.breedTextBox.Text,
                        PetSex = (string)this.petSexCombobox.SelectedItem,
                        AdditionalInformation = this.additionalInformationTextBox.Text,
                        CreationDateTime = DateTime.Now.ToShortDateString()
                    });
                    if (createdAdvertisment == null)
                        MessageBox.Show("Произошла ошибка при создании объявления");

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new Exception();
                    //TODO updateAdd(this.advertisment); method
                }
            }
            catch
            {
                MessageBox.Show($"Произошла ошибка при {(this.advertisment == null ? "создании" : "редактировании")} объявления");
            }
        }

        private void previousPhotoButton_Click(object sender, EventArgs e)
        {

        }

        private void AddChangeAdForm_Load(object sender, EventArgs e)
        {
            loadPhotographies();
        }

        private void loadPhotographies()
        {
            object[] photos = new object[0];
            //TODO Load photo
            if (photos.Length == 0)
            {
                Label label = new Label()
                {
                    Text = "Фотографий не найдено",
                    AutoSize = true,
                    Location = new Point(panel1.Location.X, panel1.Location.Y + panel1.Size.Height / 2),
                    Dock = DockStyle.Fill
                };
                panel1.Controls.Add(label);
                return;
            }
            Label label2 = new Label() //TODO убрать нахой реальный pictureBox ставить
            {
                Text = "*Фотографии*",
                AutoSize = true,
                Location = new Point(panel1.Location.X, panel1.Location.Y + panel1.Size.Height / 2),
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(label2);

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            //TODO if (isPermitted)
            openFileDialog1.ShowDialog();
            //TODO настроить openfileDialog
        }

        private void clearFieldsButton_Click(object sender, EventArgs e) => this.clearFields();

        private void petBirthDateMaskedTextbox_Leave(object sender, EventArgs e)
        {
            var result = this.petBirthDateMaskedTextbox.ValidateText();
            if (result == null)
            {
                MessageBox.Show("Невалидная дата", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.petBirthDateMaskedTextbox.Text = "";
            }
        }

        private void registrationPetDateMaskedTextBox_Leave(object sender, EventArgs e)
        {
            var result = this.registrationPetDateMaskedTextBox.ValidateText();
            if (result == null)
            {
                MessageBox.Show("Невалидная дата", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.registrationPetDateMaskedTextBox.Text = "";
            }
        }
    }
}
