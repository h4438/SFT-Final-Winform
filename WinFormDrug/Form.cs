﻿using RestoredModel.Model;
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
            // correspond to the number of tabs
            dataGridView1.ReadOnly = true;
            
            selectAllManufacturer();
        }
        // Batch
        private void createInOrder_Click(object sender, EventArgs e)
        {
            batchTabController.createInternalOrder();
            MessageBox.Show("You can start importing batches!");
        }

        private void addBatch_Click(object sender, EventArgs e) 
        {
            //SupplementBatch batch = new SupplementBatch();
            //batch.BatchQuantity = Int32.Parse(textBatchQuantity.Text);
            //batch.BatchOriginalCost = Double.Parse(textBatchCost.Text);
            //batch.BatchInitPrice = Double.Parse(textBatchPrice.Text);
            //batch.BatchManuDate = dateTimePickerBatchManu.Value.ToString("yyyy-MM-dd");
            //batch.BatchExpDate = dateTimePickerBatchExpDate.Value.ToString("yyyy-MM-dd");
            //batch.Supplement = (Supplement)comboBoxBatchSplm.SelectedValue;
            //batch.IncomingOrder = this.inOrder;
            //batch.OutgoingOrder = null;
            //dbHelper.SupplementBatches.Add(batch);
            //dbHelper.SaveChanges();
            //MessageBox.Show("Batches added");
        }
        private void saveBatch_Click(object sender, EventArgs e) 
        {
            
        }

        private void changeTab_Click(object sender, EventArgs e) 
        {
            string tab = tabControlMain.SelectedTab.Text;
            if (tab == "Supplement") 
            {
                splmTabController.fillDataToComboBox(dao.getSplmManuComboSrc());
            }
            if(tab == "Batch")
            {
                batchTabController.fillDataToComboBox(dao.getSplmManuComboSrc());
                //if (supplements.Count == 0) { selectAllSupplement(); }
                //foreach(Supplement a in supplements) 
                //{
                //    if (splmSrc.ContainsKey(a.SName)) { continue; }
                //    splmSrc.Add(a.SName, a);
                //}
                //comboBoxBatchSplm.DataSource = new BindingSource(this.splmSrc, null);
                //comboBoxBatchSplm.DisplayMember = "Key";
                //comboBoxBatchSplm.ValueMember = "Value";    
            }
            
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
