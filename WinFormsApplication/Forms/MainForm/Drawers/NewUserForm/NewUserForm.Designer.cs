namespace WinFormsApplication.Forms.MainForm.Drawers.NewUserForm
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.phoneTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(12, 128);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(244, 47);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(12, 12);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PlaceholderText = "Имя пользователя";
            this.usernameTextbox.Size = new System.Drawing.Size(244, 23);
            this.usernameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(12, 41);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PlaceholderText = "Пароль";
            this.passwordTextbox.Size = new System.Drawing.Size(157, 23);
            this.passwordTextbox.TabIndex = 2;
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.Location = new System.Drawing.Point(12, 70);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.PlaceholderText = "Ф. И. О.";
            this.fullnameTextbox.Size = new System.Drawing.Size(244, 23);
            this.fullnameTextbox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(175, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Скрыть";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(12, 99);
            this.phoneTextbox.Mask = "\\7 \\(\\900\\) 000\\-0000";
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(244, 23);
            this.phoneTextbox.TabIndex = 5;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 184);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.registerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private TextBox fullnameTextbox;
        private CheckBox checkBox1;
        private MaskedTextBox phoneTextbox;
    }
}