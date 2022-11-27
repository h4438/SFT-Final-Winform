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
        public Form()
        {
            InitializeComponent();
            newRows= 0; 
            dbHelper= new DbHelper();
            selectAllManufacturer();
        }

        // Manufacturer
        private void saveManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer manufacture = new Manufacturer();
            manufacture.ManuName = textManuName.Text;
            manufacture.ManuAddress = textManuAdrs.Text;
            dbHelper.Manufacturers.Add(manufacture);
            dbHelper.SaveChanges();
            textManuAdrs.Text = "";
            textManuName.Text = "";
            textManuName.Focus();
            this.newRows++;
            MessageBox.Show("Save complete!");
        }

        private void showAllManu_Click(object sender, EventArgs e)
        {
            selectAllManufacturer();
        }

        private void selectAllManufacturer()
        {
            List<Manufacturer> manufacturers = dbHelper.Manufacturers.ToList();
            if (manufacturers.Count == 0)
            {
                return;
            }
            dataGridView1.DataSource = manufacturers;
            UIHelper.fillGrid(dataGridView1);
            UIHelper.colorNewRows(dataGridView1, newRows);
            newRows = 0;
        }

        private void tabSupplement_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public partial class UIHelper
    {
        public static void fillGrid(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.ColumnCount; i++)
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
