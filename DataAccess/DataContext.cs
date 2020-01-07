using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tweet> Tweets { get; set; }
    }
}
