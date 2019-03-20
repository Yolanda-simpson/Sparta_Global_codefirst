namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RentAVan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentAVan()
        {
            Vans = new HashSet<Van>();
        }

        public int RentAVanID { get; set; }

        public int vanID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string duation { get; set; }

        public DateTime HireDate { get; set; }

        public string EmailAddress { get; set; }

        public string phoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Van> Vans { get; set; }
    }
}
