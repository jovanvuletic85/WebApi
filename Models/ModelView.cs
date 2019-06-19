using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiVehicle.Models
{
    public class ModelView
    {
        public int ModelId { get; set; }

        public int BrandId { get; set; }

        public string ModelName { get; set; }

        public int YearsOfAge { get; set; }

        public decimal Price { get; set; }

        public string Fuel { get; set; }
    }
}