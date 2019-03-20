namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RentaCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentaCar()
        {
            Cars = new HashSet<Car>();
        }

        public int rentACarID { get; set; }

        public string firstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime hireDate { get; set; }

        public int CarID { get; set; }

        public string duration { get; set; }

        public string emailAddress { get; set; }

        public int phoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
