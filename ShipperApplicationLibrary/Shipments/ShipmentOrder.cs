using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Shipments
{
    class ShipmentOrder : Shipper
    {
        public Driver dr;
        private string source;
        private string dest;
        private DateTime time;
        private float weight;

        private string Source { get; set; }
        private string Dest { get; set; }
        private DateTime Time { get; set; }
        private float Weight { get; set; }

    }
}
