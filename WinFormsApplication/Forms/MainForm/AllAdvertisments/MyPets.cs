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

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class MyPets : Form
    {
        OwnPetsController ownPetsController;
        public MyPets()
        {
            InitializeComponent();

            this.Text = "Мои домашние животные - " + Properties.Resources.applicationCaption;

            ownPetsController = new OwnPetsController();

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
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm();
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
