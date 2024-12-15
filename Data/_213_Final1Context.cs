using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _213_Final1.Models;

namespace _213_Final1.Data
{
    public class _213_Final1Context : DbContext
    {
        public _213_Final1Context (DbContextOptions<_213_Final1Context> options)
            : base(options)
        {
        }

        public DbSet<_213_Final1.Models.Dog> Dog { get; set; } = default!;
    }
}
