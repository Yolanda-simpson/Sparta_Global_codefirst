using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ASPDOTNETCARHWK
{
    public class Van
    {
        public int vanID
        {
            get => default(int);
            set
            {
            }
        }

        public string regNumber
        {
            get => default(string);
            set
            {
            }
        }

        public string vanColour
        {
            get => default(string);
            set
            {
            }
        }

        public string vanManufacturer
        {
            get => default(string);
            set
            {
            }
        }

        public string vanSize
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

        public RentAVan RentAVan
        {
            get => default(RentAVan);
            set
            {
            }
        }
    }
}