using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.Drawers.PetCardForm
{
    public partial class PetCardForm : Form
    {
        Advertisment? advertisment;
        DatabaseController db;
        User? user;
        Image[]? photographies;
        Image? curImage;
        internal PetCardForm(DatabaseController databaseController, Advertisment? advertisment, User? user)
        {
            InitializeComponent();
            this.advertisment = advertisment;
            this.db = databaseController;
            this.user = user;
            this.Text = "Карточка животного - " + Properties.Resources.applicationCaption;
            this.init();
        }

        private void init()
        {
            this.createdAtLabel.Text += " " + this.advertisment?.CreationDateTime;
            this.petNameLabel.Text += " " + this.advertisment?.PetName;
            this.petSexLabel.Text += " " + this.advertisment?.PetSex;
            this.settlementLabel.Text += " " + db.getSettlementById(Convert.ToInt64(this.advertisment?.SettlementId))?.Name;
            this.categoryLabel.Text += " " + db.getPetCategoryById(Convert.ToInt64(this.advertisment?.PetCategoryId))?.Name;
            this.additionalInformationLabel.Text += " " + this.advertisment?.AdditionalInformation;
            this.breedName.Text += " " + this.advertisment?.BreedName;
            this.passportNumberLabel.Text += " " + this.advertisment?.PetPassportNumber;
            this.registerDate.Text += " " + this.advertisment?.RegisterDate;
            this.petBirthdate.Text += " " + this.advertisment?.PetBirthDate;

            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            var filenames = this.advertisment?.Photographies;

            if(filenames!=null && filenames.Count>0)
            {
                this.photographies = filenames.Select((photo) => Image.FromFile(photo.Filepath)).ToArray();
                var generalImage = filenames.FirstOrDefault((photo) => photo.IsGeneral != null);
                if (generalImage != null)
                    this.curImage = Image.FromFile(generalImage.Filepath);
                else this.curImage = this.photographies.First();

                this.pictureBox1.Image = curImage;
            }
            
        }

        private void PetCardForm_Load(object sender, EventArgs e)
        {

        }

        private void previousPhotoButton_Click(object sender, EventArgs e)
        {
            if (curImage == null) return;
            var photographiesList = this.photographies.ToList(); var curImgItem = this.photographies.First(img => Image.Equals(img, curImage));
            var curIndex = photographiesList.IndexOf(curImgItem);
            if (curIndex - 1 < 0) curImage = this.photographies.Last();
            else curImage = this.photographies[curIndex - 1];

            this.pictureBox1.Image = curImage;
        }

        private void nextPhotoButton_Click(object sender, EventArgs e)
        {
            if (curImage == null) return;
            var photographiesList = this.photographies.ToList(); var curImgItem = this.photographies.First(img => Image.Equals(img, curImage));
            var curIndex = photographiesList.IndexOf(curImgItem);
            if (curIndex + 1 > this.photographies.Length-1) curImage = this.photographies.First();
            else curImage = this.photographies[curIndex + 1];

            this.pictureBox1.Image = curImage;
        }
    }
}
