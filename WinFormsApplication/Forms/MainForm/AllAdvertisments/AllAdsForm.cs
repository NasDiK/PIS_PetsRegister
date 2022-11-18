using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class AllAdsForm : Form
    {
        private User? user;

        internal AllAdsForm(User? user = null)

        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;
            this.user = user;
        }


        private void openAdButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AllAdsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addAdButton_Click(object sender, EventArgs e)
        {
            //TODO проверять права if(this.user==null) - он гость

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm();
            addChangeAdForm.ShowDialog();
        }

        private void chngAdButton_Click(object sender, EventArgs e)
        {
            //TODO проверять права if(this.user==null) - он гость

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(new Advertisment()); //TODO getAd(); и в конструктор
            addChangeAdForm.ShowDialog();
        }
    }
}
