using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Controllers;
using WinFormsApplication.Enums;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Utils;
using Validator = WinFormsApplication.Utils.Validator;

namespace WinFormsApplication.Forms.MainForm.Drawers.NewUserForm
{
    public partial class NewUserForm : Form
    {
        public User? user;
        AuthController authController;

        internal NewUserForm()
        {
            InitializeComponent();
            this.Text = "Новый пользователь - " + Properties.Resources.applicationCaption;
            this.checkBox1.Checked = true;
            this.authController = new AuthController();
        }

        private bool validateFields()
        {
            var formatedPhone = phoneTextbox.Text.Replace(" (", "").Replace("-", "").Replace(") ", "");
            try
            {
                if (!Validator.isUserName(this.usernameTextbox.Text))
                    throw new Exception("Invalidate username");
                if (!Validator.isTextWithoutSpaces(this.passwordTextbox.Text))
                    throw new Exception("Invalidate password");
                if (!Validator.isTextPhoneNumber(formatedPhone))
                    throw new Exception("Invalidate phone number");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = checkBox1.Checked ? '*' : new TextBox().PasswordChar;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!this.validateFields()) return;
            var formatedPhone = phoneTextbox.Text.Replace(" (", "").Replace("-", "").Replace(") ", "");
            var newUser = authController.RegisterUser(
                this.usernameTextbox.Text,
                this.passwordTextbox.Text,
                formatedPhone,
                this.fullnameTextbox.Text,
                Roles.OWNER
            );

            if (newUser == null)
            {
                MessageBox.Show("Пользователь с таким именем пользователя или номером телефона уже существует");
                return;
            }

            this.user = newUser;
            this.DialogResult = DialogResult.Continue;
        }
    }
}
