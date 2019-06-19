using EspressoApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EspressoApi.Controllers
{
    public class MenusController : ApiController
    {
        EspressoDbContext espressoDbContext = new EspressoDbContext();

        public IHttpActionResult Get()
        {
            var menus = espressoDbContext.Menus.Include("SubMenu");
            return Ok(menus);
        }

        public IHttpActionResult GetMenu(int id)
        {
            var menu = espressoDbContext.Menus.Include("SubMenu").FirstOrDefault(m => m.Id == id);

            if(menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
    }
}
