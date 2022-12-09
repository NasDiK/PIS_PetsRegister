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
        internal AddChangeMyPetForm(Pet? pet = null)
        {
            InitializeComponent();
            this.pet = pet;

            var caption = pet != null ? "Изменение собственного животного" : "Добавление собственного животного";
            this.Text = caption + " - " + Properties.Resources.applicationCaption;
        }
    }
}
