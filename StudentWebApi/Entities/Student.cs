using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebApi.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public string SchoolName { get; set; }

    }
}