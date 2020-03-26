using MainWep.Domains.StudentDomain.Entities;
using MainWep.Domains.StudentDomain.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MainWep.Domains.StudentDomain.Infrastructure.Concrete
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly StudentContext _db;
        public EFStudentRepository()
        {
            _db = new StudentContext();
        }
        public IQueryable<Student> Students
        {
            get { return _db.Students; }
        }
        public bool DeleteStudent(int Id)
        {
            try
            {
                var student = _db.Students.FirstOrDefault(x => x.StudentId == Id);
                _db.Students.Remove(student);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
          
        }

        public Student GetStudentById(int Id)
        {
            return _db.Students.FirstOrDefault(x => x.StudentId == Id);
        }

        public IQueryable<Student> GetStudents()
        {
            return _db.Students;
        }

        public bool insertStudent(Student student)
        {
            try
            {
                _db.Students.AddOrUpdate(student);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}