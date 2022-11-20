using WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm;
using WinFormsApplication.Forms.MainForm.Drawers.NewUserForm;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class AllAdsForm : Form
    {
        private AuthForm authForm;
        private Filter filter = new Filter();
        private User? user;

        internal AllAdsForm(AuthForm authForm, User? user = null)

        {
            InitializeComponent();
            this.Text += " - " + Properties.Resources.applicationCaption;
            this.user = user;
            this.authForm = authForm;
        }

        bool HandleUnauthorisedUsers()
        {
            var dialogResult = MessageBox.Show("Вы не авторизованы. Хотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NewUserForm newUser = new NewUserForm();
                var result = newUser.ShowDialog();
                if (result != DialogResult.Continue) return false;
                //todo this.user = AuthController.RegisterUser(result.getData());
                //todo this.rerenderPermittedButtons(); //доступность кнопок по правам. вызывать по клике в DGV в т.ч.
                return true;
            }
            else return false;
        }

        private void openAdButton_Click(object sender, EventArgs e)
        {
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

            AddChangeAdForm addChangeAdForm = new AddChangeAdForm();
            addChangeAdForm.ShowDialog();
        }

        private void chngAdButton_Click(object sender, EventArgs e)
        {
            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(new Advertisment()); //TODO getAd(); и в конструктор
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

            MyPets myPets = new MyPets();
            myPets.ShowDialog();
        }


    }
}
