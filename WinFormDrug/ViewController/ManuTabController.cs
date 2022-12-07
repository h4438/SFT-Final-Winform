using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public class ManuTabController
    {
        private int numNewRows;
        public ManuTabController(){ numNewRows = 0; }   

        public TextBox ManuNameTxt { get; set; }    
        public TextBox ManuEmailTxt { get; set; }   
        public TextBox ManuPhoneTxt { get; set; }
        public TextBox ManuAddressTxt { get; set; }
        public TextBox ManuCountryTxt { get; set;}

        public Manufacturer createManuFromTxtBox()
        {
            Manufacturer manufacture = new Manufacturer();
            manufacture.ManuName = ManuNameTxt.Text.Trim();
            manufacture.ManuAddress = ManuAddressTxt.Text.Trim();
            manufacture.ManuPhone = ManuPhoneTxt.Text.Trim();
            manufacture.ManuCountry = ManuCountryTxt.Text.Trim();
            manufacture.ManuEmail = ManuEmailTxt.Text.Trim();
            this.numNewRows++;
            return manufacture;
        }

        public void clearAll()
        {
            ManuNameTxt.Clear();
            ManuEmailTxt.Clear();
            ManuPhoneTxt.Clear();
            ManuAddressTxt.Clear();
            ManuCountryTxt.Clear();
        }

        public int NumberNewRows() => this.numNewRows;

        public void resetRows() { this.numNewRows = 0; }
    }
}
