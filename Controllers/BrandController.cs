using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVehicle.Models;

namespace WebApiVehicle.Controllers
{
    public class BrandController : ApiController
    {
        private VehicleContext db = new VehicleContext();

        [HttpGet]
        public List<BrandView> ReturnBrand()
        {
            IQueryable<BrandView> brandList =
                db.Brands.Select(b => new BrandView
                {
                    BrandId = b.BrandId,
                    BrandName = b.BrandName,
                    CountryOfOrigin = b.CountryOfOrigin
                }
                );
            return brandList.ToList();
        }

        [HttpGet]
        public BrandView ReturnOneBrand(int id)
        {
            Brand b1 = db.Brands.Find(id);
            if (b1==null)
            {
                return new BrandView();
            }

            BrandView b = new BrandView();
            b.BrandId = b1.BrandId;
            b.BrandName = b1.BrandName;
            b.CountryOfOrigin = b1.CountryOfOrigin;

            return b;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
