using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model.Order
{
    public class SupplementBatch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BatchID { get; set; }
        public double BatchOriginalCost { get; set; }
        public double BatchInitPrice { get; set; }
        public int BatchQuantity { get; set; }
        public string BatchExpDate { get; set; }
        public string BatchManuDate { get; set; }
        // foreign keys
        public OutgoingOrder outgoingOrder { get; set; }
        public IncomingOrder incomingOrder { get; set; }
        public Supplement supplement { get; set; } 
    }
}
