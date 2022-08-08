using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorbitsChallenge.Bll;

namespace NorbitsChallenge.Data
{
    public class NorbitsChallengeContext : DbContext
    {
        public NorbitsChallengeContext (DbContextOptions<NorbitsChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<NorbitsChallenge.Bll.Setting> Setting { get; set; } = default!;

        public DbSet<NorbitsChallenge.Bll.Car> Car { get; set; }
    }
}
