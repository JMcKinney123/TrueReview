using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrueReview2.Models;

namespace TrueReview2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<GoodRead> GoodReads { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

       
            base.OnModelCreating(modelBuilder);
        }




        public DbSet<TrueReview2.Models.GoodRead> GoodRead { get; set; }
    }
}
