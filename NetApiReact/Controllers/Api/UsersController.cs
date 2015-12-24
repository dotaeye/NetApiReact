using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NetApiReact.Data.Service;
using NetApiReact.Models;

namespace NetApiReact.Controllers.Api
{
    public class UsersController : ApiController
    {
        private IUserServices UserServices;

        public UsersController(IUserServices _UserServices)
        {
            this.UserServices = _UserServices;
        }

        public IQueryable<UserDTO> GetUsers()
        {
            var users = UserServices.GetAll().Select(x => new UserDTO()
            {
                Id = x.Id,
                UserName = x.UserName
            });
            return users;
        }
    }
}
