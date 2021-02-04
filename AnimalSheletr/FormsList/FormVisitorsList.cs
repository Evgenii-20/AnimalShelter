using AnimalSheletr.FormsAddEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalSheletr
{
    public partial class FormVisitorsList : Form
    {
        public FormVisitorsList()
        {
            InitializeComponent();
        }

        private void PnlGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FormVisitorsList_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddVisitors formAddVisitors = new FormAddVisitors();


            try
            {
                if (formAddVisitors.ShowDialog() == DialogResult.Cancel) return;

                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
