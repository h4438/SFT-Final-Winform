using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.Model
{
    public class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhone { get; set; }
    }
}
