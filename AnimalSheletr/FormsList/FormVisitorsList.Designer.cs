
namespace AnimalSheletr
{
    partial class FormVisitorsList
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
            System.Windows.Forms.DataGridView DataGridClassesVisitors;
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PnlDelete = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlEdit = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblTitleVisitors = new System.Windows.Forms.Label();
            DataGridClassesVisitors = new System.Windows.Forms.DataGridView();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(DataGridClassesVisitors)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.PnlDelete.SuspendLayout();
            this.PnlEdit.SuspendLayout();
            this.PnlAdd.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(DataGridClassesVisitors);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(0, 50);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.PnlGrid.Size = new System.Drawing.Size(584, 361);
            this.PnlGrid.TabIndex = 61;
            // 
            // DataGridClassesVisitors
            // 
            DataGridClassesVisitors.BackgroundColor = System.Drawing.Color.White;
            DataGridClassesVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridClassesVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            DataGridClassesVisitors.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            DataGridClassesVisitors.Location = new System.Drawing.Point(10, 10);
            DataGridClassesVisitors.Name = "DataGridClassesVisitors";
            DataGridClassesVisitors.Size = new System.Drawing.Size(564, 341);
            DataGridClassesVisitors.StandardTab = true;
            DataGridClassesVisitors.TabIndex = 0;
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.PnlDelete);
            this.PnlBottom.Controls.Add(this.PnlEdit);
            this.PnlBottom.Controls.Add(this.PnlAdd);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 411);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(584, 50);
            this.PnlBottom.TabIndex = 60;
            // 
            // PnlDelete
            // 
            this.PnlDelete.Controls.Add(this.BtnDelete);
            this.PnlDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlDelete.Location = new System.Drawing.Point(400, 0);
            this.PnlDelete.Name = "PnlDelete";
            this.PnlDelete.Padding = new System.Windows.Forms.Padding(5);
            this.PnlDelete.Size = new System.Drawing.Size(200, 50);
            this.PnlDelete.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(5, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(190, 40);
            this.BtnDelete.TabIndex = 38;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // PnlEdit
            // 
            this.PnlEdit.Controls.Add(this.BtnCancel);
            this.PnlEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlEdit.Location = new System.Drawing.Point(200, 0);
            this.PnlEdit.Name = "PnlEdit";
            this.PnlEdit.Padding = new System.Windows.Forms.Padding(5);
            this.PnlEdit.Size = new System.Drawing.Size(200, 50);
            this.PnlEdit.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(5, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(190, 40);
            this.BtnCancel.TabIndex = 38;
            this.BtnCancel.Text = "Изменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PnlAdd
            // 
            this.PnlAdd.Controls.Add(this.BtnAdd);
            this.PnlAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlAdd.Location = new System.Drawing.Point(0, 0);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Padding = new System.Windows.Forms.Padding(5);
            this.PnlAdd.Size = new System.Drawing.Size(200, 50);
            this.PnlAdd.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(5, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(190, 40);
            this.BtnAdd.TabIndex = 36;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.LblTitleVisitors);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(584, 50);
            this.PnlTop.TabIndex = 59;
            // 
            // LblTitleVisitors
            // 
            this.LblTitleVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitleVisitors.Location = new System.Drawing.Point(0, 0);
            this.LblTitleVisitors.Name = "LblTitleVisitors";
            this.LblTitleVisitors.Size = new System.Drawing.Size(584, 50);
            this.LblTitleVisitors.TabIndex = 38;
            this.LblTitleVisitors.Text = "Информация о посетителях";
            this.LblTitleVisitors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormVisitorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormVisitorsList";
            this.Text = "FormVisitorsList";
            this.Load += new System.EventHandler(this.FormVisitorsList_Load);
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(DataGridClassesVisitors)).EndInit();
            this.PnlBottom.ResumeLayout(false);
            this.PnlDelete.ResumeLayout(false);
            this.PnlEdit.ResumeLayout(false);
            this.PnlAdd.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlDelete;
        protected internal System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel PnlEdit;
        protected internal System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnlAdd;
        protected internal System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnlTop;
        protected internal System.Windows.Forms.Label LblTitleVisitors;
    }
}