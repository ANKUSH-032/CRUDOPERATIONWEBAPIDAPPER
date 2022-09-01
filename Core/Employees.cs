using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Employees
    {
        public Guid? EmloyeeId { get; set; }
        public string? FullName { get; set; }
        public string? Adderess { get; set; }
        public string? CompanyName { get; set; }
        public string? Designation { get; set; }
        public string? MobailNumber { get; set; }
        public string? Email { get; set; }
        public bool? Active { get; set; }
       // public string? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
       // public string? DeletedOn{ get; set; }
       // public string? DeletedBy { get; set; }
       // public string? UpdatedOn { get; set; }
        public Guid? UpdatedBy { get; set; }
      
    }
}
