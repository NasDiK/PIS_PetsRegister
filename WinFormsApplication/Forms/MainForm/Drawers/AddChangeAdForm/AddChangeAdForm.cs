using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm
{
    public partial class AddChangeAdForm : Form
    {

        /*
            На обсуждение: точно ли мы ФИО вписываем? Как мы будем цеплять к конкретному владельцу.
            Или у нас авторизовываются нашедшие
         */


        Advertisment? advertisment;
        internal AddChangeAdForm(Advertisment? advertisment = null)
        {
            InitializeComponent();
            this.advertisment = advertisment;

            if (this.advertisment == null)
            {
                //TODO Add
                this.Text = "Подать объявление - " + Properties.Resources.applicationCaption;
            }
            else
            {
                //TODO Change
                //Забиваем поля данными
                this.Text = "Изменить объявление - " + Properties.Resources.applicationCaption;
            }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //TODO валидаторы

            try
            {
                if (this.advertisment == null)
                {
                    //TODO add
                    throw new Exception();
                }
                else
                {
                    throw new Exception();
                    //TODO updateAdd(this.advertisment); method
                }
            }
            catch
            {
                MessageBox.Show($"Произошла ошибка при {(this.advertisment == null ? "создании" : "редактировании")} объявления");
            }

        }

        private void previousPhotoButton_Click(object sender, EventArgs e)
        {

        }

        private void AddChangeAdForm_Load(object sender, EventArgs e)
        {
            loadPhotographies();
        }

        private void loadPhotographies()
        {
            object[] photos = new object[0];
            //TODO Load photo
            if(photos.Length == 0)
            {
                Label label = new Label()
                {
                    Text = "Фотографий не найдено",
                    AutoSize = true,
                    Location = new Point(panel1.Location.X, panel1.Location.Y + panel1.Size.Height / 2),
                    Dock = DockStyle.Fill
                };
                panel1.Controls.Add(label);
                return;
            }
            Label label2 = new Label() //TODO убрать нахой реальный pictureBox ставить
            {
                Text = "*Фотографии*",
                AutoSize = true,
                Location = new Point(panel1.Location.X, panel1.Location.Y + panel1.Size.Height / 2),
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(label2);

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            //TODO if (isPermitted)
            openFileDialog1.ShowDialog();
            //TODO настроить openfileDialog
        }
    }
}
