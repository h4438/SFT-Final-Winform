using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public class CheckOrderTabController:ITabController<Order>
    {
        public TextBox OrderID { get; set; }
        public TextBox ProductQuantity { get; set; }    
        public ComboBox SplmComboBox { get; set; }

        public DateTimePicker ReceivedDate { get; set; }    
        public DateTimePicker DeliverDate { get; set; } 
        public DateTimePicker SignedDate { get; set; }
        public ComboBox ManuComboBox { get; set; }

        public void clearAll()
        {
            throw new NotImplementedException();
        }

        public Order createObject()
        {
            throw new NotImplementedException();
        }

        public int NumberNewRows()
        {
            throw new NotImplementedException();
        }

        public void resetRows()
        {
            throw new NotImplementedException();
        }
    }
}
