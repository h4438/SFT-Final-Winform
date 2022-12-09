using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RestoredModel.Model
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<IncomingOrder> IncomingOrders { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<OutgoingOrder> OutgoingOrders { get; set; }
        public virtual DbSet<SupplementBatch> SupplementBatches { get; set; }
        public virtual DbSet<Supplement> Supplements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }   
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
                .HasForeignKey(e => e.Manufacturer_ManuID);

            modelBuilder.Entity<OutgoingOrder>()
                .HasMany(e => e.SupplementBatches)
                .WithOptional(e => e.OutgoingOrder)
                .HasForeignKey(e => e.outgoingOrder_OutOrderID);

            modelBuilder.Entity<Supplement>()
                .HasMany(e => e.SupplementBatches)
                .WithOptional(e => e.Supplement)
                .HasForeignKey(e => e.supplement_SID);
        }
    }
}
