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
        private int newDataRows = 0;
        private static string DATE_FORMAT = "yyyy-MM-dd";

        public TextBox OrderID { get; set; }
        public TextBox ProductQuantity { get; set; }    
        public ComboBox SplmComboBox { get; set; }

        public DateTimePicker ReceivedDate { get; set; }    
        public DateTimePicker DeliverDate { get; set; } 
        public DateTimePicker SignedDate { get; set; }
        public ComboBox ManuComboBox { get; set; }

        public void clearAll()
        {
            this.OrderID.Clear();
            this.ProductQuantity.Clear();   
            this.OrderID.Focus();   
        }

        public Order createObject()
        {
            throw new NotImplementedException();
        }

        public IncomingOrder createIncomingOrder()
        {
            IncomingOrder inOrder = new IncomingOrder();
            inOrder.IncomingOrderID = convertToInt(this.OrderID.Text); 
            inOrder.DeliverDate = this.DeliverDate.Value.ToString(DATE_FORMAT);
            inOrder.SignedDate = this.SignedDate.Value.ToString(DATE_FORMAT);
            inOrder.ReceivedDate = this.ReceivedDate.Value.ToString(DATE_FORMAT);
            inOrder.Manufacturer = (Manufacturer)ManuComboBox.SelectedValue;
            inOrder.NumberOfProducts = convertToInt(this.ProductQuantity.Text);
            return inOrder;
        }

        public int NumberNewRows()
        {
            return this.newDataRows;
        }

        public void resetRows()
        {
            this.newDataRows = 0;
        }

        public void fillManuDataToComboBox(Dictionary<string, Manufacturer> comboSrc)
        {
            ComboBox comboMain = this.ManuComboBox;
            comboMain.DataSource = new BindingSource(comboSrc, null);
            comboMain.DisplayMember = "Key";
            comboMain.ValueMember = "Value";
        }
        public void fillSplmDataToComboBox(Dictionary<string, Supplement> comboSrc)
        {
            ComboBox comboMain = this.SplmComboBox;
            comboMain.DataSource = new BindingSource(comboSrc, null);
            comboMain.DisplayMember = "Key";
            comboMain.ValueMember = "Value";
        }

        public int convertToInt(string value) 
        {
            int num = 0;
            if (int.TryParse(value, out num))
            {
                return num;
            }
            return 0;
        }
    }
}
