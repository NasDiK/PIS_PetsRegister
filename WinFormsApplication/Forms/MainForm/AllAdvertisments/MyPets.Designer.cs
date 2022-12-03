namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    partial class MyPets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSubmitAd = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataViewTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSubmitAd);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 90);
            this.panel1.TabIndex = 0;
            // 
            // buttonSubmitAd
            // 
            this.buttonSubmitAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitAd.Location = new System.Drawing.Point(700, 20);
            this.buttonSubmitAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSubmitAd.Name = "buttonSubmitAd";
            this.buttonSubmitAd.Size = new System.Drawing.Size(318, 60);
            this.buttonSubmitAd.TabIndex = 4;
            this.buttonSubmitAd.Text = "Подать объявление";
            this.buttonSubmitAd.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpen.Location = new System.Drawing.Point(526, 20);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(166, 60);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(352, 20);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 60);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(178, 20);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(166, 60);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(17, 20);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 60);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataViewTable);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 527);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataViewTable
            // 
            this.dataViewTable.AllowUserToAddRows = false;
            this.dataViewTable.AllowUserToDeleteRows = false;
            this.dataViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PetName,
            this.PetBirthDay,
            this.RegisterDate,
            this.PetPassportNumber,
            this.BreedName,
            this.PetSex});
            this.dataViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewTable.Location = new System.Drawing.Point(0, 0);
            this.dataViewTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataViewTable.Name = "dataViewTable";
            this.dataViewTable.ReadOnly = true;
            this.dataViewTable.RowHeadersVisible = false;
            this.dataViewTable.RowHeadersWidth = 51;
            this.dataViewTable.RowTemplate.Height = 25;
            this.dataViewTable.Size = new System.Drawing.Size(1031, 527);
            this.dataViewTable.TabIndex = 2;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PetName
            // 
            this.PetName.HeaderText = "Кличка животного";
            this.PetName.MinimumWidth = 8;
            this.PetName.Name = "PetName";
            this.PetName.ReadOnly = true;
            // 
            // PetBirthDay
            // 
            this.PetBirthDay.HeaderText = "Дата рождения животного";
            this.PetBirthDay.MinimumWidth = 8;
            this.PetBirthDay.Name = "PetBirthDay";
            this.PetBirthDay.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "Дата регистрации";
            this.RegisterDate.MinimumWidth = 8;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // PetPassportNumber
            // 
            this.PetPassportNumber.HeaderText = "Номер паспорта домашнего животного";
            this.PetPassportNumber.MinimumWidth = 8;
            this.PetPassportNumber.Name = "PetPassportNumber";
            this.PetPassportNumber.ReadOnly = true;
            // 
            // BreedName
            // 
            this.BreedName.HeaderText = "Порода животного";
            this.BreedName.MinimumWidth = 8;
            this.BreedName.Name = "BreedName";
            this.BreedName.ReadOnly = true;
            // 
            // PetSex
            // 
            this.PetSex.HeaderText = "Пол животного";
            this.PetSex.MinimumWidth = 8;
            this.PetSex.Name = "PetSex";
            this.PetSex.ReadOnly = true;
            // 
            // MyPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyPets";
            this.Text = "MyPets";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button addButton;
        private DataGridView dataGridView1;
        private Button deleteButton;
        private Button buttonSubmitAd;
        private Button buttonOpen;
        private Button buttonEdit;
        private DataGridView dataViewTable;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn PetName;
        private DataGridViewTextBoxColumn PetBirthDay;
        private DataGridViewTextBoxColumn RegisterDate;
        private DataGridViewTextBoxColumn PetPassportNumber;
        private DataGridViewTextBoxColumn BreedName;
        private DataGridViewTextBoxColumn PetSex;
    }
}