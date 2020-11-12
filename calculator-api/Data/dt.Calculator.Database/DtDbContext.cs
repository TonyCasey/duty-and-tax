using System;
using System.Linq;
using dt.Calculator.Model.Domain.Calculator;
using dt.Calculator.Model.Domain.Lookup;
using dt.Model.Domain;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace dt.Calculator.Database
{
    public class DtDbContext : DbContext
    {
        private Logger Logger { get; set; }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CanadianProvincialTaxRate> CanadianProvincialTaxRates { get; set; }
        public virtual DbSet<Calculator.Model.Domain.Calculator.Calculator> Calculators { get; set; }
        public virtual DbSet<CalculatorSetting> CalculatorSettings { get; set; }
        

        public DtDbContext(DbContextOptionsBuilder optionsBuilder) : base(optionsBuilder.Options)
        {
        }

        /// <summary>
        /// SaveChanges with AddUserAndTimestamp extension
        /// Fills CreationTime, CreationUser, LastUpdateTime, LastUpdateUser fields
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            AddUserAndTimestamp();
            try
            {
                return base.SaveChanges();
            }
            catch (Exception e)
            {
                Logger = LogManager.GetCurrentClassLogger();
                Logger.Error(e.Message);
                Logger.Error(e.InnerException);
                throw e;
            }
        }

        /// <summary>
        /// Fills CreationTime, CreationUser, LastUpdateTime, LastUpdateUser fields of the entity that is BaseEntity
        /// </summary>
        private void AddUserAndTimestamp()
        {
            var entities = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Modified || e.State == EntityState.Added));

            var currentUsername = "DT.Calculator";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreationTime = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).CreationUser = currentUsername;
                }
                else
                {
                    ((BaseEntity)entity.Entity).LastUpdateTime = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).LastUpdateUser = currentUsername;
                }
            }
        }
        

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Country>()
                .HasIndex(x => x.Iso)
                .IsUnique();

            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            SeedData.Seed(modelbuilder);

            base.OnModelCreating(modelbuilder);
        }
    }
}
