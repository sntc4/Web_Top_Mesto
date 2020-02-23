using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Top_Mesto_Web.Models;

namespace Top_Mesto_Web.Models
{
    public class Top_Mesto_WebContext : DbContext
    {
        public Top_Mesto_WebContext (DbContextOptions<Top_Mesto_WebContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Top_Mesto_Web.Models.Cafe> Cafe { get; set; }
        public DbSet<Top_Mesto_Web.Models.Lounge> Lounge { get; set; }
        public DbSet<Top_Mesto_Web.Models.Kults> Kults { get; set; }
        public DbSet<Top_Mesto_Web.Models.Music> Music { get; set; }
        public DbSet<Top_Mesto_Web.Models.Park> Park { get; set; }
        public DbSet<Top_Mesto_Web.Models.Sport> Sport { get; set; }
        public DbSet<Top_Mesto_Web.Models.Kino> Kino { get; set; }


    }
}
