namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailID { get; set; }

        public int? OrderID { get; set; }

        public int? SID { get; set; }

        public int? OrderNumber { get; set; }

        public int? Quantity { get; set; }

        public int? Discount { get; set; }

        public int? Total { get; set; }

        public DateTime? ShipDate { get; set; }

        public virtual Order Order { get; set; }

        public virtual Supplement Supplement { get; set; }
    }
}
