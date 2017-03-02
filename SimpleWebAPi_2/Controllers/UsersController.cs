using SimpleWebAPi_2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPi_2.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        List<User> users = new List<Models.User>
        {
            new User { Id = 1, UserName = "olivier", Website = "www.web.com", Address = "2501 E Memorial Rd", Email = "email@email.com" },
            new User { Id = 2, UserName = "tuyishime", Website = "www.web.com", Address = "2501 E Memorial Rd", Email = "email@email.com" },
            new User { Id = 3, UserName = "middle", Website = "www.web.com", Address = "2501 E Memorial Rd", Email = "email@email.com" },

        };

        // get //put //post //delete
        public HttpResponseMessage GetUsers()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                // Log exception here ...
                ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.InternalServerError, 
                    "Error occured while executing the request! \n The error is " + ex.Message.ToString());
            }
        }

        [Route("{id:int}")]
        public HttpResponseMessage GetUser(int? id)
        {
            try
            {
                var user = users.FirstOrDefault(u => u.Id == id.Value);
                if (user == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "The user with id " + id.Value + "was not found!");
                }
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception ex)
            {
                // Log exception here ...
                ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.InternalServerError, 
                    "Error occured while executing the request! \n The error is " + ex.Message.ToString());
            }
        }
    }
}
