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

namespace WinFormsApplication.Forms.MainForm.Drawers.PetCardForm
{
    public partial class PetCardForm : Form
    {
        Advertisment advertisment;
        public PetCardForm(Advertisment advertisment)
        {
            InitializeComponent();
            this.advertisment = advertisment;
            this.Text = "Карточка животного - " + Properties.Resources.applicationCaption;
        }
    }
}
