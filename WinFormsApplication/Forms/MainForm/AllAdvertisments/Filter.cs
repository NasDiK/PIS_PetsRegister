using System.Collections.Immutable;
using System.Data;
using System.Text.RegularExpressions;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class Filter : Form
    {
        AllAdsForm adsForm;
        List<PetCategory> petCategories = new List<PetCategory>();
        public Filter(AllAdsForm allAds)
        {
            InitializeComponent();
            this.adsForm = allAds;
            this.init();
        }

        private void init()
        {
            petCategories = this.adsForm.petCategoriesController.getAllPetCategories();
            this.petCategoryFilterComboBox.DataSource = petCategories;
            this.petCategoryFilterComboBox.ValueMember = "Id";
            this.petCategoryFilterComboBox.DisplayMember = "Name";

            this.adsForm.filter.PetCategoryId = petCategories[0].Id;

            this.settlementFilterCheckbox.CheckedChanged += (s, e) =>
            {
                if (this.settlementFilterCheckbox.Checked)
                {
                    this.settlementFilterTextbox.Focus();
                }
                this.adsForm.filter.isSettlementsFilterActive = this.settlementFilterCheckbox.Checked;
                this.adsForm.rerenderDataGridViewTable();
            };
            this.settlementFilterTextbox.Leave += (s, e) =>
            {
                this.adsForm.filter.resetSettlementsList();
                var list = Regex.Matches(this.settlementFilterTextbox.Text, @"[А-Яа-я]+\s?[А-Яа-я]+").ToImmutableList(); //Получается работает только на слова с одним пробелом. ToFix
                list.ForEach(match => this.adsForm.filter.SettlementsName.Add(match.Value));

                if (this.adsForm.filter.isSettlementsFilterActive) 
                    this.adsForm.rerenderDataGridViewTable();
            };

            this.petCategoryFilterCheckbox.CheckedChanged += (s, e) =>
            {
                this.adsForm.filter.isPetCategoryFilterActive = this.petCategoryFilterCheckbox.Checked;
                this.adsForm.rerenderDataGridViewTable();
            };
            this.petCategoryFilterComboBox.SelectedValueChanged += (s, e) =>
            {
                this.adsForm.filter.PetCategoryId = (long)this.petCategoryFilterComboBox.SelectedValue;

                if (this.adsForm.filter.isPetCategoryFilterActive)
                    this.adsForm.rerenderDataGridViewTable();
            };

            this.datePropazhaFilterCheckbox.CheckedChanged += (s, e) =>
            {
                if (this.datePropazhaFilterCheckbox.Checked)
                {
                    this.propazhaDateTextBox.Focus();
                }
                this.adsForm.filter.isLostDatesFilterActive = this.datePropazhaFilterCheckbox.Checked;

                this.adsForm.rerenderDataGridViewTable();
            };
            this.propazhaDateTextBox.Leave += (s, e) =>
            {
                this.adsForm.filter.resetDates();
                var matches = Regex.Matches(this.propazhaDateTextBox.Text, @"^(>|<){1}\s\d{1,2}\.\d{1,2}.\d{4}\s?(and\s(>|<){1}\s\d{1,2}\.\d{1,2}.\d{4})?$")
                    .ToImmutableList(); //как в плейсхолдере

                if (matches.IsEmpty) return;
                var operands = matches[0].Value.Split("and");//> 25.16.2022
                var newOperands = operands
                    .Select(x => x.Replace(" ", "")) //[">25.06.2022","<26.12.2022"]
                    .Where(x => { try { Convert.ToDateTime(x.Substring(1)); return true; } catch { return false; } }) //where validDate
                    .ToList();
                if (newOperands.Count == 0)
                {
                    MessageBox.Show("Нет валидных полей");
                    this.propazhaDateTextBox.Text = "";
                }
                else newOperands.ForEach(x => { this.adsForm.filter.LostDates.Add((x[0].ToString(), x.Substring(1))); }); //Item1 - операнда, Item2-валидная дата

                if (this.adsForm.filter.isLostDatesFilterActive)
                    this.adsForm.rerenderDataGridViewTable();
            };

        }
    }
}
