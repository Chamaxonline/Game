
using CM.Repository.Abstract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CM.Business.UserManager
{
    public class UserManager :IUserManager
    {
        private readonly IUserManagerRepo _userManagerRepo;
        public UserManager(IUserManagerRepo userManagerRepo)
        {
            _userManagerRepo = userManagerRepo;
        }
        public Task AddUser(User user)
        {
           return _userManagerRepo.AddUser(user);
        }
        //public Task GetUser<User>(int Id)
        //{
        //    User user = _userManagerRepo.GetUser(Id)
        //      // user = _userManagerRepo.GetUser(Id);
        //    //Mapper.Initialize(config =>
        //    //{
        //    //    config.CreateMap<RoleDetailDM, RoleDetailVM>();
        //    //});
        //    //List<RoleDetailVM> userRoleTypesVM = Mapper.Map<List<RoleDetailDM>, List<RoleDetailVM>>(usertypes);
        //    return user;
        //}
        public Task<User> GetUser(int Id)
        {
            //User user = new User();  
            //   user = _userManagerRepo.GetUser(Id);
            //return user;
            return _userManagerRepo.GetUser(Id);
        }

    }
}