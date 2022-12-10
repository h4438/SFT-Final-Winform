namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Supplement")]
    public partial class Supplement
    {
        [Key]
        public int SID { get; set; }

        [Column(TypeName = "text")]
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

        public int? ManuID { get; set; }

        [Column(TypeName = "text")]
        public string SLink { get; set; }

        public int? CatID { get; set; }

        public int? price { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Category Category { get; set; }
    }
}
