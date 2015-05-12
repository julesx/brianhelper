using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace brianhelper
{
    public partial class MainWindow : Window
    {
        public List<Vegetable> Vegetables { get; set; }
        public List<Fruit> Fruits { get; set; }

        public Vegetable SelectedVegetable { get; set; }
        public Fruit SelectedFruit { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Vegetables = new List<Vegetable>();
            Fruits = new List<Fruit>();

            Vegetables.Add(new Vegetable("Carrot"));
            Vegetables.Add(new Vegetable("Brocoli"));

            Fruits.Add(new Fruit("Apple"));
            Fruits.Add(new Fruit("Pear"));

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Get combobox values!
        }
    }

    public class Vegetable
    {
        public string Name { get; set; }

        public Vegetable(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Fruit
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
