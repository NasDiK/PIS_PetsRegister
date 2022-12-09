using System;
using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeMyPetForm
{
    public partial class AddChangeMyPetForm : Form
    {
        Pet? pet;
        User? user;
        internal AddChangeMyPetForm(User user, Pet? pet = null)
        {
            InitializeComponent();
            this.pet = pet;
            this.user = user;

            var caption = pet != null ? "Изменение собственного животного" : "Добавление собственного животного";
            this.Text = caption + " - " + Properties.Resources.applicationCaption;

            if (pet != null)
            {
                this.petNameTextBox.Text = pet.PetName;
                this.petBirthDateMaskedTextbox.Text = pet.PetBirthDate;
                this.breedTextBox.Text = pet.BreedName;
                this.registrationPetDateMaskedTextBox.Text = pet.RegisterDate;
                this.passportNumberTextBox.Text = pet.PetPassportNumber;
                this.petSexCombobox.SelectedItem = pet.PetSex;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            OwnPetsController ownPetsController = new OwnPetsController();
            Pet newPet = new Pet {
                PetName = this.petNameTextBox.Text,
                PetBirthDate = this.petBirthDateMaskedTextbox.Text,
                RegisterDate = this.registrationPetDateMaskedTextBox.Text,
                PetPassportNumber = this.passportNumberTextBox.Text,
                BreedName = this.breedTextBox.Text,
                PetSex = this.petSexCombobox.SelectedItem.ToString(),
                OwnerId = this.user.Id,
            };
            ownPetsController.registerPet(newPet);
            this.DialogResult = DialogResult.OK;
        }
    }
}
