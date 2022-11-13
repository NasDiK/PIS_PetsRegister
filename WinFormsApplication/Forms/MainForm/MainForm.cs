using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication.Forms.MainForm
{
    public partial class MainForm : Form
    {
        //TODO ЧЗХ, зачем она нам?
        public MainForm()
        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;
        }
    }
}
