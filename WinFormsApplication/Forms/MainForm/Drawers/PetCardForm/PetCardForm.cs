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
        internal PetCardForm(DatabaseController databaseController, Advertisment? advertisment, User? user)
        {
            InitializeComponent();
            this.advertisment = advertisment;
            this.db = databaseController;
            this.user = user;
            this.Text = "Карточка животного - " + Properties.Resources.applicationCaption;
            this.init();

            this.delButton.Click += (s, e) =>
            {
                MessageBox.Show("Test");
                //TODO делете
            };
        }

        private void init()
        {
            this.createdAtLabel.Text += " " + this.advertisment?.CreationDateTime;
            this.breedNameLabel.Text += " " + this.advertisment?.BreedName;
            this.petSexLabel.Text += " " + this.advertisment?.PetSex;
            this.settlementLabel.Text += " " + db.getSettlementById(Convert.ToInt64(this.advertisment?.SettlementId))?.Name;
            this.categoryLabel.Text += " " + db.getPetCategoryById(Convert.ToInt64(this.advertisment?.PetCategoryId))?.Name;
            this.additionalInformationLabel.Text += " " + this.advertisment?.AdditionalInformation;

            this.checkPermissions();
        }

        private void checkPermissions()
        {
            if (this.advertisment?.PetOwnerId == this.user?.Id || this.user?.Role?.Name == "admin")
            {
                this.delButton.Enabled = true;
            }
            else
            {
                this.delButton.Enabled = false;
            }
        }
    }
}
