using RestoredModel.ViewModel;
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
            GetSupplements();
            getManufacturers();
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
        public List<IncomingOrder> findAnyIncomingOrder(IncomingOrder order)
        {
            List<IncomingOrder> result = dbHelper.IncomingOrders
                .Where(m => m.IncomingOrderID.Equals(order.IncomingOrderID)
                    || m.DeliverDate.Contains(order.DeliverDate)
                    || m.SignedDate.Contains(order.SignedDate))
                .ToList();
            return result;
        }
        public bool ReceiveIncomingOrder(IncomingOrder incomingOrder) 
        {
            cachedMemory.selectedInOrder.ReceivedDate = incomingOrder.ReceivedDate;
            dbHelper.SaveChanges();
            cachedMemory.selectedInOrder = null;
            return true;
        }
        public bool UpdateIncomingOrder(IncomingOrder incomingOrder) 
        {
            cachedMemory.selectedInOrder.setData(incomingOrder);
            dbHelper.SaveChanges();
            cachedMemory.selectedInOrder = null;
            return true;
        }
        public IncomingOrder LoadIncomingOrderByID(int id) 
        {
            IncomingOrder result = dbHelper.IncomingOrders
                .Where(m => m.IncomingOrderID.Equals(id)).FirstOrDefault();
            cachedMemory.selectedInOrder = result;
            return result;
        }
        public List<IncomingOrder> GetIncomingOrders(bool reConnect = false)
        {
            if (reConnect || cachedMemory.CachedIncomingOrders == null)
            {
                cachedMemory.CachedIncomingOrders = dbHelper.IncomingOrders.ToList();
            }
            return cachedMemory.CachedIncomingOrders;
        }
        public List<IncomingOrder> GetExpectingOrders(bool reConnect = false)
        {
            return dbHelper.IncomingOrders.Where(m => m.ReceivedDate == null).ToList();   
        }

        public List<IncomingOrder> GetReceivedOrders(bool reConnect = false)
        {
            return dbHelper.IncomingOrders.Where(m => m.ReceivedDate != null).ToList();
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
        
        public List<Manufacturer> findManufacturers(Manufacturer manufacturer)
        {
            List<Manufacturer> result = dbHelper.Manufacturers.
                Where(m => m.ManuName.Contains(manufacturer.ManuName))
                .Where(m => m.ManuCountry.Contains(manufacturer.ManuCountry))
                .Where(m => m.ManuEmail.Contains(manufacturer.ManuEmail))
                .Where(m => m.ManuPhone.Contains(manufacturer.ManuPhone))
                .Where(m => m.ManuAddress.Contains(manufacturer.ManuAddress))
                .ToList();
            return result;
        }

        // Views
        public List<IncomingOrderView> CreateIncomingOrderViews(List<IncomingOrder> data)
        {
            List<IncomingOrderView> results = new List<IncomingOrderView>();
            foreach (IncomingOrder order in data)
            {
                results.Add(IncomingOrderView.createView(order));
            }
            return results;
        }

        public List<ManufacturerView> CreateIncomingOrderViews(List<Manufacturer> manufacturers) 
        {
            List<ManufacturerView> results = new List<ManufacturerView>();  
            foreach(Manufacturer manufacturer in manufacturers) 
            {
                results.Add(ManufacturerView.createView(manufacturer));
            }
            return results;
        }

        public List<SupplementView> CreateSupplementViews(List<Supplement> supplements) 
        {
            List<SupplementView> results = new List<SupplementView>();
            foreach(Supplement supplement in supplements) 
            {
                results.Add(SupplementView.createView(supplement));
            }
            return results;
        }
    }

}
