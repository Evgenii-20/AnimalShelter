using AnimalSheletr.FormsAddEdit;
using System;
using System.Windows.Forms;

namespace AnimalSheletr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainMenuItemAnimals_Click(object sender, EventArgs e)
        {
            FormAnimalList formAnimalList = new FormAnimalList();
            formAnimalList.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainMenuItemInfoVisitors_Click(object sender, EventArgs e)
        {

            FormVisitorsList formVisitorsList = new FormVisitorsList();
            formVisitorsList.Show();
        }
    }
    
}

