using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeatherMVC.Models
{
    [Table("RainObservations")]
    public class RainObservation
    {
        [Key]
        public int ObservationID { get; set; }
        [Display(Name = "Inches of Rain")]
        public int IncchesRain { get; set; }
        [Display(Name = "Weather Station ID")]
        public int WeatherStationID { get; set; }

        public virtual ICollection<WeatherStation> WeatherStations { get; set; }
    }
}