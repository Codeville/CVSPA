using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeVille.SPA.UI.Controllers
{
    [RoutePrefix("api/SecuredItems")]
    public class SecuredItemController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(SecuredItem.CreateDummy());
        }
    }

    public class SecuredItem
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public bool IsMember { get; set; }

        internal static List<SecuredItem> CreateDummy()
        {
            return new List<SecuredItem> { 
                new SecuredItem { id = 1, Name = "Name1", SurName = "Surname1", IsMember = true},
                new SecuredItem { id = 2, Name = "Name2", SurName = "Surname2", IsMember = true},
                new SecuredItem { id = 3, Name = "Name3", SurName = "Surname2", IsMember = true},
                new SecuredItem { id = 4, Name = "Name4", SurName = "Surname4", IsMember = true},
                new SecuredItem { id = 5, Name = "Name5", SurName = "Surname5", IsMember = true},
            };
        }
    }
}
