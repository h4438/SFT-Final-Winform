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
        public List<Supplement> GetSupplements()
        {
            List<Supplement> supplements = dbHelper.Supplements.ToList();

            return supplements;
        }

        public Dictionary<string, Manufacturer> getManuComboSrc()
        {
            return cachedMemory.getManuComboSrc();
        }

        // Manufacturer
        public bool saveManufacturer(Manufacturer a)
        {
            dbHelper.Manufacturers.Add(a);
            dbHelper.SaveChanges();
            return true;
        }
        
        public List<Manufacturer> getManufacturers(bool reConnect = false)
        {
            if (reConnect || cachedMemory.CachedManufacturers == null || cachedMemory.CachedManufacturers.Count == 0)
                cachedMemory.CachedManufacturers = dbHelper.Manufacturers.ToList();
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
