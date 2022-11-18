namespace WinFormsApplication.Forms.MainForm.AllAdvertisments
{
    partial class AllAdsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAdsForm));
            this.toolbarPanel1 = new System.Windows.Forms.Panel();
            this.footerAddonsPanel = new System.Windows.Forms.Panel();
            this.displayMyCheckbox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panelСontent2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFooter3 = new System.Windows.Forms.Panel();
            this.addAdButton = new System.Windows.Forms.Button();
            this.delAddButton = new System.Windows.Forms.Button();
            this.chngAdButton = new System.Windows.Forms.Button();
            this.openAdButton = new System.Windows.Forms.Button();
            this.toolbarPanel1.SuspendLayout();
            this.footerAddonsPanel.SuspendLayout();
            this.panelСontent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFooter3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarPanel1
            // 
            this.toolbarPanel1.Controls.Add(this.footerAddonsPanel);
            this.toolbarPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarPanel1.Name = "toolbarPanel1";
            this.toolbarPanel1.Size = new System.Drawing.Size(811, 79);
            this.toolbarPanel1.TabIndex = 0;
            // 
            // footerAddonsPanel
            // 
            this.footerAddonsPanel.Controls.Add(this.displayMyCheckbox);
            this.footerAddonsPanel.Controls.Add(this.filterButton);
            this.footerAddonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.footerAddonsPanel.Location = new System.Drawing.Point(543, 0);
            this.footerAddonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.footerAddonsPanel.Name = "footerAddonsPanel";
            this.footerAddonsPanel.Size = new System.Drawing.Size(268, 79);
            this.footerAddonsPanel.TabIndex = 2;
            // 
            // displayMyCheckbox
            // 
            this.displayMyCheckbox.AutoSize = true;
            this.displayMyCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayMyCheckbox.Location = new System.Drawing.Point(29, 48);
            this.displayMyCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayMyCheckbox.Name = "displayMyCheckbox";
            this.displayMyCheckbox.Size = new System.Drawing.Size(227, 27);
            this.displayMyCheckbox.TabIndex = 0;
            this.displayMyCheckbox.Text = "Отображать только мои";
            this.displayMyCheckbox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(170, 13);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(86, 31);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // panelСontent2
            // 
            this.panelСontent2.Controls.Add(this.dataGridView1);
            this.panelСontent2.Controls.Add(this.panelFooter3);
            this.panelСontent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelСontent2.Location = new System.Drawing.Point(0, 79);
            this.panelСontent2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelСontent2.Name = "panelСontent2";
            this.panelСontent2.Padding = new System.Windows.Forms.Padding(11, 13, 11, 0);
            this.panelСontent2.Size = new System.Drawing.Size(811, 438);
            this.panelСontent2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(11, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(789, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelFooter3
            // 
            this.panelFooter3.Controls.Add(this.addAdButton);
            this.panelFooter3.Controls.Add(this.delAddButton);
            this.panelFooter3.Controls.Add(this.chngAdButton);
            this.panelFooter3.Controls.Add(this.openAdButton);
            this.panelFooter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter3.Location = new System.Drawing.Point(11, 366);
            this.panelFooter3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFooter3.Name = "panelFooter3";
            this.panelFooter3.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.panelFooter3.Size = new System.Drawing.Size(789, 72);
            this.panelFooter3.TabIndex = 0;
            // 
            // addAdButton
            // 
            this.addAdButton.Location = new System.Drawing.Point(278, 8);
            this.addAdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAdButton.Name = "addAdButton";
            this.addAdButton.Size = new System.Drawing.Size(141, 55);
            this.addAdButton.TabIndex = 3;
            this.addAdButton.Text = "Подать объявление";
            this.addAdButton.UseVisualStyleBackColor = true;
            this.addAdButton.Click += new System.EventHandler(this.addAdButton_Click);
            // 
            // delAddButton
            // 
            this.delAddButton.Location = new System.Drawing.Point(185, 8);
            this.delAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delAddButton.Name = "delAddButton";
            this.delAddButton.Size = new System.Drawing.Size(86, 55);
            this.delAddButton.TabIndex = 2;
            this.delAddButton.Text = "Удалить";
            this.delAddButton.UseVisualStyleBackColor = true;
            // 
            // chngAdButton
            // 
            this.chngAdButton.Location = new System.Drawing.Point(93, 8);
            this.chngAdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chngAdButton.Name = "chngAdButton";
            this.chngAdButton.Size = new System.Drawing.Size(86, 55);
            this.chngAdButton.TabIndex = 1;
            this.chngAdButton.Text = "Изменить";
            this.chngAdButton.UseVisualStyleBackColor = true;
            this.chngAdButton.Click += new System.EventHandler(this.chngAdButton_Click);
            // 
            // openAdButton
            // 
            this.openAdButton.Location = new System.Drawing.Point(0, 8);
            this.openAdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openAdButton.Name = "openAdButton";
            this.openAdButton.Size = new System.Drawing.Size(86, 55);
            this.openAdButton.TabIndex = 0;
            this.openAdButton.Text = "Открыть";
            this.openAdButton.UseVisualStyleBackColor = true;
            this.openAdButton.Click += new System.EventHandler(this.openAdButton_Click);
            // 
            // AllAdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 517);
            this.Controls.Add(this.panelСontent2);
            this.Controls.Add(this.toolbarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllAdsForm";
            this.Text = "Все объявления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllAdsForm_FormClosed);
            this.toolbarPanel1.ResumeLayout(false);
            this.footerAddonsPanel.ResumeLayout(false);
            this.footerAddonsPanel.PerformLayout();
            this.panelСontent2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFooter3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel toolbarPanel1;
        private Button filterButton;
        private CheckBox displayMyCheckbox;
        private Panel panelСontent2;
        private DataGridView dataGridView1;
        private Panel panelFooter3;
        private Button addAdButton;
        private Button delAddButton;
        private Button chngAdButton;
        private Button openAdButton;
        private Panel footerAddonsPanel;
    }
}