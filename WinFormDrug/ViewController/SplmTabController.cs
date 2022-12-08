using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDrug.ViewController
{
    public class SplmTabController: ITabController<Supplement>
    {
        private int numNewRows = 0;

        public RichTextBox SName { get; set; }
        public RichTextBox SUses { get; set; }
        public RichTextBox SDirections { get; set; } 
        public RichTextBox SCategory { get; set; }  
        public RichTextBox SWarnings { get; set; }
        public RichTextBox SOtherInfo { get; set; }
        public RichTextBox SIngredient { get; set; }    
        public RichTextBox SInactiveIngredient { get; set; }  
        public ComboBox ManuComboBox { get; set; } 

        public Supplement createObject() 
        {
            Supplement supplement = new Supplement();
            supplement.SName = SName.Text.Trim();
            supplement.Uses = SUses.Text.Trim();
            supplement.Directions = SDirections.Text.Trim();
            supplement.Category = SCategory.Text.Trim();
            supplement.Warnings = SWarnings.Text.Trim();
            supplement.OtherInfo = SOtherInfo.Text.Trim();
            supplement.Ingredient = SIngredient.Text.Trim();
            supplement.InactiveIngredient = SInactiveIngredient.Text.Trim();
            supplement.Manufacturer = (Manufacturer)ManuComboBox.SelectedValue;
            numNewRows++;
            return supplement;
        }

        public void clearAll() 
        {
            SName.Clear();
            SUses.Clear();
            SDirections.Clear();
            SCategory.Clear();
            SWarnings.Clear();  
            SOtherInfo.Clear(); 
            SIngredient.Clear();
            SInactiveIngredient.Clear();
            SName.Focus();
        }

        public int NumberNewRows()
        {
            return numNewRows;
        }

        public void resetRows()
        {
            numNewRows = 0;
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
