namespace RestoredModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            OutgoingOrders = new HashSet<AgentOrder>();
        }

        public int AgentID { get; set; }

        public string AgentName { get; set; }

        public string AgentAddress { get; set; }

        public string AgentEmail { get; set; }

        public string AgentPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentOrder> OutgoingOrders { get; set; }
    }
}
