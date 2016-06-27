using StudentWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentWebApi
{
    public class StudentContext : DbContext
    {

        public StudentContext(): base("name=StudentAppConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}