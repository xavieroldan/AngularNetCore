using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core_Angular10.Models;

namespace Core_Angular10.Data
{
    public class Core_Angular10Context : DbContext
    {
        public Core_Angular10Context (DbContextOptions<Core_Angular10Context> options)
            : base(options)
        {
        }

        public DbSet<Core_Angular10.Models.BlogPost> BlogPost { get; set; }
    }
}
