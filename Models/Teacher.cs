using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_MVC_WebApi.Models
{
    public class Teacher
    {
        public int id;
        public string fullName;
        public int wage;
        public int startingYear;
        public string[] subjects;

        public static List<Teacher> teachersList = new List<Teacher>();



        public Teacher() { }
        public Teacher(int _id, string _fullName, int _wage, int _startingYear, string[] _subjects)
        {
            this.id = _id;
            this.fullName = _fullName;
            this.wage = _wage;
            this.startingYear = _startingYear;
            this.subjects = _subjects;
        }
    }
}