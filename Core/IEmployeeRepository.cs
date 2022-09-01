using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public  interface IEmployeeRepository
    {
        Task<Response> AddAsync(Employees employeeDetails);
        Task<Response> Update(Employees nurseDetails);
        Task<Response> Delete(string NurseId);
        Task<Employees> GetEmployee(string NurseId);
        //ResponseList GetEmployeesList(ListParameter listParameter);

    }
}
