using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorbitsChallenge.Bll;

namespace NorbitsChallenge.Models
{
    public class CarsModel
    {
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int? TireCount { get; set; }
        public string Model { get; set; }
    }

}