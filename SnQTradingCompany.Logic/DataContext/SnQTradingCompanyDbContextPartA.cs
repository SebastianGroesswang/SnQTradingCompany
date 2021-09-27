//@GeneratedCode
namespace SnQTradingCompany.Logic.DataContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    partial class SnQTradingCompanyDbContext
    {
        protected DbSet<Entities.Persistence.ItemMaster.Costumer> CostumerSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.ItemMaster.Product> ProductSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.App.Condition> ConditionSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.App.Order> OrderSet
        {
            get;
            set;
        }
        partial void GetDbSet<I, E>(ref DbSet<E> dbSet) where E : class
        {
            if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
            {
                dbSet = CostumerSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                dbSet = ProductSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
            {
                dbSet = ConditionSet as DbSet<E>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
            {
                dbSet = OrderSet as DbSet<E>;
            }
        }
        static partial void DoModelCreating(ModelBuilder modelBuilder)
        {
            var costumerBuilder = modelBuilder.Entity<Entities.Persistence.ItemMaster.Costumer>();
            costumerBuilder.ToTable("Costumer", "ItemMaster").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.ItemMaster.Costumer>().Property(p => p.RowVersion).IsRowVersion();
            costumerBuilder.Property(p => p.Number).IsRequired().HasMaxLength(8);
            costumerBuilder.Property(p => p.Name).IsRequired().HasMaxLength(256);
            ConfigureEntityType(costumerBuilder);
            var productBuilder = modelBuilder.Entity<Entities.Persistence.ItemMaster.Product>();
            productBuilder.ToTable("Product", "ItemMaster").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.ItemMaster.Product>().Property(p => p.RowVersion).IsRowVersion();
            productBuilder.Property(p => p.Name).IsRequired().HasMaxLength(256);
            productBuilder.HasIndex(c => c.Number).IsUnique();
            productBuilder.Property(p => p.Number).IsRequired().HasMaxLength(256);
            productBuilder.Property(p => p.Price).IsRequired();
            ConfigureEntityType(productBuilder);
            var conditionBuilder = modelBuilder.Entity<Entities.Persistence.App.Condition>();
            conditionBuilder.ToTable("Condition", "App").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.App.Condition>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(conditionBuilder);
            var orderBuilder = modelBuilder.Entity<Entities.Persistence.App.Order>();
            orderBuilder.ToTable("Order", "App").HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.App.Order>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(orderBuilder);
        }
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.ItemMaster.Costumer> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.ItemMaster.Product> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Condition> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Order> entityTypeBuilder);
    }
}
