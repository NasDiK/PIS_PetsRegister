using WinFormsApplication.Models.Entities;
using ApplicationContext = WinFormsApplication.Services.Database.ApplicationContext;

namespace WinFormsApplication
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                db.roles.Add(new Roles() { Name="Администратор"});
                db.SaveChanges();
            }
        }
    }
}