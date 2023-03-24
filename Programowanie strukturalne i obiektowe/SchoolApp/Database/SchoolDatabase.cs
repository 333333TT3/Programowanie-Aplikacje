using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using SchoolApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Database
{
    class SchoolDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=SchoolDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<SchoolClass> SchoolClasses { get; set; }

    }
}
