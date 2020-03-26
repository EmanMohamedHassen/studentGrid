using MainWep.Domains.StudentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainWep.Domains.StudentDomain.Infrastructure.Abstract
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }
        IQueryable<Student> GetStudents();
        Student GetStudentById(int Id);
        bool insertStudent(Student student);
        bool DeleteStudent(int Id);
    }
}