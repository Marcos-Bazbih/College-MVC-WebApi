using College_MVC_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_MVC_WebApi.Controllers.api
{
    public class TeacherController : ApiController
    {
        // GET: api/Teacher
        public IHttpActionResult Get()
        {
            Teacher.teachersList.Add(new Teacher(0, "teacher 1", 15000, 2006, new[] { "English", "Math", "History" }));
            Teacher.teachersList.Add(new Teacher(1, "teacher 2", 12500, 2019, new[] { "Sport", "Physics", "Bible" }));
            Teacher.teachersList.Add(new Teacher(2, "teacher 3", 8000, 2010, new[] { "Literature", "History", "English" }));

            return Ok(Teacher.teachersList);
        }




        // GET: api/Teacher/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(Teacher.teachersList.Find(teacherItem => teacherItem.id == id));
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // POST: api/Teacher
        public IHttpActionResult Post([FromBody] Teacher value)
        {
            try
            {
                Teacher.teachersList.Add(new Teacher(value.id, value.fullName, value.wage, value.startingYear, value.subjects));
                return Ok(Teacher.teachersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // PUT: api/Teacher/5
        public IHttpActionResult Put(int id, [FromBody] Teacher value)
        {
            try
            {
                Teacher teacherEdit = Teacher.teachersList.Find(teacherItem => teacherItem.id == id);

                Teacher.teachersList[Teacher.teachersList.IndexOf(teacherEdit)].fullName = value.fullName;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacherEdit)].wage = value.wage;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacherEdit)].startingYear = value.startingYear;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacherEdit)].subjects = value.subjects;

                return Ok(Teacher.teachersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // DELETE: api/Teacher/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Teacher.teachersList.Remove(Teacher.teachersList.Find(teacherItem => teacherItem.id == id));

                return Ok(Teacher.teachersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
