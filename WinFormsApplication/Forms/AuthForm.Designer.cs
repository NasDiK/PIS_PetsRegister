namespace WinFormsApplication
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.passwordMaskCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(77, 13);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PlaceholderText = "Введите имя пользователя...";
            this.loginTextBox.Size = new System.Drawing.Size(172, 27);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(77, 49);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Введите пароль...";
            this.passwordTextBox.Size = new System.Drawing.Size(172, 27);
            this.passwordTextBox.TabIndex = 4;
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(7, 108);
            this.authButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(86, 31);
            this.authButton.TabIndex = 5;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(112, 108);
            this.guestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(137, 31);
            this.guestButton.TabIndex = 6;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // passwordMaskCheckbox
            // 
            this.passwordMaskCheckbox.AutoSize = true;
            this.passwordMaskCheckbox.Location = new System.Drawing.Point(11, 83);
            this.passwordMaskCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordMaskCheckbox.Name = "passwordMaskCheckbox";
            this.passwordMaskCheckbox.Size = new System.Drawing.Size(152, 24);
            this.passwordMaskCheckbox.TabIndex = 7;
            this.passwordMaskCheckbox.Text = "Скрывать пароль";
            this.passwordMaskCheckbox.UseVisualStyleBackColor = true;
            this.passwordMaskCheckbox.CheckStateChanged += new System.EventHandler(this.passwordMaskCheckbox_CheckStateChanged);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 155);
            this.Controls.Add(this.passwordMaskCheckbox);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button authButton;
        private Button guestButton;
        private CheckBox passwordMaskCheckbox;
    }
}