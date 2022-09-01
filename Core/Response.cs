using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Response
    {
        public string? Message { get; set; }
    }   
    public class Employee
    {

        public Guid? EmloyeeId { get; set; }
        public string? FullName { get; set; }
        public string? Adderess { get; set; }
        public string? CompanyName { get; set; }
        public string? Designation { get; set; }
        public string? MobailNumber { get; set; }
        public string? Email { get; set; }
        public string? Active { get; set; }
        public string? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
        public string? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
    }
   /* public class ListParameter
    {

        public int Start
        {
            get; set;
        }
        public int PageSize
        {
            get; set;
        }
        public string? SortCol
        {
            get; set;
        }
        public string? SearchKey
        {
            get; set;
        }
        public class ResponseList
        {
            public string? Message
            {
                get; set;
            }
            public int TotalRecords
            {
                get; set;
            }
            public List<NursesList>? Data

            {
                get; set;
            }
            public string? Status
            {
                get; set;
            }
        }
        public class NursesList
        {

            public Guid? EmloyeeId { get; set; }
            public string? FullName { get; set; }
            public string? Adderess { get; set; }
            public string? CompanyName { get; set; }
            public string? Designation { get; set; }
            public string? MobailNumber { get; set; }
            public string? Email { get; set; }
            public string? Active
            {
                get; set;
            }
            public string? CreatedOn
            {
                get; set;
            }
            public Guid? CreatedBy
            {
                get; set;
            }
            public string? DeletedOn
            {
                get; set;
            }
            public Guid? DeletedBy
            {
                get; set;
            }
            public string? UpdatedOn
            {
                get; set;
            }
            public Guid? UpdatedBy
            {
                get; set;
            }
        }
    }*/
}
