using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FP18_19_v1.Models;

namespace FP18_19_v1.Data
{
    public class FP18_19_v1Context : DbContext
    {
        public FP18_19_v1Context (DbContextOptions<FP18_19_v1Context> options)
            : base(options)
        {
        }

        public DbSet<FP18_19_v1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
