﻿using System.Runtime.CompilerServices;
using WinFormsApplication.Controllers;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm;
using WinFormsApplication.Forms.MainForm.Drawers.NewUserForm;
using WinFormsApplication.Forms.MainForm.Drawers.PetCardForm;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class AllAdsForm : Form
    {
        private AuthForm authForm;
        private Filter filter; //todo как передавать управление??? allAds:this не робит
        private User? user;
        private List<Advertisment>? advertisments;
        private DatabaseController dbController;

        internal AllAdsForm(DatabaseController databaseController, AuthForm authForm, User? user = null)
        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;
            this.user = user;
            this.authForm = authForm;
            this.dbController = databaseController;
            this.rerenderPermittedButtons(this.user?.Role);
            this.filter = new Filter(this);

            this.advertisments = dbController.getAllAdvertisments();
            rerenderDataGridViewTable();
        }

        private void rerenderDataGridViewTable()
        {
            //todo прикрутить фильтр
            this.advertisments?.ForEach((advertisment) =>
            {
                this.dataViewTable.Rows.Add(
                    advertisment.Id,
                    advertisment.CreationDateTime,
                    null, advertisment.BreedName,
                    advertisment.PetSex,
                    dbController.getSettlementById(advertisment.SettlementId)?.Name
                );
            }); 
        }

        bool HandleUnauthorisedUsers()
        {
            var dialogResult = MessageBox.Show("Вы не авторизованы. Хотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NewUserForm newUser = new NewUserForm(dbController);
                var result = newUser.ShowDialog();
                if (result != DialogResult.Continue) return false;
                this.user = newUser.user;
                this.rerenderPermittedButtons(user?.Role);
                return true;
            }
            else return false;
        }

        private void rerenderPermittedButtons(Role? role)
        {
            switch (role?.Name)
            {
                case null:
                    //todo гость
                    this.myPetsButton.Enabled = false;
                    break;
                case "owner":
                    //todo владелец
                    this.myPetsButton.Enabled = true;
                    break;
                case "admin":
                    this.myPetsButton.Enabled = false;
                    //todo админ
                    break;
                //todo ещё роли
            }
        }

        private void rerenderDGVButtons()
        {
            //todo кнопки открыть изменить.
        }

        private void openAdButton_Click(object sender, EventArgs e)
        {
            PetCardForm petCardForm = new PetCardForm(this.dbController, this.advertisments?.FirstOrDefault(), this.user); //TODO переделать на currentRow. 
            petCardForm.ShowDialog();
            //todo может любой
        }

        private void AllAdsForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.Hide();
            this.authForm.Show();
        }

        private void addAdButton_Click(object sender, EventArgs e)
        {
            if (this.user == null && !this.HandleUnauthorisedUsers())
                return;

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(dbController, user);
            addChangeAdForm.ShowDialog();
        }

        private void chngAdButton_Click(object sender, EventArgs e)
        {
            var curAdd = this.advertisments?.FirstOrDefault();//TODO currentrow
            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(dbController, user, curAdd);
            addChangeAdForm.ShowDialog();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            filter.StartPosition = FormStartPosition.Manual;

            if (filter.Location.X + filter.Width >= SystemInformation.PrimaryMonitorSize.Width)
                filter.Location = new Point(SystemInformation.PrimaryMonitorSize.Width - filter.Width, filter.Location.Y);
            if (filter.Location.Y + filter.Height >= SystemInformation.PrimaryMonitorSize.Height)
                filter.Location = new Point(filter.Location.X, SystemInformation.PrimaryMonitorSize.Height - filter.Height - 50);

            filter.ShowDialog();
        }

        private void myPetsButton_Click(object sender, EventArgs e)
        {
            if (this.user == null && !this.HandleUnauthorisedUsers())
                return;

            MyPets myPets = new MyPets(); //TODO по юзеру цеплять
            myPets.ShowDialog();
        }

        private void dataViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rerenderDGVButtons();
        }

        
    }
}
