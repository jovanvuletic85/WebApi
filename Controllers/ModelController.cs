using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVehicle.Models;

namespace WebApiVehicle.Controllers
{
    public class ModelController : ApiController
    {
        private VehicleContext db = new VehicleContext();

        [HttpGet]
        public List<ModelView> ReturnModel()
        {
            IQueryable<ModelView> modelList =
                db.Models.Select(m => new ModelView
                {
                    ModelId=m.ModelId,
                    BrandId=m.BrandId,
                    ModelName=m.ModelName,
                    YearsOfAge=m.YearsOfAge,
                    Price=m.Price,
                    Fuel=m.Fuel
                }
                );
            return modelList.ToList();
        }

        [HttpGet]
        public List<ModelView> ModelFromBrand (int id)
        {
            IQueryable<ModelView> modelList = db.Models
                .Where(m => m.ModelId == id)
                .Select(m => new ModelView
                {
                    ModelId = m.ModelId,
                    BrandId = m.BrandId,
                    ModelName = m.ModelName,
                    YearsOfAge = m.YearsOfAge,
                    Price = m.Price,
                    Fuel = m.Fuel
                }
                );
            return modelList.ToList();
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
