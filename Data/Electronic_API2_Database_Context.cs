using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Electronic_API2.Models;

namespace Electronic_API2.Data
{
    public class Electronic_API2_Database_Context : DbContext
    {
        public Electronic_API2_Database_Context (DbContextOptions<Electronic_API2_Database_Context> options)
            : base(options)
        {
        }

        public DbSet<Electronic_API2.Models.Product> Product { get; set; }
    }
}
