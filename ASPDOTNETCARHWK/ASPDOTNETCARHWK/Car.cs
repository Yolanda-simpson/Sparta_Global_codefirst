namespace ASPDOTNETCARHWK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        public int CarID { get; set; }

        public string CarManufacturer { get; set; }

        public string carColour { get; set; }

        public int numberOfSeats { get; set; }

        public string carSize { get; set; }

        public string carType { get; set; }

        public int? RentaCar_rentACarID { get; set; }

        public virtual RentaCar RentaCar { get; set; }
    }
}
