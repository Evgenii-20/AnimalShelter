namespace AnimalSheletr.FormsAddEdit
{
    partial class FormAddAnimal
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
            this.PnlAll = new System.Windows.Forms.Panel();
            this.PictureFoto = new System.Windows.Forms.PictureBox();
            this.LblFoto = new System.Windows.Forms.Label();
            this.TxtBoxNote = new System.Windows.Forms.TextBox();
            this.LblNote = new System.Windows.Forms.Label();
            this.TxtBoxDescr = new System.Windows.Forms.TextBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.CmbBoxGender = new System.Windows.Forms.ComboBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAll
            // 
            this.PnlAll.Controls.Add(this.PictureFoto);
            this.PnlAll.Controls.Add(this.LblFoto);
            this.PnlAll.Controls.Add(this.TxtBoxNote);
            this.PnlAll.Controls.Add(this.LblNote);
            this.PnlAll.Controls.Add(this.TxtBoxDescr);
            this.PnlAll.Controls.Add(this.LblDescr);
            this.PnlAll.Controls.Add(this.CmbBoxGender);
            this.PnlAll.Controls.Add(this.LblGender);
            this.PnlAll.Controls.Add(this.PnlBottom);
            this.PnlAll.Controls.Add(this.TxtBoxName);
            this.PnlAll.Controls.Add(this.LblName);
            this.PnlAll.Controls.Add(this.PnlTop);
            this.PnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAll.Location = new System.Drawing.Point(0, 0);
            this.PnlAll.Name = "PnlAll";
            this.PnlAll.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.PnlAll.Size = new System.Drawing.Size(584, 511);
            this.PnlAll.TabIndex = 1;
            // 
            // PictureFoto
            // 
            this.PictureFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureFoto.Location = new System.Drawing.Point(20, 304);
            this.PictureFoto.Name = "PictureFoto";
            this.PictureFoto.Size = new System.Drawing.Size(544, 130);
            this.PictureFoto.TabIndex = 57;
            this.PictureFoto.TabStop = false;
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblFoto.Location = new System.Drawing.Point(20, 280);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(58, 24);
            this.LblFoto.TabIndex = 56;
            this.LblFoto.Text = "Фото";
            // 
            // TxtBoxNote
            // 
            this.TxtBoxNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxNote.Location = new System.Drawing.Point(20, 251);
            this.TxtBoxNote.Name = "TxtBoxNote";
            this.TxtBoxNote.Size = new System.Drawing.Size(544, 29);
            this.TxtBoxNote.TabIndex = 55;
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNote.Location = new System.Drawing.Point(20, 227);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(127, 24);
            this.LblNote.TabIndex = 54;
            this.LblNote.Text = "Примечание ";
            // 
            // TxtBoxDescr
            // 
            this.TxtBoxDescr.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxDescr.Location = new System.Drawing.Point(20, 198);
            this.TxtBoxDescr.Name = "TxtBoxDescr";
            this.TxtBoxDescr.Size = new System.Drawing.Size(544, 29);
            this.TxtBoxDescr.TabIndex = 53;
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDescr.Location = new System.Drawing.Point(20, 174);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(244, 24);
            this.LblDescr.TabIndex = 52;
            this.LblDescr.Text = "Описание Внешнего вида";
            // 
            // CmbBoxGender
            // 
            this.CmbBoxGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBoxGender.FormattingEnabled = true;
            this.CmbBoxGender.Items.AddRange(new object[] {
            "жен",
            "муж"});
            this.CmbBoxGender.Location = new System.Drawing.Point(20, 142);
            this.CmbBoxGender.Name = "CmbBoxGender";
            this.CmbBoxGender.Size = new System.Drawing.Size(544, 32);
            this.CmbBoxGender.TabIndex = 51;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblGender.Location = new System.Drawing.Point(20, 118);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(44, 24);
            this.LblGender.TabIndex = 43;
            this.LblGender.Text = "Пол";
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.panel2);
            this.PnlBottom.Controls.Add(this.panel1);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(20, 446);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(544, 50);
            this.PnlBottom.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(5, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(190, 40);
            this.BtnCancel.TabIndex = 38;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(5, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(190, 40);
            this.BtnAdd.TabIndex = 36;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxName.Location = new System.Drawing.Point(20, 89);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(544, 29);
            this.TxtBoxName.TabIndex = 41;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblName.Location = new System.Drawing.Point(20, 65);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(72, 24);
            this.LblName.TabIndex = 40;
            this.LblName.Text = "Кличка";
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.LblTitle);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(20, 15);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(544, 50);
            this.PnlTop.TabIndex = 39;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(544, 50);
            this.LblTitle.TabIndex = 38;
            this.LblTitle.Text = "Раздел Животные";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.PnlAll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAddAnimal";
            this.Text = "Информация о животном";
            this.PnlAll.ResumeLayout(false);
            this.PnlAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).EndInit();
            this.PnlBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAll;
        protected internal System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Button BtnAdd;
        protected internal System.Windows.Forms.TextBox TxtBoxName;
        protected internal System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblTitle;
        protected internal System.Windows.Forms.PictureBox PictureFoto;
        protected internal System.Windows.Forms.Label LblFoto;
        protected internal System.Windows.Forms.TextBox TxtBoxNote;
        protected internal System.Windows.Forms.Label LblNote;
        protected internal System.Windows.Forms.TextBox TxtBoxDescr;
        protected internal System.Windows.Forms.Label LblDescr;
        protected internal System.Windows.Forms.ComboBox CmbBoxGender;
    }
}