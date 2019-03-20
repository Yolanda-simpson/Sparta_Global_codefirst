namespace ASPDOTNETCARHWK
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentACar : DbContext
    {
        public RentACar()
            : base("name=RentACar")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.RentaCar> RentaCars { get; set; }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.MiniBus> MiniBus { get; set; }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.RentAVan> RentAVans { get; set; }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.RentAMiniBus> RentAMiniBus { get; set; }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.Van> Vans { get; set; }

        public System.Data.Entity.DbSet<ASPDOTNETCARHWK.Car> Cars { get; set; }
    }

    public class RentaCar
    {
        public int rentACarID
        {
            get => default(int);
            set
            {
            }
        }

        public string firstName
        {
            get => default(string);
            set
            {
            }
        }

        public string LastName
        {
            get => default(string);
            set
            {
            }
        }

        public int Age
        {
            get => default(int);
            set
            {
            }
        }

        public System.DateTime hireDate
        {
            get => default(DateTime);
            set
            {
            }
        }

        public int CarID
        {
            get => default(int);
            set
            {
            }
        }

        public string duration
        {
            get => default(string);
            set
            {
            }
        }

        public string emailAddress
        {
            get => default(string);
            set
            {
            }
        }

        public int phoneNumber
        {
            get => default(int);
            set
            {
            }
        }
    }
}
