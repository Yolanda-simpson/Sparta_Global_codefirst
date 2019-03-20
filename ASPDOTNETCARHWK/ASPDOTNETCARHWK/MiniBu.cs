namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MiniBu
    {
        [Key]
        public int MinibusID { get; set; }

        public string regNumber { get; set; }

        public string MiniBusColour { get; set; }

        public string miniBusManufacturer { get; set; }

        public int numberOfSeats { get; set; }

        public string miniBusSize { get; set; }

        public int? RentAMiniBus_RentAMiniBusID { get; set; }

        public virtual RentAMiniBu RentAMiniBu { get; set; }
    }
}
