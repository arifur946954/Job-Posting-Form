using EfCoreRelation.Entity;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelation.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

      

       // public DbSet<Catagory> catagories { get; set; }
        //public DbSet<Product> products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> customerAddresses { get; set; }
        public DbSet<PresentAddress> presentAddress { get; set; }
        public DbSet<PermanentAddress> permanentAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {//One to many relation customer to address
            modelBuilder.Entity<CustomerAddress>()
                .HasOne(_ => _.customer)
                 .WithMany(_ => _.customerAddresses)
                 .HasForeignKey(_ => _.CustomerId) ;


            //one to many relation customer address to present addrerss
            modelBuilder.Entity<PresentAddress>()
               .HasOne(_ => _.customerAddress)
                .WithMany(_ => _.presentAddresses)
                .HasForeignKey(_ => _.CustomerAddressId);

            //one to mant reltion customeraddress to permanent address
            modelBuilder.Entity<PermanentAddress>()
               .HasOne(_ => _.customerAddress)
                .WithMany(_ => _.permanentAddresses)
                .HasForeignKey(_ => _.CustomerAddressId);

        }



     

    }
}
