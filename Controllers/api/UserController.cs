using College_MVC_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_MVC_WebApi.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IHttpActionResult Get()
        {
            UserClass.usersList.Add(new UserClass(1, "a", "a", 1998, true));
            UserClass.usersList.Add(new UserClass(2, "b", "b", 1992, false));
            UserClass.usersList.Add(new UserClass(3, "c", "c", 2002, true));

            return Ok(UserClass.usersList);
        }




        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(UserClass.usersList.Find(userItem => userItem.id == id));
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // POST: api/User
        public IHttpActionResult Post([FromBody] UserClass value)
        {
            try
            {
                UserClass.usersList.Add(new UserClass(value.id, value.firstName, value.lastName, value.birthYear, value.isLogged));
                return Ok(UserClass.usersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }




        // PUT: api/User/5
        public IHttpActionResult Put(int id, [FromBody] UserClass value)
        {
            try
            {
                UserClass userEdit = UserClass.usersList.Find(userItem => userItem.id == id);

                UserClass.usersList[UserClass.usersList.IndexOf(userEdit)].firstName = value.firstName;
                UserClass.usersList[UserClass.usersList.IndexOf(userEdit)].lastName = value.lastName;
                UserClass.usersList[UserClass.usersList.IndexOf(userEdit)].birthYear = value.birthYear;
                UserClass.usersList[UserClass.usersList.IndexOf(userEdit)].isLogged = value.isLogged;

                return Ok(UserClass.usersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }




        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                UserClass.usersList.Remove(UserClass.usersList.Find(userItem => userItem.id == id));

                return Ok(UserClass.usersList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
