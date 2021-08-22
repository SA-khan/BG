using BG.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Infra.Data.Context
{
    public class BGDataContext : DbContext
    {
        public BGDataContext(DbContextOptions<BGDataContext> opts) : base(opts) { }
        public DbSet<City> City { get; set; }
    }
}
