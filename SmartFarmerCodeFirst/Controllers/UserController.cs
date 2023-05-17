using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFarmerCodeFirst.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/User/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/User/add")]
        public HttpResponseMessage Add(UserDTO user)
        {
            var data = UserService.AddCustomer(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/User/Delete/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/User/Update")]
        [HttpPatch]
        public HttpResponseMessage Update(UserDTO obj)
        {
            var data = UserService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
