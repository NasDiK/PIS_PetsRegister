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
        }
    }
}
