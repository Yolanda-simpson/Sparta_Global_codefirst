using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ASPDOTNETCARHWK
{
    public class Car
    {
        public int CarID
        {
            get => default(int);
            set
            {
            }
        }

        public string CarManufacturer
        {
            get => default(string);
            set
            {
            }
        }

        public string carColour
        {
            get => default(string);
            set
            {
            }
        }

        public int numberOfSeats
        {
            get => default(int);
            set
            {
            }
        }

        public string carSize
        {
            get => default(string);
            set
            {
            }
        }

        public string carType
        {
            get => default(string);
            set
            {
            }
        }

        public RentaCar RentaCar
        {
            get => default(RentaCar);
            set
            {
            }
        }
    }
}