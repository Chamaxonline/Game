using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SubCategoryId { get; set; }
        public string Address { get; set; }
        public int? DistrictId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
