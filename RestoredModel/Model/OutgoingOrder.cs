namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OutgoingOrder:Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OutgoingOrder()
        {
            SupplementBatches = new HashSet<SupplementBatch>();
        }

        [Key]
        public int OutOrderID { get; set; }

        public int NumberOfProducts { get; set; }

        public string DeliverDate { get; set; }

        public string AcceptDate { get; set; }

        public string Address { get; set; }

        public int? Agent_AgentID { get; set; }

        public virtual Agent Agent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplementBatch> SupplementBatches { get; set; }
    }
}
