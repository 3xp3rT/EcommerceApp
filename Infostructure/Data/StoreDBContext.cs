using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infostructure.Data
{
    public class StoreDBContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StoreDBContext(DbContextOptions<StoreDBContext> options):base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            
        }
       public DbSet<Product> Products{get;set;}
    }



}
