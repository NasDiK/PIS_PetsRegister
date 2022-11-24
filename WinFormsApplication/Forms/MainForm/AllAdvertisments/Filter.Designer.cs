namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    partial class Filter
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
            this.petCategoryFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.datePropazhaFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.settlementFilterTextbox = new System.Windows.Forms.TextBox();
            this.petCategoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.propazhaDateTextBox = new System.Windows.Forms.TextBox();
            this.settlementFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // petCategoryFilterCheckbox
            // 
            this.petCategoryFilterCheckbox.AutoSize = true;
            this.petCategoryFilterCheckbox.Location = new System.Drawing.Point(10, 43);
            this.petCategoryFilterCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.petCategoryFilterCheckbox.Name = "petCategoryFilterCheckbox";
            this.petCategoryFilterCheckbox.Size = new System.Drawing.Size(15, 14);
            this.petCategoryFilterCheckbox.TabIndex = 1;
            this.petCategoryFilterCheckbox.UseVisualStyleBackColor = true;
            // 
            // datePropazhaFilterCheckbox
            // 
            this.datePropazhaFilterCheckbox.AutoSize = true;
            this.datePropazhaFilterCheckbox.Location = new System.Drawing.Point(10, 77);
            this.datePropazhaFilterCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePropazhaFilterCheckbox.Name = "datePropazhaFilterCheckbox";
            this.datePropazhaFilterCheckbox.Size = new System.Drawing.Size(15, 14);
            this.datePropazhaFilterCheckbox.TabIndex = 2;
            this.datePropazhaFilterCheckbox.UseVisualStyleBackColor = true;
            // 
            // settlementFilterTextbox
            // 
            this.settlementFilterTextbox.Location = new System.Drawing.Point(31, 10);
            this.settlementFilterTextbox.Name = "settlementFilterTextbox";
            this.settlementFilterTextbox.PlaceholderText = "Тобольск|Воиновка";
            this.settlementFilterTextbox.Size = new System.Drawing.Size(170, 23);
            this.settlementFilterTextbox.TabIndex = 4;
            // 
            // petCategoryFilterComboBox
            // 
            this.petCategoryFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petCategoryFilterComboBox.FormattingEnabled = true;
            this.petCategoryFilterComboBox.Location = new System.Drawing.Point(31, 39);
            this.petCategoryFilterComboBox.Name = "petCategoryFilterComboBox";
            this.petCategoryFilterComboBox.Size = new System.Drawing.Size(170, 23);
            this.petCategoryFilterComboBox.TabIndex = 5;
            // 
            // propazhaDateTextBox
            // 
            this.propazhaDateTextBox.Location = new System.Drawing.Point(31, 73);
            this.propazhaDateTextBox.Name = "propazhaDateTextBox";
            this.propazhaDateTextBox.PlaceholderText = "> 25.06.2022 and < 27.12.2022";
            this.propazhaDateTextBox.Size = new System.Drawing.Size(170, 23);
            this.propazhaDateTextBox.TabIndex = 6;
            // 
            // settlementFilterCheckbox
            // 
            this.settlementFilterCheckbox.AutoSize = true;
            this.settlementFilterCheckbox.Location = new System.Drawing.Point(10, 14);
            this.settlementFilterCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settlementFilterCheckbox.Name = "settlementFilterCheckbox";
            this.settlementFilterCheckbox.Size = new System.Drawing.Size(15, 14);
            this.settlementFilterCheckbox.TabIndex = 7;
            this.settlementFilterCheckbox.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 106);
            this.Controls.Add(this.settlementFilterCheckbox);
            this.Controls.Add(this.propazhaDateTextBox);
            this.Controls.Add(this.petCategoryFilterComboBox);
            this.Controls.Add(this.settlementFilterTextbox);
            this.Controls.Add(this.datePropazhaFilterCheckbox);
            this.Controls.Add(this.petCategoryFilterCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox petCategoryFilterCheckbox;
        private CheckBox datePropazhaFilterCheckbox;
        private TextBox settlementFilterTextbox;
        private ComboBox petCategoryFilterComboBox;
        private TextBox propazhaDateTextBox;
        private CheckBox settlementFilterCheckbox;
    }
}