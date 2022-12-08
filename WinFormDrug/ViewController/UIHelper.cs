using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public class UIHelper
    {
        public static void showTmpData<T>(DataGridView dataGridView, List<T> data) 
        {
            dataGridView.DataSource = data;
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
            int endIdx = dataGrid.Rows.Count - 1;
            for (int i = 0; i < newRows; i++)
            {
                DataGridViewRow row = dataGrid.Rows[endIdx];
                endIdx--;
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
    }

}
