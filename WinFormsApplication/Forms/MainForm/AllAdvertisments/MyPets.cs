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
using WinFormsApplication.Forms.MainForm.Drawers.AddNewMyPet;
using WinFormsApplication.Forms.MainForm.Drawers.ChangeMyPetForm;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class MyPets : Form
    {
        public MyPets()
        {
            InitializeComponent();
            this.Text = "Мои домашние животные - " + Properties.Resources.applicationCaption;

            //todo getUserAnimals(this.user.id);
            //todo resubmitAnimal() // подать объявление с этим животным
            //updatePet
            //registerPet
            //deletePet

            //todo utils.Confirm() - для 8 лабы

            //todo удалить животное deleteOwnPet(id);
            //todo Confirm->utils
            //todo Notify() -> utils

            //todo OwnPetCardForm->registerPet(в дб контроллер);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            MyPetCardForm myPetCardForm = new MyPetCardForm();
            myPetCardForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewMyPetForm addNewMyPetForm = new AddNewMyPetForm();
            addNewMyPetForm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ChangeMyPetForm changeMyPetForm = new ChangeMyPetForm();
            changeMyPetForm.ShowDialog();
        }
    }
}
