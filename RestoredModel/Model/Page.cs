namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PageID { get; set; }

        [Column(TypeName = "text")]
        public string PageName { get; set; }

        [Column(TypeName = "text")]
        public string Contents { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        public bool? Published { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string MetaDesc { get; set; }

        [StringLength(250)]
        public string MetaKey { get; set; }

        [StringLength(250)]
        public string Alias { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? Ordering { get; set; }
    }
}
