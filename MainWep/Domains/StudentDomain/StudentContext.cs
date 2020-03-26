using MainWep.Domains.StudentDomain.Entities;
using MainWep.Domains.StudentDomain.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MainWep.Domains.StudentDomain
{
    public class StudentContext : DbContext
    {
        static StudentContext()
        {
            Database.SetInitializer<StudentContext>(null);
        }
        public StudentContext()
            : base("Name=MyContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}