using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel
{
    public class CachedObject
    {
        private List<SupplementBatch> cachedBatches;
        private List<IncomingOrder> cachedIncomingOrders;
        private Dictionary<string, Manufacturer> ManuComboSource;

        public List<Manufacturer> CachedManufacturers { get; set; }

        public CachedObject()
        {
            this.cachedBatches = new List<SupplementBatch>();
        }

        public List<SupplementBatch> CachedBatches{ get { return cachedBatches; } }

        public IncomingOrder CachedIncomingOrder { get; set; }

        public List<IncomingOrder> GetInComingOrders() { return this.cachedIncomingOrders; }
        public void SetInComingOrders(List<IncomingOrder> orders) { this.cachedIncomingOrders = orders; }
    }
}
