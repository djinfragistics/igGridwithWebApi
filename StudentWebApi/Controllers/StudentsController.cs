using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using StudentWebApi;
using StudentWebApi.Entities;

namespace StudentWebApi.Controllers
{
    public class StudentsController : ApiController
    {
        // private StudentContext db = new StudentContext();
        private StudentRepository db = new StudentRepository();

        // GET: api/Students
        public List<Student> GetStudents()
        {
            return (List<Student>) db.GetStudents();
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.FindById(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.Id)
            {
                return BadRequest();
            }

            // db.Entry(student).State = EntityState.Modified;
           

            try
            {
                db.Edit(student);
            }
            catch (DbUpdateConcurrencyException)
            {
               
                    throw;
                
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Add(student);

            return CreatedAtRoute("DefaultApi", new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.FindById(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Delete(id);

            return Ok(student);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool StudentExists(int id)
        //{
        //    return db.Students.Count(e => e.Id == id) > 0;
        //}
    }
}