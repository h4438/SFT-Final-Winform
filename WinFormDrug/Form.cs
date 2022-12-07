using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDrug.ViewController;

namespace WinFormDrug
{
    public partial class Form : System.Windows.Forms.Form
    {
        private DBModel dbHelper;
        private List<Manufacturer> manufacturers;
        private List<Supplement> supplements;
        private Dictionary<string, Manufacturer> comboSource;
        private Dictionary<string, Supplement> splmSrc;
        private IncomingOrder inOrder;
        private DAO dao;
        private ManuTabController manuTabController;
        private SplmTabController splmTabController;
        public Form()
        {
            InitializeComponent();
            dao = new DAO();    
            // Set Manu Tab
            manuTabController = new ManuTabController();
            manuTabController.ManuNameTxt = textManuName;
            manuTabController.ManuEmailTxt= textManuEmail;
            manuTabController.ManuPhoneTxt= textManuPhone;
            manuTabController.ManuAddressTxt = textManuAdrs;
            manuTabController.ManuCountryTxt = textManuCountry;
            // Set splm Tab
            splmTabController = new SplmTabController();
            splmTabController.SName = richTextSplmName;
            splmTabController.SUses = richTextSplmUses;
            splmTabController.SDirections = richTextSplmDir;
            splmTabController.SCategory = richTextSplmCate;
            splmTabController.SWarnings = richTextSplmWarn;
            splmTabController.SOtherInfo = richTextSplmOther;
            splmTabController.SIngredient = richTextSplmIngredient;
            splmTabController.SInactiveIngredient = richTextSplmInactive;
            splmTabController.ManuComboBox = comboBoxSplmManu;
            // correspond to the number of tabs
            dataGridView1.ReadOnly = true;
            dbHelper= new DBModel();
            manufacturers = new List<Manufacturer>();
            supplements = new List<Supplement>();   
            comboSource= new Dictionary<string, Manufacturer>();
            splmSrc = new Dictionary<string, Supplement>();
            selectAllManufacturer();
        }
        // Batch
        private void createInOrder_Click(object sender, EventArgs e)
        {
            inOrder= new IncomingOrder();   
            inOrder.DeliverDate = dateTimePickerOrderDeliverDate.Value.ToString("yyyy-MM-dd");
            inOrder.SignedDate = dateTimePickerOrderSignedDate.Value.ToString("yyyy-MM-dd");
            inOrder.ReceivedDate = null;
            inOrder.Manufacturer = (Manufacturer)comboBoxOrderManu.SelectedValue;
            inOrder.NumberOfProducts = 0;
            dbHelper.IncomingOrders.Add(inOrder);
            dbHelper.SaveChanges();
            //string a = inOrder.IncomingOrderID+"";
            MessageBox.Show("You can start importing batches!");
        }

        private void addBatch_Click(object sender, EventArgs e) 
        {
            SupplementBatch batch = new SupplementBatch();
            batch.BatchQuantity = Int32.Parse(textBatchQuantity.Text);
            batch.BatchOriginalCost = Double.Parse(textBatchCost.Text);
            batch.BatchInitPrice = Double.Parse(textBatchPrice.Text);
            batch.BatchManuDate = dateTimePickerBatchManu.Value.ToString("yyyy-MM-dd");
            batch.BatchExpDate = dateTimePickerBatchExpDate.Value.ToString("yyyy-MM-dd");
            batch.Supplement = (Supplement)comboBoxBatchSplm.SelectedValue;
            batch.IncomingOrder = this.inOrder;
            batch.OutgoingOrder = null;
            dbHelper.SupplementBatches.Add(batch);
            dbHelper.SaveChanges();
            MessageBox.Show("Batches added");
        }
        private void saveBatch_Click(object sender, EventArgs e) 
        {
            
        }

        private void changeTab_Click(object sender, EventArgs e) 
        {
            string tab = tabControlMain.SelectedTab.Text;
            if (tab == "Supplement" || tab == "Batch") 
            {
                ComboBox comboMain = splmTabController.ManuComboBox;
                comboMain.DataSource = new BindingSource(dao.getSplmManuComboSrc(), null);
                comboMain.DisplayMember = "Key";
                comboMain.ValueMember = "Value";
                //// can improve
                //comboBoxOrderManu.DataSource = new BindingSource(this.comboSource, null);
                //comboBoxOrderManu.DisplayMember = "Key";
                //comboBoxOrderManu.ValueMember = "Value";
            }
            if(tab == "Batch")
            {
                if (supplements.Count == 0) { selectAllSupplement(); }
                foreach(Supplement a in supplements) 
                {
                    if (splmSrc.ContainsKey(a.SName)) { continue; }
                    splmSrc.Add(a.SName, a);
                }
                //comboBoxBatchSplm.DataSource = new BindingSource(this.splmSrc, null);
                //comboBoxBatchSplm.DisplayMember = "Key";
                //comboBoxBatchSplm.ValueMember = "Value";    
            }
            
        }
        // Supplement
        private void saveSupplement_Click(object sender, EventArgs e) 
        {
            Supplement supplement = splmTabController.createObject();
            dbHelper.Supplements.Add(supplement);
            dbHelper.SaveChanges();
            MessageBox.Show("OK");
            splmTabController.clearAll();
        }

        private void showAllSupplement_Click(object sender, EventArgs e)
        {
            selectAllSupplement();
        }

        private void selectAllSupplement() 
        {
            int newRows = splmTabController.NumberNewRows();
            dataGridView1.DataSource = dao.GetSupplements(newRows != 0);
            splmTabController.resetRows();
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);
        }

        // Manufacturer
        private void saveManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer manufacture = manuTabController.createObject();
            dao.saveManufacturer(manufacture);
            MessageBox.Show("Save complete!");
            manuTabController.clearAll();
        }

        private void showAllManu_Click(object sender, EventArgs e) { selectAllManufacturer(); }

        private void selectAllManufacturer()
        {
            int newRows = manuTabController.NumberNewRows();
            dataGridView1.DataSource = dao.getManufacturers(newRows != 0);
            manuTabController.resetRows();
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);      
        }

        
    }
}
