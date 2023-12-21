using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dumitru_Delia_Lab11.Models;

namespace Dumitru_Delia_Lab11.Data
{
    public class Dumitru_Delia_Lab11Context : DbContext
    {
        public Dumitru_Delia_Lab11Context (DbContextOptions<Dumitru_Delia_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Dumitru_Delia_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
