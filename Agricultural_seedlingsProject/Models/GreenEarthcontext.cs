using System;
using System.Data.Entity;
using System.Linq;

namespace Agricultural_seedlingsProject.Models
{
    public class GreenEarthcontext : DbContext
    {
       
        public GreenEarthcontext()
            : base("name=GreenEarthcontext")
        {
        }
        public virtual DbSet<Contactus> GetContactus { get; set; }
        public virtual DbSet<Forest> Forests { get; set; }
        public virtual DbSet<Fruit> Fruits { get; set; }
        public virtual DbSet<Green> Greens { get; set; }
        public virtual DbSet <Ornamental> Ornamentals { get; set; }
        public virtual DbSet<Sales> GetSales { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volunter> Volunters { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
    }

    
}