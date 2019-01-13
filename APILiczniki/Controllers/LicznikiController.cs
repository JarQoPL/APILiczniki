using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APILiczniki.Controllers
{
    public class LicznikiController : ApiController
    {
        public IEnumerable<Liczniki> Get() {
            using (licznikidbEntities entities = new licznikidbEntities())
            {
                return entities.Liczniki.ToList();
            }
        }
    }
}
