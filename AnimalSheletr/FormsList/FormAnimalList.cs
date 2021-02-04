using AnimalSheletr.FormsAddEdit;
using System;
using System.Windows.Forms;

namespace AnimalSheletr
{
    public partial class FormAnimalList : Form
    {
        public FormAnimalList()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddAnimal formAddAnimal = new FormAddAnimal();
            

            try
            {
                if (formAddAnimal.ShowDialog() == DialogResult.Cancel) return;
                                
                //Animal animal = new Animal
                //{
                //    //заполнение идентификатора классификации
                //    //Gender = formAddAnimal.CmbBoxGender.SelectedItem.ToString(),
                    
                //}
            }
            catch (Exception ex)
            {

            }
        }
    }
}
