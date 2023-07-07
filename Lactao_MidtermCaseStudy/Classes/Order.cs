using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lactao_MidtermCaseStudy.Classes
{
    public class Order
    {
        //: INotifyPropertyChanged
        //private int _quantity;
        //private decimal _amount;

        public int OrderId { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }
        //public int Quantity 
        //{ 
        //    get { return _quantity; } 
        //    set 
        //    { 
        //        _quantity = value;
        //        OnPropertyChanged("Quantity");
        //    } 
        //}
        public string Unit { get; set; }

        public decimal Amount { get; set; }

        //public decimal Amount 
        //{ 
        //    get { return _amount; } 
        //    set
        //    {
        //        _amount = value;
        //        OnPropertyChanged("Amount");
        //    }
        //}


        //public event PropertyChangedEventHandler? PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
        //    }
        //}
    }
}
