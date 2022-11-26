using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
