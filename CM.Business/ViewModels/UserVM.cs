﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Business.ViewModels
{
   public  class UserVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DistrictId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
