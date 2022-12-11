using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RestoredModel.Model
{
    [Table("Supplement")]
    public partial class DBModel : DbContext
    {
        private static string LOCAL = "data source=LAPTOP-8FHKAJNN\\SQLEXPRESS;initial catalog=DrugStore;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public DBModel()
            : base(LOCAL)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<IncomingOrder> IncomingOrders { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<AgentOrder> AgentOrders { get; set; }
        public virtual DbSet<SupplementBatch> SupplementBatches { get; set; }
        public virtual DbSet<Supplement> Supplements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }   
        public virtual DbSet<AgentTransaction> AgentTransactions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .HasMany(e => e.OutgoingOrders)
                .WithOptional(e => e.Agent)
                .HasForeignKey(e => e.Agent_AgentID);

            modelBuilder.Entity<IncomingOrder>()
                .HasMany(e => e.SupplementBatches)
                .WithOptional(e => e.IncomingOrder)
                .HasForeignKey(e => e.incomingOrder_IncomingOrderID);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.IncomingOrders)
                .WithOptional(e => e.Manufacturer)
                .HasForeignKey(e => e.Manufacturer_ManuID);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Supplements)
                .WithOptional(e => e.Manufacturer)
                .HasForeignKey(e => e.ManuID);
        }
    }
}
