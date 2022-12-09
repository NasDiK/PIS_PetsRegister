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
        public MyPets(User user)
        {
            InitializeComponent();

            this.Text = "Мои домашние животные - " + Properties.Resources.applicationCaption;

            ownPetsController = new OwnPetsController();
            this.user = user;

            //todo getUserAnimals(this.user.id);
            //todo resubmitAnimal() // подать объявление с этим животным


        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            MyPetCardForm myPetCardForm = new MyPetCardForm(null);
            myPetCardForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(user, null);
            addChangeMyPetForm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(null);
            addChangeMyPetForm.ShowDialog();
        }
    }
}
