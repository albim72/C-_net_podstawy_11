using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalForms
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();


        public Form1()
        {
            InitializeComponent();
            InitializeAnimalTypes();
        } 

        private void InitializeAnimalTypes()
        {
            comboBoxAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            int age = (int)numericUpDownAge.Value;
            AnimalType type = (AnimalType)comboBoxAnimalType.SelectedItem;

            Animal animal;

            switch (type)
            {
                case AnimalType.Dog:
                    animal = new Dog(name, age);
                    break;
                case AnimalType.Cat:
                    animal = new Cat(name, age);
                    break;
                case AnimalType.Bird:
                    animal = new Bird(name, age);
                    break;
                default:
                    throw new InvalidOperationException("nieznany typ zwierzaka!");
            }
            animals.Add(animal);
            listBoxAnimals.Items.Add(animal);

        }

        private void buttonMakeSound_Click(object sender, EventArgs e)
        {
            if(listBoxAnimals.SelectedItem is Animal selectedAnimal)
            {
                MessageBox.Show(selectedAnimal.MakeSound(), "Animal Sound");
            }
            else
            {
                MessageBox.Show("Najpierw wybierz zwierzę z listy!", "Error");
            }
        }
    }
}

