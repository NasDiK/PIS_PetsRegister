using WinFormsApplication.Forms.MainForm.AllAdvertisments;
using WinFormsApplication.Controllers;
using WinFormsApplication.Utils;
//ОБРАЩЕНИЕ С ДБ ТОЛЬКО ЧЕРЕЗ КОНТРОЛЛЕРЫ.
//Если нужно дописать метод в БД то выносите это в контроллер, предварительно создав метод в сервисе БД

namespace WinFormsApplication
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.Text += " - "+Properties.Resources.applicationCaption;
            this.passwordMaskCheckbox.Checked = true;
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AllAdsForm allAdsForm = new AllAdsForm(this);
            allAdsForm.Show();
            this.Hide();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            //TODO test // regex101.com потренится

            //MessageBox.Show(Utils.Validator.isSolidTextField("").ToString());
            //MessageBox.Show(Utils.Validator.isSolidTextField(" ").ToString());
            //MessageBox.Show(Utils.Validator.isSolidTextField("12312321 12312312").ToString());
            //MessageBox.Show(Utils.Validator.isSolidTextField("123123 gfg").ToString());
            //MessageBox.Show(Utils.Validator.isSolidTextField("123123fsf").ToString());
            //MessageBox.Show(Utils.Validator.isSolidTextField("fdhjghsjdfghjksd1231123").ToString());

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

            var user = AuthController.AuthUser(loginTextBox.Text, passwordTextBox.Text);
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
            //TODO придумать как убрать этот костыль ахахах
        }
    }
}