namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplementBatch
    {
        [Key]
        public int BatchID { get; set; }

        public int BatchQuantity { get; set; }

        public string BatchExpDate { get; set; }

        public string BatchManuDate { get; set; }

        public int? incomingOrder_IncomingOrderID { get; set; }

        public int? outgoingOrder_OutOrderID { get; set; }


        public virtual IncomingOrder IncomingOrder { get; set; }

        public virtual OutgoingOrder OutgoingOrder { get; set; }

        public virtual Supplement Supplement { get; set; }
    }
}
