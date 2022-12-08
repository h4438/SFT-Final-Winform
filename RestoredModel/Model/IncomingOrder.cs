namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IncomingOrder:Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomingOrder()
        {
            SupplementBatches = new HashSet<SupplementBatch>();
        }

        public int IncomingOrderID { get; set; }

        public int NumberOfProducts { get; set; }

        public string DeliverDate { get; set; }

        public string SignedDate { get; set; }

        public string ReceivedDate { get; set; }

        public int? Manufacturer_ManuID { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplementBatch> SupplementBatches { get; set; }
    }
}
