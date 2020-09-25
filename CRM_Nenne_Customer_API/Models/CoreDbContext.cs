using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CRM_Nenne_Customer_API.Models
{
    public partial class CoreDbContext : DbContext
    {
        private readonly IOptions<Settings> appSettings;
        public CoreDbContext()
        {
        }
        public CoreDbContext(IOptions<Settings> app)
        {
            appSettings = app;
        }
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(appSettings.Value.DbConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerAddress).IsUnicode(false);

                entity.Property(e => e.CustomerContact).IsUnicode(false);

                entity.Property(e => e.CustomerDescription).IsUnicode(false);

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.Property(e => e.CustomerPhone).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
