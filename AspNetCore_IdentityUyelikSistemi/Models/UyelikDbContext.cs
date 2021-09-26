using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_IdentityUyelikSistemi.Models
{
    // Identity ile gelen hazır tabloları kullandığımız için Context sınıfımızı IdentityDbContext sınıfından türettik...
    public class UyelikDbContext : IdentityDbContext
    {
        public UyelikDbContext(DbContextOptions<UyelikDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Dealer> Dealer { get; set; }
    }
}