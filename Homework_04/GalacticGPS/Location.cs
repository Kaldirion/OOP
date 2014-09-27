using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    enum Planet { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune };

    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public double Latitude  { get; set; }
        public double Longitude  { get; set; }
        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet): this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",this.Latitude,this.Longitude,this.Planet);
        }

    }

    

}
