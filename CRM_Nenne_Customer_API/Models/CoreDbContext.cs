using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CRM_Nenne_Customer_API.Models
{
    public partial class CoreDbContext : DbContext
    {
        //private readonly IOptions<Settings> appSettings;
        public CoreDbContext()
        {
        }
       
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }

       
    }
}
