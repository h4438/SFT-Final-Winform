using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public class SplmTabController
    {
        public RichTextBox SName { get; set; }
        public RichTextBox SUses { get; set; }
        public RichTextBox SDirections { get; set; } 
        public RichTextBox SCategory { get; set; }  
        public RichTextBox SWarnings { get; set; }
        public RichTextBox SOtherInfo { get; set; }
        public RichTextBox SIngredient { get; set; }    
        public RichTextBox SInactiveIngredient { get; set; }  
        public ComboBox ManuComboBox { get; set; } 
    }
}
