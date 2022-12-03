namespace WinFormsApplication.Forms.MainForm.Drawers.MyPetCardForm
{
    partial class MyPetCardForm
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
            this.petSexLabel = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.petBirthDateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMyPetTitle = new System.Windows.Forms.Label();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.petPassportNumberLabel = new System.Windows.Forms.Label();
            this.breedNameLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // petSexLabel
            // 
            this.petSexLabel.AutoSize = true;
            this.petSexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petSexLabel.Location = new System.Drawing.Point(12, 277);
            this.petSexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petSexLabel.Name = "petSexLabel";
            this.petSexLabel.Size = new System.Drawing.Size(261, 45);
            this.petSexLabel.TabIndex = 2;
            this.petSexLabel.Text = "Пол животного:";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(20, 18);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(107, 53);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.delButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 722);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1623, 90);
            this.panel4.TabIndex = 1;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petNameLabel.Location = new System.Drawing.Point(12, 4);
            this.petNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(139, 45);
            this.petNameLabel.TabIndex = 1;
            this.petNameLabel.Text = "Кличка:";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.breedNameLabel);
            this.panel5.Controls.Add(this.petPassportNumberLabel);
            this.panel5.Controls.Add(this.registerDateLabel);
            this.panel5.Controls.Add(this.petSexLabel);
            this.panel5.Controls.Add(this.petNameLabel);
            this.panel5.Controls.Add(this.petBirthDateLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1623, 722);
            this.panel5.TabIndex = 2;
            // 
            // petBirthDateLabel
            // 
            this.petBirthDateLabel.AutoSize = true;
            this.petBirthDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petBirthDateLabel.Location = new System.Drawing.Point(12, 49);
            this.petBirthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petBirthDateLabel.Name = "petBirthDateLabel";
            this.petBirthDateLabel.Size = new System.Drawing.Size(434, 45);
            this.petBirthDateLabel.TabIndex = 0;
            this.petBirthDateLabel.Text = "Дата рождения животного:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1623, 812);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMyPetTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1623, 90);
            this.panel1.TabIndex = 2;
            // 
            // labelMyPetTitle
            // 
            this.labelMyPetTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyPetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMyPetTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMyPetTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyPetTitle.Name = "labelMyPetTitle";
            this.labelMyPetTitle.Size = new System.Drawing.Size(1623, 90);
            this.labelMyPetTitle.TabIndex = 0;
            this.labelMyPetTitle.Text = "Карточка моего животного";
            this.labelMyPetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.AutoSize = true;
            this.registerDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerDateLabel.Location = new System.Drawing.Point(12, 104);
            this.registerDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(471, 45);
            this.registerDateLabel.TabIndex = 3;
            this.registerDateLabel.Text = "Дата регистрации животного:";
            // 
            // petPassportNumberLabel
            // 
            this.petPassportNumberLabel.AutoSize = true;
            this.petPassportNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petPassportNumberLabel.Location = new System.Drawing.Point(12, 160);
            this.petPassportNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petPassportNumberLabel.Name = "petPassportNumberLabel";
            this.petPassportNumberLabel.Size = new System.Drawing.Size(450, 45);
            this.petPassportNumberLabel.TabIndex = 4;
            this.petPassportNumberLabel.Text = "Номер паспорта животного:";
            // 
            // breedNameLabel
            // 
            this.breedNameLabel.AutoSize = true;
            this.breedNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breedNameLabel.Location = new System.Drawing.Point(12, 221);
            this.breedNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breedNameLabel.Name = "breedNameLabel";
            this.breedNameLabel.Size = new System.Drawing.Size(145, 45);
            this.breedNameLabel.TabIndex = 5;
            this.breedNameLabel.Text = "Порода:";
            // 
            // MyPetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 902);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyPetCardForm";
            this.Text = "Мои животные";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label petSexLabel;
        private Button delButton;
        private Panel panel4;
        private Label petNameLabel;
        private Panel panel5;
        private Label petBirthDateLabel;
        private Panel panel2;
        private Panel panel1;
        private Label labelMyPetTitle;
        private Label breedNameLabel;
        private Label petPassportNumberLabel;
        private Label registerDateLabel;
    }
}