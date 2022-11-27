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
        private int newRows;
        private List<Manufacturer> manufacturers;
        Dictionary<string, Manufacturer> comboSource;

        public Form()
        {
            InitializeComponent();
            newRows= 0;
            dbHelper= new DbHelper();
            manufacturers = new List<Manufacturer>();
            comboSource= new Dictionary<string, Manufacturer>();
            selectAllManufacturer();
           
        }
        // Supplement
        private void changeToSupplement_Click(object sender, EventArgs e) 
        {
            string tab = tabControlMain.SelectedTab.Text;
            if (tab == "Supplement") 
            {
                foreach (Manufacturer a in manufacturers) 
                {
                    // can improve
                    if (comboSource.ContainsKey(a.ManuName)) 
                    {
                        continue;
                    }
                    comboSource.Add(a.ManuName, a);
                }
                
                comboBoxSplmManu.DataSource = new BindingSource(this.comboSource, null);
                comboBoxSplmManu.DisplayMember = "Key";
                comboBoxSplmManu.ValueMember = "Value";
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
            MessageBox.Show("OK");
        }

        private void showAllSupplement_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbHelper.Supplements.ToList();
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
            this.newRows++;
            textManuAdrs.Text = "";
            textManuName.Text = "";
            textManuCountry.Text = "";
            textManuEmail.Text = "";
            textManuPhone.Text = "";
            textManuName.Focus();
            MessageBox.Show("Save complete!");
        }

        private void showAllManu_Click(object sender, EventArgs e)
        {
            selectAllManufacturer();
        }

        private void selectAllManufacturer()
        {
            if (manufacturers.Count > 0 && newRows == 0) 
            {
                return;
            }
            manufacturers = dbHelper.Manufacturers.ToList();
            dataGridView1.DataSource = manufacturers;
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);
            newRows = 0;
        }

    }

    public partial class UIHelper
    {
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
