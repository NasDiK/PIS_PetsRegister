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
    public partial class Filter : Form
    {
        AllAdsForm adsForm;
        public Filter(AllAdsForm allAds)
        {
            InitializeComponent();
            this.adsForm = allAds;
            this.init();
        }

        private void init()
        {
            this.settlementFilterCheckbox.CheckedChanged += (s, e) =>
            {
                if (this.settlementFilterCheckbox.Checked)
                {
                    this.settlementFilterTextbox.Focus();
                    //this.applyFilter();
                }
            };
            this.petCategoryFilterCheckbox.CheckedChanged += (s, e) =>
            {
                if (this.petCategoryFilterCheckbox.Checked)
                {
                    //this.applyFilter();

                }
            };
            this.datePropazhaFilterCheckbox.CheckedChanged += (s, e) =>
            {
                if (this.datePropazhaFilterCheckbox.Checked)
                {
                    this.propazhaDateTextBox.Focus();
                    //this.applyFilter();
                }
            };

        }
    }
}
