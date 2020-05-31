using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BethanyShop.Auth;

namespace BethanyShop.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
                
        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback>Feedbacks { get; set; }
    }
}
