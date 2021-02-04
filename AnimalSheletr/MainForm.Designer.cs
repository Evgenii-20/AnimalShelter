namespace AnimalSheletr
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuItemInfoAnimals = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemAnimals = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemClassifications = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemVisitors = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemСontract = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemInfoexpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemTypeexpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemInfoVisitors = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemInfoAnimals,
            this.MainMenuItemVisitors,
            this.MainMenuItemСontract,
            this.MainMenuItemInfo,
            this.MainMenuItemReport});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenuItemInfoAnimals
            // 
            this.MainMenuItemInfoAnimals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemAnimals,
            this.MainMenuItemClassifications});
            this.MainMenuItemInfoAnimals.Name = "MainMenuItemInfoAnimals";
            this.MainMenuItemInfoAnimals.Size = new System.Drawing.Size(162, 20);
            this.MainMenuItemInfoAnimals.Text = "Информация о животных";
            // 
            // MainMenuItemAnimals
            // 
            this.MainMenuItemAnimals.Name = "MainMenuItemAnimals";
            this.MainMenuItemAnimals.Size = new System.Drawing.Size(180, 22);
            this.MainMenuItemAnimals.Text = "Животные";
            this.MainMenuItemAnimals.Click += new System.EventHandler(this.MainMenuItemAnimals_Click);
            // 
            // MainMenuItemClassifications
            // 
            this.MainMenuItemClassifications.Name = "MainMenuItemClassifications";
            this.MainMenuItemClassifications.Size = new System.Drawing.Size(180, 22);
            this.MainMenuItemClassifications.Text = "Классификация";
            // 
            // MainMenuItemVisitors
            // 
            this.MainMenuItemVisitors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemInfoVisitors});
            this.MainMenuItemVisitors.Name = "MainMenuItemVisitors";
            this.MainMenuItemVisitors.Size = new System.Drawing.Size(67, 20);
            this.MainMenuItemVisitors.Text = "Клиенты";
            // 
            // MainMenuItemСontract
            // 
            this.MainMenuItemСontract.Name = "MainMenuItemСontract";
            this.MainMenuItemСontract.Size = new System.Drawing.Size(72, 20);
            this.MainMenuItemСontract.Text = "Договора";
            // 
            // MainMenuItemInfo
            // 
            this.MainMenuItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemInfoexpenses,
            this.MainMenuItemTypeexpenses});
            this.MainMenuItemInfo.Name = "MainMenuItemInfo";
            this.MainMenuItemInfo.Size = new System.Drawing.Size(141, 20);
            this.MainMenuItemInfo.Text = "Информация о затрах";
            // 
            // MainMenuItemInfoexpenses
            // 
            this.MainMenuItemInfoexpenses.Name = "MainMenuItemInfoexpenses";
            this.MainMenuItemInfoexpenses.Size = new System.Drawing.Size(205, 22);
            this.MainMenuItemInfoexpenses.Text = "Затраты на содержание";
            // 
            // MainMenuItemTypeexpenses
            // 
            this.MainMenuItemTypeexpenses.Name = "MainMenuItemTypeexpenses";
            this.MainMenuItemTypeexpenses.Size = new System.Drawing.Size(205, 22);
            this.MainMenuItemTypeexpenses.Text = "Типы затрат";
            // 
            // MainMenuItemReport
            // 
            this.MainMenuItemReport.Name = "MainMenuItemReport";
            this.MainMenuItemReport.Size = new System.Drawing.Size(60, 20);
            this.MainMenuItemReport.Text = "Отчеты";
            // 
            // MainMenuItemInfoVisitors
            // 
            this.MainMenuItemInfoVisitors.Name = "MainMenuItemInfoVisitors";
            this.MainMenuItemInfoVisitors.Size = new System.Drawing.Size(211, 22);
            this.MainMenuItemInfoVisitors.Text = "Информация о клиентах";
            this.MainMenuItemInfoVisitors.Click += new System.EventHandler(this.MainMenuItemInfoVisitors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemInfoAnimals;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemVisitors;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemСontract;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemAnimals;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemClassifications;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemInfoexpenses;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemTypeexpenses;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemInfoVisitors;
    }
}

