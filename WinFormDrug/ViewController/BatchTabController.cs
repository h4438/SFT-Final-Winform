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

        public DateTimePicker OrderDeliverDate { get; set; }
        public DateTimePicker OrderSignedDate { get; set; }
        public ComboBox ManuComboBox { get; set; }
        public void clearAll()
        {
            throw new NotImplementedException();
        }

        public void createInternalOrder() 
        {
            this.inOrder = new IncomingOrder();
            inOrder.DeliverDate = OrderDeliverDate.Value.ToString("yyyy-MM-dd");
            inOrder.SignedDate = OrderSignedDate.Value.ToString("yyyy-MM-dd");
            inOrder.ReceivedDate = null;
            inOrder.Manufacturer = (Manufacturer)ManuComboBox.SelectedValue;
            inOrder.NumberOfProducts = 0;
        }

        public SupplementBatch createObject()
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

        public void fillDataToComboBox(Dictionary<string, Manufacturer> comboSrc)
        {
            ComboBox comboMain = this.ManuComboBox;
            comboMain.DataSource = new BindingSource(comboSrc, null);
            comboMain.DisplayMember = "Key";
            comboMain.ValueMember = "Value";
        }
    }
}
