using RestoredModel.Model;
using RestoredModel.ViewModel;
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
        
        private DAO dao;
        private ManuTabController manuTabController;
        private SplmTabController splmTabController;
        private BatchTabController batchTabController;
        private CheckOrderTabController checkOrderTabController;
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
            // Set Batch Tab
            batchTabController = new BatchTabController();
            batchTabController.OrderDeliverDate = dateTimePickerOrderDeliverDate;
            batchTabController.OrderSignedDate = dateTimePickerOrderSignedDate;
            batchTabController.ManuComboBox = comboBoxOrderManu;
            batchTabController.BatchQuantity = textBatchQuantity;
            batchTabController.BatchCost = textBatchCost;
            batchTabController.BatchPrice = textBatchPrice;
            batchTabController.BatchManuDate = dateTimePickerBatchManu; 
            batchTabController.BatchExpDate = dateTimePickerBatchExpDate;
            batchTabController.SplmComboBox = comboBoxBatchSplm;
            // Set check order tab
            checkOrderTabController = new CheckOrderTabController();
            checkOrderTabController.OrderID = textOrderID;
            checkOrderTabController.SignedDate= dateTimePickerCheckSigned;
            checkOrderTabController.DeliverDate = dateTimePickerCheckDeliver;
            checkOrderTabController.ReceivedDate = dateTimePickerCheckReceived;
            checkOrderTabController.ProductQuantity = textOrderProductQuantity;
            checkOrderTabController.ManuComboBox = comboBoxCheckManu;
            checkOrderTabController.SplmComboBox = comboBoxCheckSplm;
            // done set up
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            selectAllSupplement();
        }
        private void changeTab_Click(object sender, EventArgs e)
        {
            string tab = tabControlMain.SelectedTab.Text;
            if (tab == "Supplement")
            {
                splmTabController.fillDataToComboBox(dao.getManuComboSrc());
            }
            if (tab == "Batch")
            {
                batchTabController.fillManuDataToComboBox(dao.getManuComboSrc());
                batchTabController.fillSplmDataToComboBox(dao.getSplmComboSrc());
            }
            if(tab == "Check Order") 
            {
                checkOrderTabController.fillManuDataToComboBox(dao.getManuComboSrc());
                checkOrderTabController.fillSplmDataToComboBox(dao.getSplmComboSrc());
            }
        }

        // Batch
        private void createInOrder_Click(object sender, EventArgs e)
        {
            batchTabController.createInternalOrder();
            MessageBox.Show("You can start importing batches!");
        }

        private void addBatch_Click(object sender, EventArgs e) 
        {
            // TODO: add instead of save    
        }
        private void saveBatches_Click(object sender, EventArgs e) 
        {
            SupplementBatch supplementBatch = batchTabController.createObject();
            dao.saveOrderSupplementBatch(batchTabController.getInternalOrder(),supplementBatch);
            MessageBox.Show("Batches added");
            batchTabController.clearAll();
        }
        // Supplement
        private void saveSupplement_Click(object sender, EventArgs e) 
        {
            Supplement supplement = splmTabController.createObject();
            dao.saveSupplement(supplement);
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
            List<Supplement> data = dao.GetSupplements(newRows != 0);
            dataGridView1.DataSource = dao.CreateSupplementViews(data);
            splmTabController.resetRows();
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);
        }

        // Manufacturer
        private void btnManuSearch_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = manuTabController.createObject();
            List<Manufacturer> tmp = dao.findManufacturers(manufacturer);
            UIHelper.showTmpData<Manufacturer>(dataGridView1, tmp);
        }

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
            List<Manufacturer> data = dao.getManufacturers(newRows != 0);
            dataGridView1.DataSource = dao.CreateIncomingOrderViews(data);
            manuTabController.resetRows();
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);      
        }
        // Orders
        private void btnCheckInOrder_Click(object sender, EventArgs e)
        {
            List<IncomingOrder> data = dao.GetIncomingOrders();
            dataGridView1.DataSource = dao.CreateIncomingOrderViews(data);
            UIHelper.fillGrid(dataGridView1);
        }

        private void btnExpectingOrder_Click(object sender, EventArgs e)
        {
            List<IncomingOrder> result = dao.GetExpectingOrders();
            UIHelper.showTmpData<IncomingOrderView>(dataGridView1, dao.CreateIncomingOrderViews(result));
            UIHelper.fillGrid(dataGridView1);
        }

        private void btnReceivedOrder_Click(object sender, EventArgs e)
        {
            List<IncomingOrder> result = dao.GetReceivedOrders();
            UIHelper.showTmpData<IncomingOrderView>(dataGridView1, dao.CreateIncomingOrderViews(result));
            UIHelper.fillGrid(dataGridView1);
        }

        private void btnSearchInOrder_Click(object sender, EventArgs e)
        {
            IncomingOrder order = checkOrderTabController.createIncomingOrder();
            List<IncomingOrder> result = dao.findAnyIncomingOrder(order);
            UIHelper.showTmpData<IncomingOrderView>(dataGridView1, dao.CreateIncomingOrderViews(result));
        }

        private void btnLoadIncoming_Click(object sender, EventArgs e)
        {
            int orderId = checkOrderTabController.convertToInt(checkOrderTabController.OrderID.Text);
            IncomingOrder order = dao.LoadIncomingOrderByID(orderId);
            checkOrderTabController.loadIncomingOrder(order);
            MessageBox.Show("Load order with id = "+ orderId+ " complete");
        }

        private void btnUpdateInOrder_Click(object sender, EventArgs e)
        {
            IncomingOrder order = checkOrderTabController.createIncomingOrder();
            dao.UpdateIncomingOrder(order);
            MessageBox.Show("Update complete!");
            checkOrderTabController.clearAll();
            dao.GetIncomingOrders(true);
        }

        
    }
}
