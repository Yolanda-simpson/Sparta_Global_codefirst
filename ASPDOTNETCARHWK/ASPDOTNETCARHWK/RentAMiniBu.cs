namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RentAMiniBu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentAMiniBu()
        {
            MiniBus = new HashSet<MiniBu>();
        }

        [Key]
        public int RentAMiniBusID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string emailAddess { get; set; }

        public DateTime hireDate { get; set; }

        public string phoneNumber { get; set; }

        public int MinibusID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniBu> MiniBus { get; set; }
    }
}
