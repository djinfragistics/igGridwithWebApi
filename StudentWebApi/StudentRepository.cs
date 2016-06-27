using StudentWebApi.Interfaces;
using System.Linq;
using StudentWebApi.Entities;
using System.Collections;

namespace StudentWebApi
{
    public class StudentRepository : IStudentRepository
    {
        StudentContext context = new StudentContext();
        public void Add(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Student s = context.Students.Find(Id);
            context.Students.Remove(s);
            context.SaveChanges();
        }

        public void Edit(Student s)
        {
            context.Entry(s).State = System.Data.Entity.EntityState.Modified;
        }

        public Student FindById(int Id)
        {
            Student s = context.Students.Find(Id);
            return s; 
        }

        public IEnumerable GetStudents()
        {
            var students = (from r in context.Students select r).ToList(); ;
            return students;
        }
    }
}