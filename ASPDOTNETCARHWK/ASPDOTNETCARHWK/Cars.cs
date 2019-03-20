namespace ASPDOTNETCARHWK
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cars : DbContext
    {
        public Cars()
            : base("name=Cars")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Car> Cars1 { get; set; }
        public virtual DbSet<MiniBu> MiniBus { get; set; }
        public virtual DbSet<RentaCar> RentaCars { get; set; }
        public virtual DbSet<RentAMiniBu> RentAMiniBus { get; set; }
        public virtual DbSet<RentAVan> RentAVans { get; set; }
        public virtual DbSet<Van> Vans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentaCar>()
                .HasMany(e => e.Cars)
                .WithOptional(e => e.RentaCar)
                .HasForeignKey(e => e.RentaCar_rentACarID);

            modelBuilder.Entity<RentAMiniBu>()
                .HasMany(e => e.MiniBus)
                .WithOptional(e => e.RentAMiniBu)
                .HasForeignKey(e => e.RentAMiniBus_RentAMiniBusID);

            modelBuilder.Entity<RentAVan>()
                .HasMany(e => e.Vans)
                .WithOptional(e => e.RentAVan)
                .HasForeignKey(e => e.RentAVan_RentAVanID);
        }
    }
}
