using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Problem> Problems { get; set; }

        public AppContext() : base()
        {

        }

        public AppContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Problem>().HasData(new Problem[]
            {
                new Problem() { ProblemId = 1, Question = "12+13="}
            });
        }
    }
}
