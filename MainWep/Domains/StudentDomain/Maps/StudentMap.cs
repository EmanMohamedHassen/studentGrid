using MainWep.Domains.StudentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MainWep.Domains.StudentDomain.Maps
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            // Primary Key
            this.HasKey(t => t.StudentId);
            this.ToTable("student");
            // Properties
            this.Property(t => t.StudentId).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.collage).HasColumnName("collage");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.IsActive).HasColumnName("IsActive");



             
        }
    }
}