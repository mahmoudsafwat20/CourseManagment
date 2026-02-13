using invoice.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Invoicee> purchases { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
    }
}
