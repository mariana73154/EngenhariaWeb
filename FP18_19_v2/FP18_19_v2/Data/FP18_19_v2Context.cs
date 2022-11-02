using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FP18_19_v2.Models;

namespace FP18_19_v2.Data
{
    public class FP18_19_v2Context : DbContext
    {
        public FP18_19_v2Context (DbContextOptions<FP18_19_v2Context> options)
            : base(options)
        {
        }

        public DbSet<FP18_19_v2.Models.Imagem> Imagem { get; set; } = default!;
    }
}
