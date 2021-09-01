using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using diagram.Models;

namespace diagram.Data
{
    public class diagramContext : DbContext
    {
        public diagramContext (DbContextOptions<diagramContext> options)
            : base(options)
        {
        }

        public DbSet<diagram.Models.CateringModel> CateringModel { get; set; }
    }
}
