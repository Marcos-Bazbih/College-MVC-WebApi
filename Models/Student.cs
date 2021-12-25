using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_MVC_WebApi.Models
{
    public class Student
    {
        public int id;
        public string fullName;
        public int studentClass;
        public int birthYear;
        public int[] grades;

        public static List<Student> studentsList = new List<Student>();


        public Student() { }
        public Student(int _id, string _fullName, int _studentClass, int _birthYear, int[] _grades)
        {
            this.id = _id;
            this.fullName = _fullName;
            this.studentClass = _studentClass;
            this.birthYear = _birthYear;
            this.grades = _grades;
        }
    }
}