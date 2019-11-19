using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user.Model
{
    public class House
    {
        public string Id { get; set; }
        public double BedRoomNumber { get; set; }
        public double BathroomNumber { get; set; }
        public string HouseAddress { get; set; }
        public double RentPerWeek { get; set; }
    }
}
