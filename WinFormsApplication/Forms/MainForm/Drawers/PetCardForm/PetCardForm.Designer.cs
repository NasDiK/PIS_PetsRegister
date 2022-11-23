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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.previousPhotoButton = new System.Windows.Forms.Button();
            this.nextPhotoButton = new System.Windows.Forms.Button();
            this.photoCountLabel = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.breedNameLabel = new System.Windows.Forms.Label();
            this.petSexLabel = new System.Windows.Forms.Label();
            this.settlementLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.additionalInformationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 54);
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
            this.panel2.Size = new System.Drawing.Size(928, 433);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.photoCountLabel);
            this.panel3.Controls.Add(this.nextPhotoButton);
            this.panel3.Controls.Add(this.previousPhotoButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 433);
            this.panel3.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(252, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 55);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.additionalInformationLabel);
            this.panel5.Controls.Add(this.categoryLabel);
            this.panel5.Controls.Add(this.settlementLabel);
            this.panel5.Controls.Add(this.petSexLabel);
            this.panel5.Controls.Add(this.breedNameLabel);
            this.panel5.Controls.Add(this.createdAtLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(252, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 378);
            this.panel5.TabIndex = 2;
            // 
            // previousPhotoButton
            // 
            this.previousPhotoButton.Location = new System.Drawing.Point(12, 283);
            this.previousPhotoButton.Name = "previousPhotoButton";
            this.previousPhotoButton.Size = new System.Drawing.Size(60, 23);
            this.previousPhotoButton.TabIndex = 1;
            this.previousPhotoButton.Text = "<";
            this.previousPhotoButton.UseVisualStyleBackColor = true;
            // 
            // nextPhotoButton
            // 
            this.nextPhotoButton.Location = new System.Drawing.Point(177, 283);
            this.nextPhotoButton.Name = "nextPhotoButton";
            this.nextPhotoButton.Size = new System.Drawing.Size(60, 23);
            this.nextPhotoButton.TabIndex = 2;
            this.nextPhotoButton.Text = ">";
            this.nextPhotoButton.UseVisualStyleBackColor = true;
            // 
            // photoCountLabel
            // 
            this.photoCountLabel.AutoSize = true;
            this.photoCountLabel.Location = new System.Drawing.Point(114, 287);
            this.photoCountLabel.Name = "photoCountLabel";
            this.photoCountLabel.Size = new System.Drawing.Size(24, 15);
            this.photoCountLabel.TabIndex = 3;
            this.photoCountLabel.Text = "0/0";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createdAtLabel.Location = new System.Drawing.Point(19, 21);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(321, 30);
            this.createdAtLabel.TabIndex = 0;
            this.createdAtLabel.Text = "Дата размещения объявления:";
            // 
            // breedNameLabel
            // 
            this.breedNameLabel.AutoSize = true;
            this.breedNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breedNameLabel.Location = new System.Drawing.Point(19, 68);
            this.breedNameLabel.Name = "breedNameLabel";
            this.breedNameLabel.Size = new System.Drawing.Size(91, 30);
            this.breedNameLabel.TabIndex = 1;
            this.breedNameLabel.Text = "Кличка:";
            // 
            // petSexLabel
            // 
            this.petSexLabel.AutoSize = true;
            this.petSexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petSexLabel.Location = new System.Drawing.Point(19, 112);
            this.petSexLabel.Name = "petSexLabel";
            this.petSexLabel.Size = new System.Drawing.Size(174, 30);
            this.petSexLabel.TabIndex = 2;
            this.petSexLabel.Text = "Пол животного:";
            // 
            // settlementLabel
            // 
            this.settlementLabel.AutoSize = true;
            this.settlementLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settlementLabel.Location = new System.Drawing.Point(19, 159);
            this.settlementLabel.Name = "settlementLabel";
            this.settlementLabel.Size = new System.Drawing.Size(202, 30);
            this.settlementLabel.TabIndex = 3;
            this.settlementLabel.Text = "Населённый пункт:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(19, 202);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(129, 30);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Категория?:";
            // 
            // additionalInformationLabel
            // 
            this.additionalInformationLabel.AutoEllipsis = true;
            this.additionalInformationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationLabel.Location = new System.Drawing.Point(19, 248);
            this.additionalInformationLabel.Name = "additionalInformationLabel";
            this.additionalInformationLabel.Size = new System.Drawing.Size(645, 118);
            this.additionalInformationLabel.TabIndex = 5;
            this.additionalInformationLabel.Text = "Дополнительная информация: ";
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PetCardForm";
            this.Text = "ShowAdForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private Label breedNameLabel;
        private Label createdAtLabel;
        private Panel panel4;
        private Label photoCountLabel;
        private Button nextPhotoButton;
        private Button previousPhotoButton;
        private Label additionalInformationLabel;
    }
}