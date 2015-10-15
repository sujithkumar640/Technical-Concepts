using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class DetailController : ApiController
    {
        Detail[] details = new Detail[]
        {
            new Detail{id = 1,name="smith", Address="Delhi", salary=50000},
            new Detail{id = 2,name="John",Address="Kanpur",salary= 40000},
        new Detail {id = 3,name="Manya",Address="Lucknow",salary=480000}
        };
        public IEnumerable<Detail> GetAllDetails()
        {
            return details;
        }
        public Detail GetDetailById(int Id)
        {
            var detail = details.FirstOrDefault((I) => I.id == Id);
            if (detail == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return detail;
        }
        public IEnumerable<Detail> GetItemsByAddress(string add)
        {

            return details.Where(
                (I) => string.Equals(I.Address, add,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}
