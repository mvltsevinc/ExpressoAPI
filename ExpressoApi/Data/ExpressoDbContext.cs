using ExpressoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Data
{
    public class ExpressoDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
