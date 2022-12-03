using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Utils;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm
{
    public partial class AddChangeAdForm : Form
    {
        DatabaseController dbController;
        User? user;

        Image? curImage;

        List<Image>? images;
        string[]? filenamesToUpload;

        Advertisment? advertisment;
        internal AddChangeAdForm(DatabaseController databaseController, User? user, Advertisment? advertisment = null, Pet? animal = null)
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

            if (this.advertisment != null)
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

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg|Png files (.png)|*.png|JPEG (*.jpeg)|*.jpeg|All files|*.*";
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
                    if (createdAdvertisment == null) throw new Exception();

                    var guidFileNames = this.filenamesToUpload?.Select((filename) =>
                    {
                        var guidfileName = $"./adPhotos/{System.Guid.NewGuid()}";
                        var data = File.ReadAllBytes(filename);
                        File.WriteAllBytes(guidfileName, data);
                        return guidfileName;
                    });

                    if (guidFileNames != null && guidFileNames?.Count() > 0)
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                        dbController.UploadPhotographies(createdAdvertisment.Id, guidFileNames);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    var updateAdvertisment = this.dbController.UpdateAdvertisment(new Advertisment()
                    {
                        Id = this.advertisment.Id,
                        PetCategoryId = (long)this.petCategoryComboBox.SelectedValue,
                        PetName = this.petNameTextBox.Text,
                        PetBirthDate = this.petBirthDateMaskedTextbox.Text,
                        SettlementId = (long)this.settlementCombobox.SelectedValue,
                        RegisterDate = this.registrationPetDateMaskedTextBox.Text,
                        PetPassportNumber = this.passportNumberTextBox.Text,
                        BreedName = this.breedTextBox.Text,
                        PetSex = (string)this.petSexCombobox.SelectedItem,
                        AdditionalInformation = this.additionalInformationTextBox.Text
                    });

                    if (!updateAdvertisment) throw new Exception();

                    var guidFileNames = this.filenamesToUpload?.Select((filename) =>
                    {
                        var guidfileName = $"./adPhotos/{System.Guid.NewGuid()}";
                        var data = File.ReadAllBytes(filename);
                        File.WriteAllBytes(guidfileName, data);
                        return guidfileName;
                    });

                    if (guidFileNames != null && guidFileNames?.Count() > 0)
                        dbController.UploadPhotographies(this.advertisment.Id, guidFileNames);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Произошла ошибка при {(this.advertisment == null ? "создании" : "редактировании")} объявления");
            }
        }

        private void previousPhotoButton_Click(object sender, EventArgs e)
        {
            var index = this.images?.FindIndex((img) => Image.Equals(img, curImage));
            if (index == null || curImage == null || index == -1) return;

            if (index == 0) curImage = this.images?.Last();
            else curImage = this.images?[(int)index - 1];
            this.pictureBox1.Image = curImage;
        }

        private void AddChangeAdForm_Load(object sender, EventArgs e)
        {
            if (this.advertisment != null)
                loadPhotographies();

            if (this.advertisment == null)
            {
                //todo var useranimals = db.getUserAnimals(this.user?.Id);
                var userAnimals = new List<Pet>() { new Pet(), new Pet()}; //todo can be null
                if (userAnimals != null && userAnimals.Count != 0 && Utils.Utils.Confirm("Найдены ваши домашние животные. Хотите подставить?", "Подстановка ДЖ"))
                {
                    //todo Подставить ДЖ
                }
            }

        }

        private void loadPhotographies()
        {
            try
            {
                var photographies = dbController.getPhotographiesFilenames(this.advertisment?.Id);
                this.images = photographies.Select((photo) =>
                {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                    var img = Image.FromFile(photo.Filepath);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                    if (photo?.IsGeneral == true) curImage = img;
                    return img;
                }).ToList();

                if (this.images?.Count != 0)
                {
                    curImage ??= images?.FirstOrDefault();
                    pictureBox1.Image = curImage;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ошибка при загрузке фотографии. " + ex.ToString()); //TODO убрать экспепшн
            }

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.filenamesToUpload = openFileDialog.FileNames;
                var newList = this.images?.ToList() ?? new List<Image>();
                newList?.AddRange(this.filenamesToUpload.Select((fn) => Image.FromFile(fn)));
                this.images = newList?.ToList();
                curImage = images?.LastOrDefault();
                this.pictureBox1.Image = curImage;
            };
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

        private void nextPhotoButton_Click(object sender, EventArgs e)
        {
            var index = this.images?.FindIndex((img) => Image.Equals(img, curImage));
            if (index == null || curImage == null || index == -1) return;

            if (index == this.images?.Count - 1) curImage = this.images?.First();
            else curImage = this.images?[(int)index + 1];
            this.pictureBox1.Image = curImage;
        }
    }
}
