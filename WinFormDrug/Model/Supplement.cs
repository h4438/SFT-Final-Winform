using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model
{
    public class Supplement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SID { get; set; }
        public string SName { get; set; }

        public string SLink { get; set; }   

        public Manufacturer Manufacturer { get; set; }
        public string Category { get; set; }
        public string Uses { get; set; }
        public string Ingredient { get; set; }
        public string Directions { get; set; }
        public string Warnings { get; set; }
        public string OtherInfo { get; set; }
        public string InactiveIngredient { get; set; }

    }
}
