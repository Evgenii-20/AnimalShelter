
namespace AnimalSheletr
{
    partial class FormAnimalList
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
            this.PnlAnimal = new System.Windows.Forms.Panel();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PnlEdit = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DataGridClasses = new System.Windows.Forms.DataGridView();
            this.PnlDelete = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlAnimal.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.PnlEdit.SuspendLayout();
            this.PnlAdd.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClasses)).BeginInit();
            this.PnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAnimal
            // 
            this.PnlAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlAnimal.Controls.Add(this.PnlGrid);
            this.PnlAnimal.Controls.Add(this.PnlBottom);
            this.PnlAnimal.Controls.Add(this.PnlTop);
            this.PnlAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PnlAnimal.Location = new System.Drawing.Point(1, 0);
            this.PnlAnimal.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.PnlAnimal.Name = "PnlAnimal";
            this.PnlAnimal.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.PnlAnimal.Size = new System.Drawing.Size(802, 452);
            this.PnlAnimal.TabIndex = 0;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.LblTitle);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(20, 15);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(760, 50);
            this.PnlTop.TabIndex = 50;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(760, 50);
            this.LblTitle.TabIndex = 38;
            this.LblTitle.Text = "Классификация животных";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.PnlDelete);
            this.PnlBottom.Controls.Add(this.PnlEdit);
            this.PnlBottom.Controls.Add(this.PnlAdd);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(20, 385);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(760, 50);
            this.PnlBottom.TabIndex = 54;
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
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DataGridClasses);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(20, 65);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.PnlGrid.Size = new System.Drawing.Size(760, 320);
            this.PnlGrid.TabIndex = 55;
            // 
            // DataGridClasses
            // 
            this.DataGridClasses.BackgroundColor = System.Drawing.Color.White;
            this.DataGridClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridClasses.Location = new System.Drawing.Point(10, 10);
            this.DataGridClasses.Name = "DataGridClasses";
            this.DataGridClasses.Size = new System.Drawing.Size(740, 300);
            this.DataGridClasses.TabIndex = 0;
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
            // FormAnimalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.PnlAnimal);
            this.Name = "FormAnimalList";
            this.Text = "FormAnimalList";
            this.PnlAnimal.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            this.PnlEdit.ResumeLayout(false);
            this.PnlAdd.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClasses)).EndInit();
            this.PnlDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Panel PnlAnimal;
        private System.Windows.Forms.Panel PnlTop;
        protected internal System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DataGridClasses;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlDelete;
        protected internal System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel PnlEdit;
        protected internal System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnlAdd;
        protected internal System.Windows.Forms.Button BtnAdd;
    }
}