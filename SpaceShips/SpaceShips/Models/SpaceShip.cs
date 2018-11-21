using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpaceShips.Models
{
    public class SpaceShip
    {
        [key]
        public int SpaceShipID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public float Class { get; set; }
    }

    public class SpaceShipDBContext : DbContext
    {
        public DbSet<SpaceShip> SpaceShips { get; set; }
    }
}