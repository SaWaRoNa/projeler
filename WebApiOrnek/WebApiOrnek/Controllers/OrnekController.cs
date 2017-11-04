using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiOrnek.Controllers
{
    public class OrnekController : ApiController
    {

        public HttpResponseMessage Get()
        {
            List<Kisiler> TumKisiler = new List<Kisiler>();
            using (dbKisilerEntities dc = new dbKisilerEntities())
            {
                TumKisiler = dc.Kisiler.OrderBy(a => a.Ad).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, TumKisiler);
                return response; 
            }
        }

    }
}
