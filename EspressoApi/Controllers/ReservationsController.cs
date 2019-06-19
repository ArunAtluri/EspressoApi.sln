using EspressoApi.Data;
using EspressoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EspressoApi.Controllers
{
    public class ReservationsController : ApiController
    {
        EspressoDbContext espressoDbContext = new EspressoDbContext();

        public IHttpActionResult Post(Reservation reservation)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            espressoDbContext.Reservations.Add(reservation);
            espressoDbContext.SaveChanges();

            return StatusCode(HttpStatusCode.Created);

        }
    }
}
