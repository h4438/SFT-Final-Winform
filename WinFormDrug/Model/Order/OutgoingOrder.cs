using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model.Order
{
    public class OutgoingOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OutOrderID { get; set; }
        public int NumberOfProducts { get; set; }
        public DateTime DeliverDate { get; set; }
        public DateTime AcceptDate { get; set; }

        public string Address { get; set; }

        public Agent Agent { get; set; }
    }
}
