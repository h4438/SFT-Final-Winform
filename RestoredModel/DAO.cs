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
        private CachedObject cachedMemory;
        public DAO()
        {
            dbHelper = new DBModel();
            cachedMemory = new CachedObject();
        }
        // Orders
        public List<IncomingOrder> GetIncomingOrders()
        {
            if (cachedMemory.GetInComingOrders() == null)
            {
                List<IncomingOrder> orders = dbHelper.IncomingOrders.ToList();
                cachedMemory.SetInComingOrders(orders);
            }
            return cachedMemory.GetInComingOrders();
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
            if (reConnect || cachedMemory.CachedSupplements == null || cachedMemory.CachedSupplements.Count == 0) 
            {
                cachedMemory.CachedSupplements = dbHelper.Supplements.ToList();
            
            }
            return cachedMemory.CachedSupplements;
        }

        // Manufacturer
        public Dictionary<string, Manufacturer> getSplmManuComboSrc() => cachedMemory.getManuComboSrc();
        
        public bool saveManufacturer(Manufacturer a)
        {
            dbHelper.Manufacturers.Add(a);
            dbHelper.SaveChanges();
            return true;
        }
        
        public List<Manufacturer> getManufacturers(bool reConnect = false)
        {
            if (reConnect || cachedMemory.CachedManufacturers == null || cachedMemory.CachedManufacturers.Count == 0) 
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
