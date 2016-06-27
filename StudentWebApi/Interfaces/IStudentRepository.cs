using StudentWebApi.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWebApi.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student s);
        void Edit(Student s);
        void Delete(int Id);
        IEnumerable GetStudents();

        Student FindById(int Id); 

    }
}
