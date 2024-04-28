using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Phar.Models;
using Phar.Models.Domain;

namespace Phar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> applicationuser { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public  DbSet<Cart> Carts { get; set; }

  

        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<order> orders { get; set; }
        public  DbSet<Product> Products { get; set; }
        public DbSet<Accounts> Account { get; set; }

    }
}
