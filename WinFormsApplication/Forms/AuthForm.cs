using WinFormsApplication.Forms.MainForm.AllAdvertisments;
using WinFormsApplication.Controllers;
using WinFormsApplication.Utils;

namespace WinFormsApplication
{
    public partial class AuthForm : Form
    {
        AuthController authController;
        public AuthForm()
        {
            InitializeComponent();
            this.Text += " - "+Properties.Resources.applicationCaption;
            this.passwordMaskCheckbox.Checked = true;
            this.authController = new AuthController();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AllAdsForm allAdsForm = new AllAdsForm(this);
            allAdsForm.Show();
            this.Hide();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (!Validator.isUserName(loginTextBox.Text) && !Validator.isTextPhoneNumber(loginTextBox.Text))
            {
                MessageBox.Show("Невалидный логин", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.isTextWithoutSpaces(passwordTextBox.Text) || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Невалидный пароль", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = authController.AuthUser(loginTextBox.Text, passwordTextBox.Text);
            if (user != null)
            {
                AllAdsForm allAdsForm = new AllAdsForm(this, user);
                allAdsForm.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Неправильные данные");
        }

        private void passwordMaskCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = passwordMaskCheckbox.Checked ? '*' : new TextBox().PasswordChar;
            //Todo тут костыль, а надо passwordChar как в оригинале (можно отдебажить)
        }
    }
}