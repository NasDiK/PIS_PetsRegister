using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Forms.MainForm.Drawers.MyPetCardForm;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeMyPetForm;
using WinFormsApplication.Controllers;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class MyPets : Form
    {
        OwnPetsController ownPetsController;
        User? user;
        List<Pet> pets;
        public MyPets(User user)
        {
            InitializeComponent();

            this.Text = "Мои домашние животные - " + Properties.Resources.applicationCaption;

            ownPetsController = new OwnPetsController();
            this.user = user;
            
            rerenderDataGridViewTable();
            //todo getUserAnimals(this.user.id);
            //todo resubmitAnimal() // подать объявление с этим животным


        }

        internal void rerenderDataGridViewTable()
        {
            this.pets = ownPetsController.getUserAnimals(user.Id).ToList();
            this.dataViewTable.Rows.Clear();
            foreach (var pet in pets)
            {
                dataViewTable.Rows.Add(
                    pet.Id,
                    pet.PetName,
                    pet.PetBirthDate,
                    pet.RegisterDate,
                    pet.PetPassportNumber,
                    pet.BreedName,
                    pet.PetSex
                    );
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            var petId = int.Parse(dataViewTable.CurrentRow.Cells[0].Value.ToString());
            Pet myPet = ownPetsController.getPetById(petId);
            MyPetCardForm myPetCardForm = new MyPetCardForm(myPet);
            myPetCardForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(user, null);
            addChangeMyPetForm.ShowDialog();
            rerenderDataGridViewTable();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(null);
            addChangeMyPetForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(dataViewTable.CurrentRow.Cells[0].Value.ToString());
            ownPetsController.deletePet(petId);
            rerenderDataGridViewTable();
        }
    }
}
