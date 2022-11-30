using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDrug.Model;

namespace WinFormDrug
{
    public partial class Form : System.Windows.Forms.Form
    {
        private DbHelper dbHelper;
        private int[] newRows;
        private bool refresh;
        private List<Manufacturer> manufacturers;
        private List<Supplement> supplements;
        private Dictionary<string, Manufacturer> comboSource;
        private Dictionary<string, Supplement> splmSrc;
        public Form()
        {
            InitializeComponent();
            // correspond to the number of tabs
            newRows= new int[] { 0,0,0};
            refresh = true;
            dataGridView1.ReadOnly = true;
            dbHelper= new DbHelper();
            manufacturers = new List<Manufacturer>();
            supplements = new List<Supplement>();   
            comboSource= new Dictionary<string, Manufacturer>();
            splmSrc = new Dictionary<string, Supplement>();
            selectAllManufacturer();
            refresh = false;
        }
        // Batch

        private void addBatch_Click(object sender, EventArgs e) 
        {
            
        }
        private void saveBatch_Click(object sender, EventArgs e) 
        {
            
        }

        // Supplement
        private void changeTab_Click(object sender, EventArgs e) 
        {
            //refresh = true;
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
                comboMain.DataSource = new BindingSource(this.comboSource, null);
                comboMain.DisplayMember = "Key";
                comboMain.ValueMember = "Value";
                // can improve
                comboBoxBatchManu.DataSource = new BindingSource(this.comboSource, null);
                comboBoxBatchManu.DisplayMember = "Key";
                comboBoxBatchManu.ValueMember = "Value";
            }
            if(tab == "Batch")
            {
                if (supplements.Count == 0) { selectAllSupplement(); }
                foreach(Supplement a in supplements) 
                {
                    if (splmSrc.ContainsKey(a.SName)) { continue; }
                    splmSrc.Add(a.SName, a);
                }
                comboBoxBatchSplm.DataSource = new BindingSource(this.splmSrc, null);
                comboBoxBatchSplm.DisplayMember = "Key";
                comboBoxBatchSplm.ValueMember = "Value";    
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
            newRows[tabControlMain.SelectedIndex]++;
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
            UIHelper.colorNewRows(dataGridView1, newRows[tabControlMain.SelectedIndex]);
            newRows[tabControlMain.SelectedIndex] = 0;
        }

        // Manufacturer
        private void saveManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer manufacture = new Manufacturer();
            manufacture.ManuName = textManuName.Text;
            manufacture.ManuAddress = textManuAdrs.Text;
            manufacture.ManuPhone = textManuPhone.Text; 
            manufacture.ManuCountry = textManuCountry.Text;  
            manufacture.ManuEmail = textManuEmail.Text;
            dbHelper.Manufacturers.Add(manufacture);
            dbHelper.SaveChanges();
            // update states
            manufacturers.Add(manufacture);
            refresh = true;
            this.newRows[tabControlMain.SelectedIndex]++;
            MessageBox.Show("Save complete!");
            UIHelper.clearTextBoxes(textManuEmail.Parent);
            textManuName.Focus();
        }

        private void showAllManu_Click(object sender, EventArgs e)
        {
         
            selectAllManufacturer();
        }

        private void selectAllManufacturer()
        {
            if (manufacturers.Count == 0 || !refresh) 
            {
                refresh = false;
                manufacturers = dbHelper.Manufacturers.ToList(); ;
            }
            dataGridView1.DataSource = manufacturers;
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows[tabControlMain.SelectedIndex]);
            newRows[tabControlMain.SelectedIndex] = 0;
        }

        // Event handling

        private void clearAllText_Click(object sender, EventArgs e)
        {
            UIHelper.clearTextBoxes((sender as Button).Parent);
        }

        
    }

    public partial class UIHelper
    {
        public static void clearTextBoxes(Control parent) 
        {
            foreach (var control in parent.Controls)
            {
                if (control is TextBox) {
                    ((TextBox)control).Text = "";
                }
                else if(control is RichTextBox) 
                {
                    ((RichTextBox)control).Text = "";
                }
            }
        }

        public static void fillGrid(DataGridView dataGrid)
        {
            // ignore the id column
            for (int i = 1; i < dataGrid.ColumnCount; i++)
            {
                dataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public static void colorNewRows(DataGridView dataGrid, int newRows)
        {
            int dataLength = dataGrid.Rows.Count;
            for (int i = dataLength - newRows; i < dataLength; i++)
            {
                DataGridViewRow row = dataGrid.Rows[i];
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}
