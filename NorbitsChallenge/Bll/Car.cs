using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace NorbitsChallenge.Bll
{
    public class Car
    {
        [Key]
        public string LicensePlate { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public int? TireCount { get; set; }

        public int? CompanyId { get; set; }

    }
}
