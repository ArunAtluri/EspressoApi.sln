using EspressoApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EspressoApi.Data
{
    public class EspressoDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}