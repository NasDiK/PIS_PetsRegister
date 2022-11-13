using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm
{
    public partial class AddChangeAdForm : Form
    {

        /*
            На обсуждение: точно ли мы ФИО вписываем? Как мы будем цеплять к конкретному владельцу.
            Или у нас авторизовываются нашедшие
         */


        Advertisment? advertisment;
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        internal AddChangeAdForm(Advertisment advertisment = null)
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
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
    }
}
