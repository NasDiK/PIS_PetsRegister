using System.Data;
using WinFormsApplication.Controllers;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeAdForm;
using WinFormsApplication.Forms.MainForm.Drawers.AddChangeMyPetForm;
using WinFormsApplication.Forms.MainForm.Drawers.MyPetCardForm;
using WinFormsApplication.Models.Entities;
using Xceed.Words.NET;

namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    public partial class MyPets : Form
    {
        OwnPetsController ownPetsController;
        User? user;
        List<Pet> pets;
        public MyPets(User user)
        {
            InitializeComponent();

            this.Text = "Мои домашние животные - " + Properties.Resources.applicationCaption;

            ownPetsController = new OwnPetsController();
            this.user = user;

            rerenderDataGridViewTable();
            //todo getUserAnimals(this.user.id);
            //todo resubmitAnimal() // подать объявление с этим животным


        }

        internal void rerenderDataGridViewTable()
        {
            this.pets = ownPetsController.getUserAnimals(user.Id).ToList();
            this.dataViewTable.Rows.Clear();
            foreach (var pet in pets)
            {
                dataViewTable.Rows.Add(
                    pet.Id,
                    pet.PetName,
                    pet.PetBirthDate,
                    pet.RegisterDate,
                    pet.PetPassportNumber,
                    pet.BreedName,
                    pet.PetSex
                    );
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            var petId = int.Parse(dataViewTable.CurrentRow.Cells[0].Value.ToString());
            Pet myPet = ownPetsController.getPetById(petId);
            MyPetCardForm myPetCardForm = new MyPetCardForm(myPet);
            myPetCardForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(user);
            addChangeMyPetForm.ShowDialog();
            rerenderDataGridViewTable();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // TODO: Убрать null
            var petId = int.Parse(dataViewTable.CurrentRow.Cells["id"].Value.ToString());
            Pet currentPet = ownPetsController.getPetById(petId);
            AddChangeMyPetForm addChangeMyPetForm = new AddChangeMyPetForm(user, currentPet);
            addChangeMyPetForm.ShowDialog();
            rerenderDataGridViewTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(dataViewTable.CurrentRow.Cells["id"].Value.ToString());
            ownPetsController.deletePet(petId);
            rerenderDataGridViewTable();
        }

        private void buttonSubmitAd_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(dataViewTable.CurrentRow.Cells["id"].Value.ToString());
            Pet currentPet = ownPetsController.getPetById(petId);
            AddChangeAdForm addChangeAdForm = new AddChangeAdForm(user, null, currentPet);
            addChangeAdForm.ShowDialog();
        }

        private void buttonExportDocx_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(dataViewTable.CurrentRow.Cells["id"].Value.ToString());
            Pet currentPet = ownPetsController.getPetById(petId);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "docx | *.docx"; saveFileDialog.FileName = "reportAnimal";
            var filePath = saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : null;

            if (filePath != null && currentPet != null)
            {
                var doc = DocX.Create(filePath);

                doc.InsertParagraph($"Карточка животного №{currentPet.Id}");
                doc.InsertParagraph($"Кличка: {currentPet.PetName}");
                doc.InsertParagraph($"Дата рождения: {currentPet.PetBirthDate}");
                doc.InsertParagraph($"Дата регистрации: {currentPet.RegisterDate}");
                doc.InsertParagraph($"Номер паспорта: {currentPet.PetPassportNumber}");
                doc.InsertParagraph($"Порода: {currentPet.BreedName}");
                doc.InsertParagraph($"Пол: {currentPet.PetSex}");

                ExportFileController.ExportFile(filePath, Enums.FileType.WORD, doc);
            }
        }

        private void buttonExportTable_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "excel | *.xlsx"; saveFileDialog.FileName = "AnimalsTable";
            var filePath = saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : null;

            if (filePath != null)
            {

                //Creating DataTable.
                DataTable dt = new DataTable();
                //Adding the Columns.
                foreach (DataGridViewColumn column in dataViewTable.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }
                //Adding the Rows.
                foreach (DataGridViewRow row in dataViewTable.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                ExportFileController.ExportFile(filePath, Enums.FileType.EXCEL, dt);
            }
        }
    }
}
