using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user.Model
{
    public class House
    {
        public long Id { get; set; }
        public string BedRoomNumber { get; set; }
        public string BathroomNumber { get; set; }
        public string HouseAddress { get; set; }
        public string RentPerWeek { get; set; }
        public string Lattitude { get; set; }

        public string Longitude { get; set; }
    }
}
