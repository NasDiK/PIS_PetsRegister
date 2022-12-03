namespace WinFormsApplication.Forms.MainForm.Drawers.ChangeMyPetForm
{
    partial class ChangeMyPetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMyPetForm));
            this.registrationPetDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petSexCombobox = new System.Windows.Forms.ComboBox();
            this.petBirthDateMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.petSexLabel = new System.Windows.Forms.Label();
            this.petPassportNumberLabel = new System.Windows.Forms.Label();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.breedLabel = new System.Windows.Forms.Label();
            this.petBirthDatelabel = new System.Windows.Forms.Label();
            this.petNamelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationPetDateMaskedTextBox
            // 
            this.registrationPetDateMaskedTextBox.Location = new System.Drawing.Point(390, 134);
            this.registrationPetDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationPetDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationPetDateMaskedTextBox.Name = "registrationPetDateMaskedTextBox";
            this.registrationPetDateMaskedTextBox.Size = new System.Drawing.Size(340, 31);
            this.registrationPetDateMaskedTextBox.TabIndex = 51;
            this.registrationPetDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petSexCombobox
            // 
            this.petSexCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petSexCombobox.FormattingEnabled = true;
            this.petSexCombobox.Items.AddRange(new object[] {
            "Мальчик",
            "Девочка"});
            this.petSexCombobox.Location = new System.Drawing.Point(390, 223);
            this.petSexCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petSexCombobox.Name = "petSexCombobox";
            this.petSexCombobox.Size = new System.Drawing.Size(340, 33);
            this.petSexCombobox.TabIndex = 56;
            // 
            // petBirthDateMaskedTextbox
            // 
            this.petBirthDateMaskedTextbox.Location = new System.Drawing.Point(390, 48);
            this.petBirthDateMaskedTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petBirthDateMaskedTextbox.Mask = "00/00/0000";
            this.petBirthDateMaskedTextbox.Name = "petBirthDateMaskedTextbox";
            this.petBirthDateMaskedTextbox.Size = new System.Drawing.Size(340, 31);
            this.petBirthDateMaskedTextbox.TabIndex = 48;
            this.petBirthDateMaskedTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Location = new System.Drawing.Point(390, 179);
            this.passportNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(340, 31);
            this.passportNumberTextBox.TabIndex = 53;
            // 
            // breedTextBox
            // 
            this.breedTextBox.Location = new System.Drawing.Point(390, 89);
            this.breedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(340, 31);
            this.breedTextBox.TabIndex = 49;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(390, 4);
            this.petNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(340, 31);
            this.petNameTextBox.TabIndex = 46;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(13, 290);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(167, 72);
            this.confirmButton.TabIndex = 55;
            this.confirmButton.Text = "Сохранить";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // petSexLabel
            // 
            this.petSexLabel.AutoSize = true;
            this.petSexLabel.Location = new System.Drawing.Point(13, 228);
            this.petSexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petSexLabel.Name = "petSexLabel";
            this.petSexLabel.Size = new System.Drawing.Size(140, 25);
            this.petSexLabel.TabIndex = 54;
            this.petSexLabel.Text = "Пол животного";
            // 
            // petPassportNumberLabel
            // 
            this.petPassportNumberLabel.AutoSize = true;
            this.petPassportNumberLabel.Location = new System.Drawing.Point(13, 184);
            this.petPassportNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petPassportNumberLabel.Name = "petPassportNumberLabel";
            this.petPassportNumberLabel.Size = new System.Drawing.Size(343, 25);
            this.petPassportNumberLabel.TabIndex = 52;
            this.petPassportNumberLabel.Text = "Номер паспорта домашнего животного";
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.AutoSize = true;
            this.registerDateLabel.Location = new System.Drawing.Point(13, 139);
            this.registerDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(252, 25);
            this.registerDateLabel.TabIndex = 50;
            this.registerDateLabel.Text = "Дата регистрации животного";
            // 
            // breedLabel
            // 
            this.breedLabel.AutoSize = true;
            this.breedLabel.Location = new System.Drawing.Point(13, 94);
            this.breedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breedLabel.Name = "breedLabel";
            this.breedLabel.Size = new System.Drawing.Size(77, 25);
            this.breedLabel.TabIndex = 47;
            this.breedLabel.Text = "Порода";
            // 
            // petBirthDatelabel
            // 
            this.petBirthDatelabel.AutoSize = true;
            this.petBirthDatelabel.Location = new System.Drawing.Point(13, 53);
            this.petBirthDatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petBirthDatelabel.Name = "petBirthDatelabel";
            this.petBirthDatelabel.Size = new System.Drawing.Size(137, 25);
            this.petBirthDatelabel.TabIndex = 45;
            this.petBirthDatelabel.Text = "Дата рождения";
            // 
            // petNamelabel
            // 
            this.petNamelabel.AutoSize = true;
            this.petNamelabel.Location = new System.Drawing.Point(13, 9);
            this.petNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petNamelabel.Name = "petNamelabel";
            this.petNamelabel.Size = new System.Drawing.Size(142, 25);
            this.petNamelabel.TabIndex = 44;
            this.petNamelabel.Text = "Имя животного";
            // 
            // ChangeMyPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 384);
            this.Controls.Add(this.registrationPetDateMaskedTextBox);
            this.Controls.Add(this.petSexCombobox);
            this.Controls.Add(this.petBirthDateMaskedTextbox);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(this.breedTextBox);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.petSexLabel);
            this.Controls.Add(this.petPassportNumberLabel);
            this.Controls.Add(this.registerDateLabel);
            this.Controls.Add(this.breedLabel);
            this.Controls.Add(this.petBirthDatelabel);
            this.Controls.Add(this.petNamelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeMyPetForm";
            this.Text = "Изменить карточку моего животного";
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
        private Label petSexLabel;
        private Label petPassportNumberLabel;
        private Label registerDateLabel;
        private Label breedLabel;
        private Label petBirthDatelabel;
        private Label petNamelabel;
    }
}