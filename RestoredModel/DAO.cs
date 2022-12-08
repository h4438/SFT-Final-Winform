using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.Model
{
    public class DAO
    {
        private DBModel dbHelper;
        private CachedMem cachedMemory;
        public DAO()
        {
            dbHelper = new DBModel();
            cachedMemory = new CachedMem();
            getManufacturers();
            GetSupplements();
        }
        // Batch 
        public bool saveOrderSupplementBatch(IncomingOrder order,SupplementBatch supplementBatch) 
        {
            dbHelper.IncomingOrders.Add(order);
            dbHelper.SaveChanges(); 
            dbHelper.SupplementBatches.Add(supplementBatch);
            dbHelper.SaveChanges();
            return true;
        }
        public List<SupplementBatch> getSupplementBatches() 
        {
            if(cachedMemory.CachedBatches == null)
            {
                cachedMemory.CachedBatches = dbHelper.SupplementBatches.ToList();
            }
            return cachedMemory.CachedBatches;  
        }
        // Orders
        public List<IncomingOrder> GetIncomingOrders()
        {
            if (cachedMemory.CachedIncomingOrders == null)
            {
                cachedMemory.CachedIncomingOrders = dbHelper.IncomingOrders.ToList();
            }
            return cachedMemory.CachedIncomingOrders;
        }

        public bool saveIncomingOrder(IncomingOrder order) 
        {
            dbHelper.IncomingOrders.Add(order);     
            dbHelper.SaveChanges();
            return true;
        }

        // Supplement
        public bool saveSupplement(Supplement supplement) 
        {
            dbHelper.Supplements.Add(supplement);
            dbHelper.SaveChanges();
            return true;
        }
        public List<Supplement> GetSupplements(bool reConnect = false)
        {
            if (reConnect || cachedMemory.CachedSupplements == null) 
            {
                cachedMemory.CachedSupplements = dbHelper.Supplements.ToList();
            
            }
            return cachedMemory.CachedSupplements;
        }
        public Dictionary<string, Supplement> getSplmComboSrc() => cachedMemory.getSplmComboSrc();
        
        // Manufacturer
        public Dictionary<string, Manufacturer> getManuComboSrc() => cachedMemory.getManuComboSrc();
        
        public bool saveManufacturer(Manufacturer a)
        {
            dbHelper.Manufacturers.Add(a);
            dbHelper.SaveChanges();
            return true;
        }
        
        public List<Manufacturer> getManufacturers(bool reConnect = false)
        {
            if (reConnect || cachedMemory.CachedManufacturers == null) 
            {
                cachedMemory.CachedManufacturers = dbHelper.Manufacturers.ToList();
            }
            return cachedMemory.CachedManufacturers;
        }

        public List<Manufacturer> findManufacturers(string name, string email, string address, string phone)
        {
            List<Manufacturer> query = dbHelper.Manufacturers.
                Where(m => m.ManuName.Contains(name))
                .Where(m => m.ManuEmail.Contains(email))
                .Where(m => m.ManuPhone.Contains(phone))
                .Where(m => m.ManuAddress.Contains(address))
                .ToList();
            return query;
        }
    }

}
