using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace worksop_03
{
   


    public class Etel : INotifyPropertyChanged
    {

        private string name;
        private int price;
        private string foodType;
       



        public string FoodType
        {
            get { return foodType; }
            set { foodType = value; OnPropertyChanged(); }
        }
        public int Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

