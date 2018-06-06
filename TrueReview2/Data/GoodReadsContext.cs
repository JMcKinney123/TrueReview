using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueReview2.Models;

namespace TrueReview2.Data
{
    public class GoodReadsContext : DbContext
    {



        
       public GoodReadsContext(DbContextOptions<GoodReadsContext> options)
            : base(options)
        {
        }

        public DbSet<GoodRead> GoodReads { get; set; }
    }
    
}
