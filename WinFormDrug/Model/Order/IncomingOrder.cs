using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model.Order
{
    partial class IncomingOrder
    {
        public int IncomingOrderID { get; set; }

        public int ManuID { get; set; }

        public int NumberOfProducts { get; set; }

        public DateTime DeliverDate { get; set; }   
        public DateTime SignedDate { get; set; }

        public DateTime ReceivedDate { get; set; }

    }
}
