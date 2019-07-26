
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CM.Business.UserManager
{
   public interface IUserManager
    {
        Task<User> GetUser(int Id);

        Task AddUser(User user);
    }
}
