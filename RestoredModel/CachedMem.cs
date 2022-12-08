using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel
{
    public class CachedMem
    {
        private Dictionary<string, Manufacturer> ManuComboSource;
        private Dictionary<string, Supplement> SplmComboSource;
        public List<Manufacturer> CachedManufacturers { get; set; }
        public List<Supplement> CachedSupplements { get; set; }
        public List<SupplementBatch> CachedBatches { get; set; }
        public List<IncomingOrder> CachedIncomingOrders { get; set; }
        public IncomingOrder selectedInOrder { get; set; }
        public CachedMem()
        {
            this.ManuComboSource = new Dictionary<string, Manufacturer>();
            this.SplmComboSource = new Dictionary<string, Supplement>();
        }

        public Dictionary<string, Manufacturer> getManuComboSrc() 
        {
            foreach (Manufacturer a in CachedManufacturers)
            {
                //Todo: can improve
                if (ManuComboSource.ContainsKey(a.ManuName)) { continue; }
                ManuComboSource.Add(a.ManuName, a);
            }
            return ManuComboSource;
        }

        public Dictionary<string, Supplement> getSplmComboSrc() 
        {
            foreach (Supplement a in CachedSupplements)
            {
                if (SplmComboSource.ContainsKey(a.SName)) { continue; }
                SplmComboSource.Add(a.SName, a);
            }
            return SplmComboSource;
        }


    }
}
