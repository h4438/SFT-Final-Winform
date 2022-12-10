using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public class BatchTabController : ITabController<SupplementBatch>
    {
        private int numNewRows = 0;
        private IncomingOrder inOrder;
        private static string DATE_FORMAT = "yyyy-MM-dd";
        public DateTimePicker OrderDeliverDate { get; set; }
        public DateTimePicker OrderSignedDate { get; set; }
        public ComboBox ManuComboBox { get; set; }
        public TextBox BatchQuantity { get; set; } 
        public TextBox BatchCost { get; set; }  
        public TextBox BatchPrice { get; set; } 
        public DateTimePicker BatchManuDate { get; set; }
        public DateTimePicker BatchExpDate { get; set; }    
        public ComboBox SplmComboBox { get; set; }

        public void clearAll()
        {
            BatchQuantity.Clear();  
        }
        public IncomingOrder getInternalOrder() => this.inOrder;
        public void createInternalOrder() 
        {
            this.inOrder = new IncomingOrder();
            inOrder.DeliverDate = OrderDeliverDate.Value.ToString(DATE_FORMAT);
            inOrder.SignedDate = OrderSignedDate.Value.ToString(DATE_FORMAT);
            inOrder.ReceivedDate = null;
            inOrder.Manufacturer = (Manufacturer)ManuComboBox.SelectedValue;
            this.inOrder.NumberOfProducts = 0;
        }

        public SupplementBatch createObject()
        {
            SupplementBatch batch = new SupplementBatch();
            batch.BatchQuantity = Int32.Parse(BatchQuantity.Text);
            batch.BatchManuDate = BatchManuDate.Value.ToString(DATE_FORMAT);
            batch.BatchExpDate = BatchExpDate.Value.ToString(DATE_FORMAT);
            batch.Supplement = (Supplement)SplmComboBox.SelectedValue;
            batch.IncomingOrder = this.inOrder;
            batch.OutgoingOrder = null;
            numNewRows++;
            this.inOrder.NumberOfProducts++; // important
            return batch;
        }

        public int NumberNewRows()
        {
            return numNewRows;
        }

        public void resetRows()
        {
            numNewRows = 0;
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
    }
}
