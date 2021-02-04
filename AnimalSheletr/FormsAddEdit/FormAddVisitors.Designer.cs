
namespace AnimalSheletr.FormsAddEdit
{
    partial class FormAddVisitors
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
            this.LblRegistrationVisitors = new System.Windows.Forms.Label();
            this.TxtBoxDescrvisitors = new System.Windows.Forms.TextBox();
            this.LblPassportVisitors = new System.Windows.Forms.Label();
            this.CmbBoxVisitors = new System.Windows.Forms.ComboBox();
            this.LblDateofBirthVisitors = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblNameVisitors = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblTitleVisitors = new System.Windows.Forms.Label();
            this.textBoxVisitors = new System.Windows.Forms.TextBox();
            this.lblPhoneVisitors = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.LblEmailvisitors = new System.Windows.Forms.Label();
            this.textBoxDescrEmail = new System.Windows.Forms.TextBox();
            this.PnlAll.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAll
            // 
            this.PnlAll.Controls.Add(this.textBoxDescrEmail);
            this.PnlAll.Controls.Add(this.LblEmailvisitors);
            this.PnlAll.Controls.Add(this.textBoxDescr);
            this.PnlAll.Controls.Add(this.lblPhoneVisitors);
            this.PnlAll.Controls.Add(this.textBoxVisitors);
            this.PnlAll.Controls.Add(this.LblRegistrationVisitors);
            this.PnlAll.Controls.Add(this.TxtBoxDescrvisitors);
            this.PnlAll.Controls.Add(this.LblPassportVisitors);
            this.PnlAll.Controls.Add(this.CmbBoxVisitors);
            this.PnlAll.Controls.Add(this.LblDateofBirthVisitors);
            this.PnlAll.Controls.Add(this.PnlBottom);
            this.PnlAll.Controls.Add(this.TxtBoxName);
            this.PnlAll.Controls.Add(this.LblNameVisitors);
            this.PnlAll.Controls.Add(this.PnlTop);
            this.PnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAll.Location = new System.Drawing.Point(0, 0);
            this.PnlAll.Name = "PnlAll";
            this.PnlAll.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.PnlAll.Size = new System.Drawing.Size(484, 503);
            this.PnlAll.TabIndex = 2;
            this.PnlAll.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAll_Paint);
            // 
            // LblRegistrationVisitors
            // 
            this.LblRegistrationVisitors.AutoSize = true;
            this.LblRegistrationVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRegistrationVisitors.Location = new System.Drawing.Point(20, 227);
            this.LblRegistrationVisitors.Name = "LblRegistrationVisitors";
            this.LblRegistrationVisitors.Size = new System.Drawing.Size(96, 24);
            this.LblRegistrationVisitors.TabIndex = 54;
            this.LblRegistrationVisitors.Text = "Прописка";
            // 
            // TxtBoxDescrvisitors
            // 
            this.TxtBoxDescrvisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxDescrvisitors.Location = new System.Drawing.Point(20, 198);
            this.TxtBoxDescrvisitors.Name = "TxtBoxDescrvisitors";
            this.TxtBoxDescrvisitors.Size = new System.Drawing.Size(444, 29);
            this.TxtBoxDescrvisitors.TabIndex = 53;
            // 
            // LblPassportVisitors
            // 
            this.LblPassportVisitors.AutoSize = true;
            this.LblPassportVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPassportVisitors.Location = new System.Drawing.Point(20, 174);
            this.LblPassportVisitors.Name = "LblPassportVisitors";
            this.LblPassportVisitors.Size = new System.Drawing.Size(238, 24);
            this.LblPassportVisitors.TabIndex = 52;
            this.LblPassportVisitors.Text = "Серия и номер паспорта ";
            // 
            // CmbBoxVisitors
            // 
            this.CmbBoxVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBoxVisitors.FormattingEnabled = true;
            this.CmbBoxVisitors.Items.AddRange(new object[] {
            "жен",
            "муж"});
            this.CmbBoxVisitors.Location = new System.Drawing.Point(20, 142);
            this.CmbBoxVisitors.Name = "CmbBoxVisitors";
            this.CmbBoxVisitors.Size = new System.Drawing.Size(444, 32);
            this.CmbBoxVisitors.TabIndex = 51;
            // 
            // LblDateofBirthVisitors
            // 
            this.LblDateofBirthVisitors.AutoSize = true;
            this.LblDateofBirthVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDateofBirthVisitors.Location = new System.Drawing.Point(20, 118);
            this.LblDateofBirthVisitors.Name = "LblDateofBirthVisitors";
            this.LblDateofBirthVisitors.Size = new System.Drawing.Size(155, 24);
            this.LblDateofBirthVisitors.TabIndex = 43;
            this.LblDateofBirthVisitors.Text = "Дата рождения ";
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.panel2);
            this.PnlBottom.Controls.Add(this.panel1);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(20, 438);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(444, 50);
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
            this.TxtBoxName.Size = new System.Drawing.Size(444, 29);
            this.TxtBoxName.TabIndex = 41;
            // 
            // LblNameVisitors
            // 
            this.LblNameVisitors.AutoSize = true;
            this.LblNameVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNameVisitors.Location = new System.Drawing.Point(20, 65);
            this.LblNameVisitors.Name = "LblNameVisitors";
            this.LblNameVisitors.Size = new System.Drawing.Size(54, 24);
            this.LblNameVisitors.TabIndex = 40;
            this.LblNameVisitors.Text = "ФИО";
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.LblTitleVisitors);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(20, 15);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(444, 50);
            this.PnlTop.TabIndex = 39;
            // 
            // LblTitleVisitors
            // 
            this.LblTitleVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitleVisitors.Location = new System.Drawing.Point(0, 0);
            this.LblTitleVisitors.Name = "LblTitleVisitors";
            this.LblTitleVisitors.Size = new System.Drawing.Size(444, 50);
            this.LblTitleVisitors.TabIndex = 38;
            this.LblTitleVisitors.Text = "Информация о посетителях";
            this.LblTitleVisitors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxVisitors
            // 
            this.textBoxVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxVisitors.Location = new System.Drawing.Point(20, 251);
            this.textBoxVisitors.Name = "textBoxVisitors";
            this.textBoxVisitors.Size = new System.Drawing.Size(444, 29);
            this.textBoxVisitors.TabIndex = 56;
            // 
            // lblPhoneVisitors
            // 
            this.lblPhoneVisitors.AutoSize = true;
            this.lblPhoneVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneVisitors.Location = new System.Drawing.Point(20, 280);
            this.lblPhoneVisitors.Name = "lblPhoneVisitors";
            this.lblPhoneVisitors.Size = new System.Drawing.Size(90, 24);
            this.lblPhoneVisitors.TabIndex = 57;
            this.lblPhoneVisitors.Text = "Телефон";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDescr.Location = new System.Drawing.Point(20, 304);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(444, 29);
            this.textBoxDescr.TabIndex = 58;
            // 
            // LblEmailvisitors
            // 
            this.LblEmailvisitors.AutoSize = true;
            this.LblEmailvisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblEmailvisitors.Location = new System.Drawing.Point(20, 333);
            this.LblEmailvisitors.Name = "LblEmailvisitors";
            this.LblEmailvisitors.Size = new System.Drawing.Size(184, 24);
            this.LblEmailvisitors.TabIndex = 59;
            this.LblEmailvisitors.Text = "Электронная почта";
            // 
            // textBoxDescrEmail
            // 
            this.textBoxDescrEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDescrEmail.Location = new System.Drawing.Point(20, 357);
            this.textBoxDescrEmail.Name = "textBoxDescrEmail";
            this.textBoxDescrEmail.Size = new System.Drawing.Size(444, 29);
            this.textBoxDescrEmail.TabIndex = 60;
            // 
            // FormAddVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 503);
            this.Controls.Add(this.PnlAll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormAddVisitors";
            this.Text = "FormAddVisitors";
            this.PnlAll.ResumeLayout(false);
            this.PnlAll.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAll;
        protected internal System.Windows.Forms.Label LblRegistrationVisitors;
        protected internal System.Windows.Forms.TextBox TxtBoxDescrvisitors;
        protected internal System.Windows.Forms.Label LblPassportVisitors;
        protected internal System.Windows.Forms.ComboBox CmbBoxVisitors;
        protected internal System.Windows.Forms.Label LblDateofBirthVisitors;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Button BtnAdd;
        protected internal System.Windows.Forms.TextBox TxtBoxName;
        protected internal System.Windows.Forms.Label LblNameVisitors;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblTitleVisitors;
        protected internal System.Windows.Forms.TextBox textBoxDescrEmail;
        protected internal System.Windows.Forms.Label LblEmailvisitors;
        protected internal System.Windows.Forms.TextBox textBoxDescr;
        protected internal System.Windows.Forms.Label lblPhoneVisitors;
        protected internal System.Windows.Forms.TextBox textBoxVisitors;
    }
}