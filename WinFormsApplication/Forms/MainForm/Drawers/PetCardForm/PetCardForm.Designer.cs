namespace WinFormsApplication.Forms.MainForm.Drawers.PetCardForm
{
    partial class PetCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetCardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.breedName = new System.Windows.Forms.Label();
            this.registerDate = new System.Windows.Forms.Label();
            this.passportNumberLabel = new System.Windows.Forms.Label();
            this.petBirthdate = new System.Windows.Forms.Label();
            this.additionalInformationLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.settlementLabel = new System.Windows.Forms.Label();
            this.petSexLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nextPhotoButton = new System.Windows.Forms.Button();
            this.previousPhotoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка животного";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 469);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.breedName);
            this.panel5.Controls.Add(this.registerDate);
            this.panel5.Controls.Add(this.passportNumberLabel);
            this.panel5.Controls.Add(this.petBirthdate);
            this.panel5.Controls.Add(this.additionalInformationLabel);
            this.panel5.Controls.Add(this.categoryLabel);
            this.panel5.Controls.Add(this.settlementLabel);
            this.panel5.Controls.Add(this.petSexLabel);
            this.panel5.Controls.Add(this.petNameLabel);
            this.panel5.Controls.Add(this.createdAtLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(251, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 414);
            this.panel5.TabIndex = 2;
            // 
            // breedName
            // 
            this.breedName.AutoSize = true;
            this.breedName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breedName.Location = new System.Drawing.Point(15, 283);
            this.breedName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.breedName.Name = "breedName";
            this.breedName.Size = new System.Drawing.Size(101, 30);
            this.breedName.TabIndex = 9;
            this.breedName.Text = "Порода: ";
            // 
            // registerDate
            // 
            this.registerDate.AutoSize = true;
            this.registerDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerDate.Location = new System.Drawing.Point(14, 238);
            this.registerDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(203, 30);
            this.registerDate.TabIndex = 8;
            this.registerDate.Text = "Дата регистрации: ";
            // 
            // passportNumberLabel
            // 
            this.passportNumberLabel.AutoSize = true;
            this.passportNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passportNumberLabel.Location = new System.Drawing.Point(13, 196);
            this.passportNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passportNumberLabel.Name = "passportNumberLabel";
            this.passportNumberLabel.Size = new System.Drawing.Size(188, 30);
            this.passportNumberLabel.TabIndex = 7;
            this.passportNumberLabel.Text = "Номер паспорта: ";
            // 
            // petBirthdate
            // 
            this.petBirthdate.AutoSize = true;
            this.petBirthdate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petBirthdate.Location = new System.Drawing.Point(14, 157);
            this.petBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petBirthdate.Name = "petBirthdate";
            this.petBirthdate.Size = new System.Drawing.Size(178, 30);
            this.petBirthdate.TabIndex = 6;
            this.petBirthdate.Text = "Дата рождения: ";
            // 
            // additionalInformationLabel
            // 
            this.additionalInformationLabel.AutoEllipsis = true;
            this.additionalInformationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationLabel.Location = new System.Drawing.Point(15, 322);
            this.additionalInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.additionalInformationLabel.Name = "additionalInformationLabel";
            this.additionalInformationLabel.Size = new System.Drawing.Size(440, 71);
            this.additionalInformationLabel.TabIndex = 5;
            this.additionalInformationLabel.Text = "Дополнительная информация: ";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(15, 127);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(120, 30);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Категория:";
            // 
            // settlementLabel
            // 
            this.settlementLabel.AutoSize = true;
            this.settlementLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settlementLabel.Location = new System.Drawing.Point(15, 97);
            this.settlementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settlementLabel.Name = "settlementLabel";
            this.settlementLabel.Size = new System.Drawing.Size(202, 30);
            this.settlementLabel.TabIndex = 3;
            this.settlementLabel.Text = "Населённый пункт:";
            // 
            // petSexLabel
            // 
            this.petSexLabel.AutoSize = true;
            this.petSexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petSexLabel.Location = new System.Drawing.Point(15, 67);
            this.petSexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petSexLabel.Name = "petSexLabel";
            this.petSexLabel.Size = new System.Drawing.Size(174, 30);
            this.petSexLabel.TabIndex = 2;
            this.petSexLabel.Text = "Пол животного:";
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petNameLabel.Location = new System.Drawing.Point(13, 37);
            this.petNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(176, 30);
            this.petNameLabel.TabIndex = 1;
            this.petNameLabel.Text = "Имя животного:";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createdAtLabel.Location = new System.Drawing.Point(13, 10);
            this.createdAtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(321, 30);
            this.createdAtLabel.TabIndex = 0;
            this.createdAtLabel.Text = "Дата размещения объявления:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(251, 414);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 55);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nextPhotoButton);
            this.panel3.Controls.Add(this.previousPhotoButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 469);
            this.panel3.TabIndex = 0;
            // 
            // nextPhotoButton
            // 
            this.nextPhotoButton.Location = new System.Drawing.Point(139, 283);
            this.nextPhotoButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextPhotoButton.Name = "nextPhotoButton";
            this.nextPhotoButton.Size = new System.Drawing.Size(98, 23);
            this.nextPhotoButton.TabIndex = 2;
            this.nextPhotoButton.Text = ">";
            this.nextPhotoButton.UseVisualStyleBackColor = true;
            this.nextPhotoButton.Click += new System.EventHandler(this.nextPhotoButton_Click);
            // 
            // previousPhotoButton
            // 
            this.previousPhotoButton.Location = new System.Drawing.Point(12, 283);
            this.previousPhotoButton.Name = "previousPhotoButton";
            this.previousPhotoButton.Size = new System.Drawing.Size(107, 23);
            this.previousPhotoButton.TabIndex = 1;
            this.previousPhotoButton.Text = "<";
            this.previousPhotoButton.UseVisualStyleBackColor = true;
            this.previousPhotoButton.Click += new System.EventHandler(this.previousPhotoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PetCardForm";
            this.Text = "ShowAdForm";
            this.Load += new System.EventHandler(this.PetCardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label categoryLabel;
        private Label settlementLabel;
        private Label petSexLabel;
        private Label petNameLabel;
        private Label createdAtLabel;
        private Panel panel4;
        private Button nextPhotoButton;
        private Button previousPhotoButton;
        private Label additionalInformationLabel;
        private Label breedName;
        private Label registerDate;
        private Label passportNumberLabel;
        private Label petBirthdate;
    }
}