using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.Drawers.MyPetCardForm
{
    public partial class MyPetCardForm : Form
    {
        Pet pet;
        public MyPetCardForm(Pet pet)
        {
            this.pet = pet;

            InitializeComponent();

            this.Text = "Карточка моего домашнего животного - " + Properties.Resources.applicationCaption;
        }
    }
}
