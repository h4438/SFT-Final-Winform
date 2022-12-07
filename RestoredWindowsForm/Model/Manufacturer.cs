namespace RestoredWindowsForm.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufacturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manufacturer()
        {
            IncomingOrders = new HashSet<IncomingOrder>();
            Supplements = new HashSet<Supplement>();
        }

        [Key]
        public int ManuID { get; set; }

        public string ManuName { get; set; }

        public string ManuAddress { get; set; }

        public string ManuPhone { get; set; }

        public string ManuEmail { get; set; }

        public string ManuCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomingOrder> IncomingOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplement> Supplements { get; set; }
    }
}
