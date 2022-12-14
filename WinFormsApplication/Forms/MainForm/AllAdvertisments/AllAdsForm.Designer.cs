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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAdsForm));
            this.toolbarPanel1 = new System.Windows.Forms.Panel();
            this.myPetsButton = new System.Windows.Forms.Button();
            this.footerAddonsPanel = new System.Windows.Forms.Panel();
            this.refreshTableButton = new System.Windows.Forms.Button();
            this.displayMyCheckbox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panelСontent2 = new System.Windows.Forms.Panel();
            this.dataViewTable = new System.Windows.Forms.DataGridView();
            this.panelFooter3 = new System.Windows.Forms.Panel();
            this.addAdButton = new System.Windows.Forms.Button();
            this.delAddButton = new System.Windows.Forms.Button();
            this.chngAdButton = new System.Windows.Forms.Button();
            this.openAdButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.breedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbarPanel1.SuspendLayout();
            this.footerAddonsPanel.SuspendLayout();
            this.panelСontent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTable)).BeginInit();
            this.panelFooter3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarPanel1
            // 
            this.toolbarPanel1.Controls.Add(this.myPetsButton);
            this.toolbarPanel1.Controls.Add(this.footerAddonsPanel);
            this.toolbarPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel1.Name = "toolbarPanel1";
            this.toolbarPanel1.Size = new System.Drawing.Size(710, 59);
            this.toolbarPanel1.TabIndex = 0;
            // 
            // myPetsButton
            // 
            this.myPetsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myPetsButton.Location = new System.Drawing.Point(10, 10);
            this.myPetsButton.Name = "myPetsButton";
            this.myPetsButton.Size = new System.Drawing.Size(92, 43);
            this.myPetsButton.TabIndex = 3;
            this.myPetsButton.Text = "Мои ДЖ";
            this.myPetsButton.UseVisualStyleBackColor = true;
            this.myPetsButton.Click += new System.EventHandler(this.myPetsButton_Click);
            // 
            // footerAddonsPanel
            // 
            this.footerAddonsPanel.Controls.Add(this.refreshTableButton);
            this.footerAddonsPanel.Controls.Add(this.displayMyCheckbox);
            this.footerAddonsPanel.Controls.Add(this.filterButton);
            this.footerAddonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.footerAddonsPanel.Location = new System.Drawing.Point(476, 0);
            this.footerAddonsPanel.Name = "footerAddonsPanel";
            this.footerAddonsPanel.Size = new System.Drawing.Size(234, 59);
            this.footerAddonsPanel.TabIndex = 2;
            // 
            // refreshTableButton
            // 
            this.refreshTableButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshTableButton.Location = new System.Drawing.Point(119, 10);
            this.refreshTableButton.Name = "refreshTableButton";
            this.refreshTableButton.Size = new System.Drawing.Size(24, 24);
            this.refreshTableButton.TabIndex = 2;
            this.refreshTableButton.Text = "О";
            this.refreshTableButton.UseVisualStyleBackColor = true;
            this.refreshTableButton.Click += new System.EventHandler(this.refreshTableButton_Click);
            // 
            // displayMyCheckbox
            // 
            this.displayMyCheckbox.AutoSize = true;
            this.displayMyCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayMyCheckbox.Location = new System.Drawing.Point(50, 35);
            this.displayMyCheckbox.Name = "displayMyCheckbox";
            this.displayMyCheckbox.Size = new System.Drawing.Size(181, 21);
            this.displayMyCheckbox.TabIndex = 0;
            this.displayMyCheckbox.Text = "Отображать только мои";
            this.displayMyCheckbox.UseVisualStyleBackColor = true;
            this.displayMyCheckbox.CheckedChanged += new System.EventHandler(this.displayMyCheckbox_CheckedChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(149, 10);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // panelСontent2
            // 
            this.panelСontent2.Controls.Add(this.dataViewTable);
            this.panelСontent2.Controls.Add(this.panelFooter3);
            this.panelСontent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelСontent2.Location = new System.Drawing.Point(0, 59);
            this.panelСontent2.Name = "panelСontent2";
            this.panelСontent2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelСontent2.Size = new System.Drawing.Size(710, 329);
            this.panelСontent2.TabIndex = 1;
            // 
            // dataViewTable
            // 
            this.dataViewTable.AllowUserToAddRows = false;
            this.dataViewTable.AllowUserToDeleteRows = false;
            this.dataViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.createdAt,
            this.petPhoto,
            this.breedName,
            this.petSex,
            this.settlementName,
            this.petName,
            this.petBirthDate});
            this.dataViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewTable.Location = new System.Drawing.Point(10, 10);
            this.dataViewTable.Name = "dataViewTable";
            this.dataViewTable.ReadOnly = true;
            this.dataViewTable.RowHeadersVisible = false;
            this.dataViewTable.RowHeadersWidth = 51;
            this.dataViewTable.RowTemplate.Height = 50;
            this.dataViewTable.Size = new System.Drawing.Size(690, 265);
            this.dataViewTable.TabIndex = 1;
            this.dataViewTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewTable_CellClick);
            this.dataViewTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewTable_CellDoubleClick);
            // 
            // panelFooter3
            // 
            this.panelFooter3.Controls.Add(this.addAdButton);
            this.panelFooter3.Controls.Add(this.delAddButton);
            this.panelFooter3.Controls.Add(this.chngAdButton);
            this.panelFooter3.Controls.Add(this.openAdButton);
            this.panelFooter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter3.Location = new System.Drawing.Point(10, 275);
            this.panelFooter3.Name = "panelFooter3";
            this.panelFooter3.Padding = new System.Windows.Forms.Padding(10);
            this.panelFooter3.Size = new System.Drawing.Size(690, 54);
            this.panelFooter3.TabIndex = 0;
            // 
            // addAdButton
            // 
            this.addAdButton.Location = new System.Drawing.Point(243, 6);
            this.addAdButton.Name = "addAdButton";
            this.addAdButton.Size = new System.Drawing.Size(123, 41);
            this.addAdButton.TabIndex = 3;
            this.addAdButton.Text = "Подать объявление";
            this.addAdButton.UseVisualStyleBackColor = true;
            this.addAdButton.Click += new System.EventHandler(this.addAdButton_Click);
            // 
            // delAddButton
            // 
            this.delAddButton.Location = new System.Drawing.Point(162, 6);
            this.delAddButton.Name = "delAddButton";
            this.delAddButton.Size = new System.Drawing.Size(75, 41);
            this.delAddButton.TabIndex = 2;
            this.delAddButton.Text = "Удалить";
            this.delAddButton.UseVisualStyleBackColor = true;
            // 
            // chngAdButton
            // 
            this.chngAdButton.Location = new System.Drawing.Point(81, 6);
            this.chngAdButton.Name = "chngAdButton";
            this.chngAdButton.Size = new System.Drawing.Size(75, 41);
            this.chngAdButton.TabIndex = 1;
            this.chngAdButton.Text = "Изменить";
            this.chngAdButton.UseVisualStyleBackColor = true;
            this.chngAdButton.Click += new System.EventHandler(this.chngAdButton_Click);
            // 
            // openAdButton
            // 
            this.openAdButton.Location = new System.Drawing.Point(0, 6);
            this.openAdButton.Name = "openAdButton";
            this.openAdButton.Size = new System.Drawing.Size(75, 41);
            this.openAdButton.TabIndex = 0;
            this.openAdButton.Text = "Открыть";
            this.openAdButton.UseVisualStyleBackColor = true;
            this.openAdButton.Click += new System.EventHandler(this.openAdButton_Click);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // createdAt
            // 
            this.createdAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createdAt.Frozen = true;
            this.createdAt.HeaderText = "Дата размещения";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            this.createdAt.Width = 137;
            // 
            // petPhoto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.petPhoto.DefaultCellStyle = dataGridViewCellStyle1;
            this.petPhoto.HeaderText = "Фотография";
            this.petPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.petPhoto.Name = "petPhoto";
            this.petPhoto.ReadOnly = true;
            // 
            // breedName
            // 
            this.breedName.HeaderText = "Кличка";
            this.breedName.Name = "breedName";
            this.breedName.ReadOnly = true;
            this.breedName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.breedName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // petSex
            // 
            this.petSex.HeaderText = "Пол";
            this.petSex.Name = "petSex";
            this.petSex.ReadOnly = true;
            // 
            // settlementName
            // 
            this.settlementName.HeaderText = "Населённый пункт";
            this.settlementName.Name = "settlementName";
            this.settlementName.ReadOnly = true;
            // 
            // petName
            // 
            this.petName.HeaderText = "Имя животного";
            this.petName.Name = "petName";
            this.petName.ReadOnly = true;
            // 
            // petBirthDate
            // 
            this.petBirthDate.HeaderText = "Дата рождения";
            this.petBirthDate.Name = "petBirthDate";
            this.petBirthDate.ReadOnly = true;
            // 
            // AllAdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 388);
            this.Controls.Add(this.panelСontent2);
            this.Controls.Add(this.toolbarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllAdsForm";
            this.Text = "Все объявления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllAdsForm_FormClosed);
            this.toolbarPanel1.ResumeLayout(false);
            this.footerAddonsPanel.ResumeLayout(false);
            this.footerAddonsPanel.PerformLayout();
            this.panelСontent2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTable)).EndInit();
            this.panelFooter3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel toolbarPanel1;
        private Button filterButton;
        private CheckBox displayMyCheckbox;
        private Panel panelСontent2;
        private DataGridView dataViewTable;
        private Panel panelFooter3;
        private Button addAdButton;
        private Button delAddButton;
        private Button chngAdButton;
        private Button openAdButton;
        private Panel footerAddonsPanel;
        private Button myPetsButton;
        private Button refreshTableButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn createdAt;
        private DataGridViewImageColumn petPhoto;
        private DataGridViewTextBoxColumn breedName;
        private DataGridViewTextBoxColumn petSex;
        private DataGridViewTextBoxColumn settlementName;
        private DataGridViewTextBoxColumn petName;
        private DataGridViewTextBoxColumn petBirthDate;
    }
}