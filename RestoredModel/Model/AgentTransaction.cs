using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.Model
{
    public class AgentTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } 

        public int Quantity { get; set; }   

        public virtual SupplementBatch SupplementBatch { get; set; }

        public virtual AgentOrder AgentOrder { get; set; }
    }
}
