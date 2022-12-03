namespace WinFormsApplication.Forms.MainForm.Drawers.AddNewMyPet
{
    partial class AddNewMyPetForm
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
            this.registrationPetDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petSexCombobox = new System.Windows.Forms.ComboBox();
            this.petBirthDateMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationPetDateMaskedTextBox
            // 
            this.registrationPetDateMaskedTextBox.Location = new System.Drawing.Point(395, 139);
            this.registrationPetDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationPetDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationPetDateMaskedTextBox.Name = "registrationPetDateMaskedTextBox";
            this.registrationPetDateMaskedTextBox.Size = new System.Drawing.Size(340, 31);
            this.registrationPetDateMaskedTextBox.TabIndex = 38;
            this.registrationPetDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petSexCombobox
            // 
            this.petSexCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petSexCombobox.FormattingEnabled = true;
            this.petSexCombobox.Items.AddRange(new object[] {
            "Мальчик",
            "Девочка"});
            this.petSexCombobox.Location = new System.Drawing.Point(395, 228);
            this.petSexCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petSexCombobox.Name = "petSexCombobox";
            this.petSexCombobox.Size = new System.Drawing.Size(340, 33);
            this.petSexCombobox.TabIndex = 43;
            // 
            // petBirthDateMaskedTextbox
            // 
            this.petBirthDateMaskedTextbox.Location = new System.Drawing.Point(395, 53);
            this.petBirthDateMaskedTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petBirthDateMaskedTextbox.Mask = "00/00/0000";
            this.petBirthDateMaskedTextbox.Name = "petBirthDateMaskedTextbox";
            this.petBirthDateMaskedTextbox.Size = new System.Drawing.Size(340, 31);
            this.petBirthDateMaskedTextbox.TabIndex = 35;
            this.petBirthDateMaskedTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Location = new System.Drawing.Point(395, 184);
            this.passportNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(340, 31);
            this.passportNumberTextBox.TabIndex = 40;
            // 
            // breedTextBox
            // 
            this.breedTextBox.Location = new System.Drawing.Point(395, 94);
            this.breedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(340, 31);
            this.breedTextBox.TabIndex = 36;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(395, 9);
            this.petNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(340, 31);
            this.petNameTextBox.TabIndex = 33;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(18, 295);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(167, 72);
            this.confirmButton.TabIndex = 42;
            this.confirmButton.Text = "Сохранить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Пол животного";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Номер паспорта домашнего животного";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Дата регистрации животного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Порода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Имя животного";
            // 
            // AddNewMyPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 378);
            this.Controls.Add(this.registrationPetDateMaskedTextBox);
            this.Controls.Add(this.petSexCombobox);
            this.Controls.Add(this.petBirthDateMaskedTextbox);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(this.breedTextBox);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewMyPetForm";
            this.Text = "Добавить новое мое животное";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaskedTextBox registrationPetDateMaskedTextBox;
        private ComboBox petSexCombobox;
        private MaskedTextBox petBirthDateMaskedTextbox;
        private OpenFileDialog openFileDialog;
        private TextBox passportNumberTextBox;
        private TextBox breedTextBox;
        private TextBox petNameTextBox;
        private Button confirmButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}