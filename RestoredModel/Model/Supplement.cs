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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SID { get; set; }

        [Column("SName", TypeName = "text")]
        public string SName { get; set; }

        [Column(TypeName = "text")]
        public string Uses { get; set; }

        [Column(TypeName = "text")]
        public string Ingredient { get; set; }
        
        [Column(TypeName = "text")]
        public string Directions { get; set; }
        
        [Column(TypeName = "text")]
        public string Warnings { get; set; }

        [Column(TypeName = "text")]
        public string OtherInfo { get; set; }
        
        [Column(TypeName = "text")]
        public string InactiveIngredient { get; set; }

        [Column("ManuID")]
        public int? Manufacturer_ManuID { get; set; }
        
        [Column(TypeName = "text")]
        public string SLink { get; set; }

        [Column("CatID")]
        public int? Category_CatID { get; set; }

        [Column("price")]
        public int price { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplementBatch> SupplementBatches { get; set; }
    }
}
