using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_MVC_WebApi.Models
{
    public class UserClass
    {
        public int id;
        public string firstName;
        public string lastName;
        public int birthYear;
        public bool isLogged;

        public static List<UserClass> usersList = new List<UserClass>();


        public UserClass() { }
        public UserClass(int _id, string _firstName, string _lastName, int _birthYear, bool _isLogged)
        {
            this.id = _id;
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthYear = _birthYear;
            this.isLogged = _isLogged;
        }
    }
}