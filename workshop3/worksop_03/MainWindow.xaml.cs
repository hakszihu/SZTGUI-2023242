using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace worksop_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public ObservableCollection<Etel> etelek;
        ObservableCollection<Etel> rendeles = new ObservableCollection<Etel>();
        int osszeg = 0;

        public MainWindow()
        {
            InitializeComponent();

            etelek = new ObservableCollection<Etel>()
            {
                new Etel(){Name = "Tavaszi zöldségleves", Price = 990, FoodType = "Appetizer"},
                new Etel(){Name = "Dreher", Price = 590, FoodType = "Drink"},
                new Etel(){Name = "Bécsi szelet", Price = 2190, FoodType = "MainCourse"},
                new Etel(){Name = "Limonádé", Price = 2890, FoodType = "Drink"},
                new Etel(){Name = "Milánói sertés borda", Price = 490, FoodType = "MainCourse"},
                new Etel(){Name = "Rákóczi túrós", Price = 790, FoodType = "Dessert"},
                new Etel(){Name = "Gyümölcssaláta", Price = 1190, FoodType = "Appetizer"},
                new Etel(){Name = "Palacsinta", Price = 390, FoodType = "Dessert"}
            };
            lbox.ItemsSource = etelek;
            lb_rendeles.ItemsSource = rendeles;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rendeles.Remove((Etel)lb_rendeles.SelectedItem);
            osszeg = 0;
            foreach (var item in rendeles)
            {
                osszeg += item.Price;
            }
            OsszegChange();
        }
        private void OsszegChange()
        { 
            label_osszeg.Content = osszeg.ToString() + " Ft";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

           rendeles.Add((Etel)lbox.SelectedItem);
            osszeg = 0;
            foreach (var item in rendeles)
            {
               osszeg += item.Price;
            }
            OsszegChange();

        }

        private void cb_filter_Checked(object sender, RoutedEventArgs e)
        {

           List<Etel> tmp = new List<Etel>();
            switch (cb_kategotiavalasztas.Text)
            {

                case "Appetizer" :
                    tmp = etelek.Where(x => x.FoodType == "Appetizer").ToList();
                    break;
                case "Drink":
                    tmp= etelek.Where(x => x.FoodType == "Drink").ToList();
                    break;
                case "MainCourse":
                    tmp= etelek.Where(x => x.FoodType == "MainCourse").ToList();
                    break;
                case "Dessert":
                    tmp= etelek.Where(x => x.FoodType == "Dessert").ToList();
                    break;
        
            }
            lbox.ItemsSource = tmp;
           
        }

        private void cb_filter_Unchecked(object sender, RoutedEventArgs e)
        {
            lbox.ItemsSource = etelek;
        }

        private void lbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FoodEditorWindow foodEditorWindow = new FoodEditorWindow((Etel)lbox.SelectedItem, etelek);
            foodEditorWindow.ShowDialog();
            
        }
    }
}
