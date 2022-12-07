namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplement()
        {
            SupplementBatches = new HashSet<SupplementBatch>();
        }

        [Key]
        public int SID { get; set; }

        public string SName { get; set; }

        public string Category { get; set; }

        public string Uses { get; set; }

        public string Ingredient { get; set; }

        public string Directions { get; set; }

        public string Warnings { get; set; }

        public string OtherInfo { get; set; }

        public string InactiveIngredient { get; set; }

        public int? Manufacturer_ManuID { get; set; }

        public string SLink { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplementBatch> SupplementBatches { get; set; }
    }
}
