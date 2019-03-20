namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Van
    {
        public int vanID { get; set; }

        public string regNumber { get; set; }

        public string vanColour { get; set; }

        public string vanManufacturer { get; set; }

        public string vanSize { get; set; }

        public int numberOfSeats { get; set; }

        public int? RentAVan_RentAVanID { get; set; }

        public virtual RentAVan RentAVan { get; set; }
    }
}
