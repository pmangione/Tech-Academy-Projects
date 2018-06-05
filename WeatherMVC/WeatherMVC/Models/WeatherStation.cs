using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeatherMVC.Models
{
    [Table("WeatherStations")]
    public class WeatherStation
    {
        [Key]
        public int StationEntryID { set; get; }
        [ForeignKey("RainObservation")]
        public int WeatherStationID { get; set; }
        public string StationName { get; set; }

        public virtual RainObservation RainObservation { get; set; }
    }
}