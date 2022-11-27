using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model
{
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManuID { get; set; }
        public string ManuName { get; set; }
        public string ManuAddress { get; set;}

        public string ManuPhone { get; set;}    
        public string ManuEmail { get; set;}
        public string ManuCountry { get; set;}
    }
}
