using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.ViewModel
{
    public class IncomingOrderView
    {
        public int IncomingOrderID { get; set; }

        public int NumberOfProducts { get; set; }

        public string DeliverDate { get; set; }

        public string SignedDate { get; set; }

        public string ReceivedDate { get; set; }

        public string Manufacturer { get; set; }
        public static IncomingOrderView createView(IncomingOrder order)
        {
            IncomingOrderView view = new IncomingOrderView();
            view.IncomingOrderID = order.IncomingOrderID;   
            view.NumberOfProducts = order.NumberOfProducts;
            view.ReceivedDate = order.ReceivedDate; 
            view.DeliverDate = order.DeliverDate;    
            view.SignedDate = order.SignedDate;
            view.Manufacturer = order.Manufacturer.ManuName;
            return view;
        }

    }
}
