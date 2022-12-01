using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model.Order
{
    public class IncomingOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncomingOrderID { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int NumberOfProducts { get; set; }

        public string DeliverDate { get; set; }   
        public string SignedDate { get; set; }

        public string ReceivedDate { get; set; }

    }
}
