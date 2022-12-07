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
        private bool refresh;
        private bool changeTabRefresh;
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
            refresh = true;
            dataGridView1.ReadOnly = true;
            dbHelper= new DBModel();
            manufacturers = new List<Manufacturer>();
            supplements = new List<Supplement>();   
            comboSource= new Dictionary<string, Manufacturer>();
            splmSrc = new Dictionary<string, Supplement>();
            selectAllManufacturer();
            refresh = false;
            changeTabRefresh = false;
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

        // Supplement
        private void changeTab_Click(object sender, EventArgs e) 
        {
            string tab = tabControlMain.SelectedTab.Text;
            if (tab == "Supplement" || tab == "Batch") 
            {
                foreach (Manufacturer a in manufacturers) 
                {
                    // can improve
                    if (comboSource.ContainsKey(a.ManuName)) { continue; }
                    comboSource.Add(a.ManuName, a);
                }
                ComboBox comboMain = this.comboBoxSplmManu;
                //comboMain.DataSource = new BindingSource(this.comboSource, null);
                //comboMain.DisplayMember = "Key";
                //comboMain.ValueMember = "Value";
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
        private void saveSupplement_Click(object sender, EventArgs e) 
        {
            Supplement supplement = new Supplement();
            supplement.SName = richTextSplmName.Text;
            supplement.Uses = richTextSplmUses.Text;
            supplement.Directions = richTextSplmDir.Text;
            supplement.Category = richTextSplmCate.Text;
            supplement.Warnings = richTextSplmWarn.Text;
            supplement.OtherInfo = richTextSplmOther.Text;
            supplement.Ingredient = richTextSplmIngredient.Text;
            supplement.InactiveIngredient = richTextSplmInactive.Text;
            supplement.Manufacturer = (Manufacturer)comboBoxSplmManu.SelectedValue;
            dbHelper.Supplements.Add(supplement);
            dbHelper.SaveChanges();
            refresh = true;
            MessageBox.Show("OK");
            UIHelper.clearTextBoxes(richTextSplmCate.Parent);
            richTextSplmName.Focus();
        }

        private void showAllSupplement_Click(object sender, EventArgs e)
        {
            selectAllSupplement();
        }

        private void selectAllSupplement() 
        {
            if (supplements.Count == 0 || refresh)
            {
                refresh = false;
                this.supplements = dbHelper.Supplements.ToList();
            }
            dataGridView1.DataSource = supplements;
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, 0);
        }

        // Manufacturer
        private void saveManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer manufacture = manuTabController.createObject();            
            dbHelper.Manufacturers.Add(manufacture);
            dbHelper.SaveChanges();
            // update states
            manufacturers.Add(manufacture);
            MessageBox.Show("Save complete!");
            manuTabController.clearAll();
            textManuName.Focus();
        }

        private void showAllManu_Click(object sender, EventArgs e)
        {
            selectAllManufacturer();
        }

        private void selectAllManufacturer()
        {
            int newRows = manuTabController.NumberNewRows();
            dataGridView1.DataSource = dao.getManufacturers(newRows != 0); 
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);      
        }
        
        // Event handling
        private void clearAllText_Click(object sender, EventArgs e)
        {
            UIHelper.clearTextBoxes((sender as Button).Parent);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTabRefresh = true;
        }
    }
}
