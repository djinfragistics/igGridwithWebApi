using StudentWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentWebApi
{
    public class StudentInitalizer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student { Id = 1, Name = "Foo Doo", Age = 23, SchoolName = "Modern School" });
            context.Students.Add(new Student { Id = 2, Name = "Koo Foo", Age = 13, SchoolName = "Goverment School" });
            context.SaveChanges();
            base.Seed(context);
        }

    }
}