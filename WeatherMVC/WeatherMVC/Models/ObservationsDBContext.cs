using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeatherMVC.Models
{
    public class ObservationsDBContext : DbContext
    {
        public DbSet<RainObservation> RainObservations { get; set; }
        public DbSet<WeatherStation> WeatherStations { get; set; }
    }
}