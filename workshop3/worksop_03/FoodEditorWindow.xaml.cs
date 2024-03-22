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
using System.Windows.Shapes;

namespace worksop_03
{
    /// <summary>
    /// Interaction logic for FoodEditorWindow.xaml
    /// </summary>
    public partial class FoodEditorWindow : Window
    {
        private Etel aktualis;
        public FoodEditorWindow(Etel e, ObservableCollection<Etel> etelekv2)
        {
            
            InitializeComponent();
            aktualis = e;

            tb_name.Text = aktualis.Name;
            cb_kategotiavalasztas1.SelectedItem = aktualis.FoodType;
            tb_price.Text = aktualis.Price.ToString();

        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
            
        }

      
    }
}
