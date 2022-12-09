using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Utils;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm
{
    public partial class AddChangeAdForm : Form
    {
        User? user;
        Image? curImage;
        Pet? pet;

        int? generalIndex;

        List<(Photography?, Image)>? images;
        List<string>? filenamesToUpload;
        List<long> photoIdsToDelete;

        Advertisment? advertisment;

        PetCategoriesController petCategoriesController;
        SettlementsController settlementsController;
        AdvertismentsController advertismentsController;
        PhotographiesController photographiesController;
        internal AddChangeAdForm(User? user, Advertisment? advertisment = null, Pet? animal = null)
        {
            InitializeComponent();
            this.advertisment = advertisment;
            this.user = user;
            this.pet = animal;

            petCategoriesController = new PetCategoriesController();
            settlementsController = new SettlementsController();
            advertismentsController = new AdvertismentsController();
            photographiesController = new PhotographiesController();

            this.init();
        }

        private void init()
        {
            var petCategories = petCategoriesController.getAllPetCategories();
            this.petCategoryComboBox.DisplayMember = "Name";
            this.petCategoryComboBox.ValueMember = "Id";
            this.petCategoryComboBox.DataSource = petCategories;

            var settlements = settlementsController.GetSettlementsList();
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
            this.photoIdsToDelete = new List<long>();

            openFileDialog.Filter = "All files|*.*|Bitmap files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg|Png files (.png)|*.png|JPEG (*.jpeg)|*.jpeg";

            this.images = new List<(Photography?, Image)>();
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
                    var createdAdvertisment = advertismentsController.createAdvertisment(new Advertisment()
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
                        photographiesController.UploadPhotographies(createdAdvertisment.Id, guidFileNames);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    var updateAdvertisment = advertismentsController.UpdateAdvertisment(new Advertisment()
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
                        photographiesController.UploadPhotographies(this.advertisment.Id, guidFileNames);

                    photoIdsToDelete.ForEach(id=>photographiesController.DeletePhotography(id));

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
            var index = this.images?.FindIndex((img) => Image.Equals(img.Item2, curImage));
            if (index == null || curImage == null || index == -1) return;

            if (index == 0) curImage = this.images?.Last().Item2;
            else curImage = this.images?[(int)index - 1].Item2;
            this.pictureBox1.Image = curImage;
        }

        private void AddChangeAdForm_Load(object sender, EventArgs e)
        {
            if (this.advertisment != null)
                loadPhotographies();

            if (this.advertisment == null)
            {
                if (this.pet != null)
                {
                    this.petNameTextBox.Text = this.pet.PetName;
                    this.petBirthDateMaskedTextbox.Text = this.pet.PetBirthDate;
                    this.breedTextBox.Text = this.pet.BreedName;
                    this.registrationPetDateMaskedTextBox.Text = this.pet.RegisterDate;
                    this.passportNumberTextBox.Text = this.pet.PetPassportNumber;
                    this.petSexCombobox.SelectedItem = this.pet.PetSex;
                } else {
                    //todo var useranimals = db.getUserAnimals(this.user?.Id);
                    var userAnimals = new List<Pet>() { new Pet(), new Pet() }; //todo can be null
                    if (userAnimals != null && userAnimals.Count != 0 && Utils.Utils.Confirm("Найдены ваши домашние животные. Хотите подставить?", "Подстановка ДЖ"))
                    {
                        //todo Подставить ДЖ
                    }
                }

                


            }

        }

        private void loadPhotographies()
        {
            try
            {
                var photographies = this.advertisment?.Photographies;
                this.images = photographies?.Select((photo, index) =>
                {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                    var img = Image.FromFile(photo.Filepath);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                    if (photo?.IsGeneral == "true")
                    {
                        generalIndex = index;
                        curImage = img;
                    }
                    return (photo,img);
                }).ToList();

                if (this.images?.Count != 0)
                {
                    curImage ??= images?.FirstOrDefault().Item2;
                    pictureBox1.Image = curImage;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show("Ошибка при загрузке фотографии. " + ex.ToString()); 
            }

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.filenamesToUpload = openFileDialog.FileNames.ToList();
                this.filenamesToUpload.ForEach((fn) => this.images.Add((new Photography() { Id=-1, Filepath = fn}, Image.FromFile(fn))));

                curImage = images?.LastOrDefault().Item2;
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
            var index = this.images?.FindIndex((img) => Image.Equals(img.Item2, curImage));
            if (index == null || curImage == null || index == -1) return;

            if (index == this.images?.Count - 1) curImage = this.images?.First().Item2;
            else curImage = this.images?[(int)index + 1].Item2;
            this.pictureBox1.Image = curImage;
        }

        private void delPhotoBtn_Click(object sender, EventArgs e)
        {
            if (curImage == null) return;
            var curImgIndex = this.images.FindIndex((img) => Image.Equals(img.Item2, curImage));

            var toDelPhoto = this.images.Find((img) => Image.Equals(img.Item2, curImage));

            if (toDelPhoto.Item1.Id == -1) //фото локально в форме, а не в базе
            {
                this.filenamesToUpload.Remove(toDelPhoto.Item1.Filepath);
            }
            else if(this.advertisment!= null) //фото не только в форме, но и в базе. + это форма изменения (подстраховка)
            {
                this.photoIdsToDelete.Add(toDelPhoto.Item1.Id);
            }

            this.images.Remove(toDelPhoto);
            curImage = this.images.Count == 0 ? null :
                curImgIndex == 0 ? this.images.Last().Item2 : this.images[curImgIndex - 1].Item2;
            this.pictureBox1.Image = curImage;
        }

        private void isGeneralBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
