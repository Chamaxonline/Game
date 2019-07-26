using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CM.Business.Interface;
using CM.Business.UserManager;
using CM.Business.ViewModels;
using Entity.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task Post([FromBody]User user)
        {
            await _userManager.AddUser(user);
        }
        [HttpGet("{id}")]
        public async Task<User> GetUser(int Id)
        {
           return await _userManager.GetUser(Id);
        }
    }
}