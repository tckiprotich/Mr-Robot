using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mr_Robot.Models;

namespace Mr_Robot.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //Seasons table
        public DbSet<SeasonModel> Seasons { get; set; }
        //Episodes table
        public DbSet<EpisodesModel> Episodes { get; set; }
    }
}