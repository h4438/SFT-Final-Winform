using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormDrug.Model.Order;

namespace WinFormDrug.Model
{
    public class DbHelper: DbContext
    {
        private static string MY_DB = "Data Source=LAPTOP-8FHKAJNN\\SQLEXPRESS;Initial Catalog=DrugStore;Integrated Security=True";

        public DbHelper(): base(MY_DB)
        {
            Database.SetInitializer<DbHelper>(new CreateDatabaseIfNotExists<DbHelper>());
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Supplement> Supplements { get; set; }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<OutgoingOrder> OutgoingOrders { get; set; }
    }
}
