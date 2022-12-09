using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.ViewModel
{
    public class ManufacturerView
    {
        public int ManuID { get; set; }

        public string ManuName { get; set; }

        public string ManuAddress { get; set; }

        public string ManuPhone { get; set; }

        public string ManuEmail { get; set; }

        public string ManuCountry { get; set; }

        public static ManufacturerView createView(Manufacturer manufacturer)
        {
            ManufacturerView view = new ManufacturerView();
            view.ManuID = manufacturer.ManuID;  
            view.ManuName = manufacturer.ManuName;
            view.ManuAddress = manufacturer.ManuAddress;
            view.ManuPhone = manufacturer.ManuPhone;   
            view.ManuEmail = manufacturer.ManuEmail;    
            view.ManuCountry = manufacturer.ManuCountry;
            return view;
        }
    }
}
