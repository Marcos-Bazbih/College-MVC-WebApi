using College_MVC_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_MVC_WebApi.Controllers.api
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult Get()
        {
            Student.studentsList.Add(new Student(0, "stu 1", 10, 1998, new[] { 85, 90, 75 }));
            Student.studentsList.Add(new Student(1, "stu 2", 12, 1992, new[] { 60, 100, 70 }));
            Student.studentsList.Add(new Student(2, "stu 3", 8, 1990, new[] { 60, 75, 80 }));

            return Ok(Student.studentsList);
        }




        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(Student.studentsList.Find(studentItem => studentItem.id == id));
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // POST: api/Student
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                Student.studentsList.Add(new Student(value.id, value.fullName, value.studentClass, value.birthYear, value.grades));
                return Ok(Student.studentsList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                Student studentEdit = Student.studentsList.Find(studentItem => studentItem.id == id);

                Student.studentsList[Student.studentsList.IndexOf(studentEdit)].fullName = value.fullName;
                Student.studentsList[Student.studentsList.IndexOf(studentEdit)].studentClass = value.studentClass;
                Student.studentsList[Student.studentsList.IndexOf(studentEdit)].birthYear = value.birthYear;
                Student.studentsList[Student.studentsList.IndexOf(studentEdit)].grades = value.grades;

                return Ok(Student.studentsList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Student.studentsList.Remove(Student.studentsList.Find(studentItem => studentItem.id == id));

                return Ok(Student.studentsList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
