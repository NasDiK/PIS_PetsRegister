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
        internal AddChangeMyPetForm(DatabaseController db, Pet? pet = null)
        {
            InitializeComponent();
        }
    }
}
