using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BikeStores.Models
{
    public class BikeStoresContext : DbContext
    {
        public BikeStoresContext (DbContextOptions<BikeStoresContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brand { get; set; }
    }
}
