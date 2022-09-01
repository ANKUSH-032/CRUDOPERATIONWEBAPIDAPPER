using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationWebApi.Controllers
{
    [Route("api/employee")]
   
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository, IConfiguration configuration)
        {
            _configuration = configuration;
            _employeeRepository = employeeRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employees employees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Status = false,
                    Message = string.Join(Environment.NewLine, ModelState.Values
                                            .SelectMany(x => x.Errors)
                                            .Select(x => x.ErrorMessage))
                });
            }
            var response = await _employeeRepository.AddAsync(employees);

            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Employees employees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Status = false,
                    Message = string.Join(Environment.NewLine, ModelState.Values
                                            .SelectMany(x => x.Errors)
                                            .Select(x => x.ErrorMessage))
                });
            }
            var response = await _employeeRepository.Update(employees);

            return Ok(response);
        }

        [HttpGet("{emloyeeId}")]
        public async Task<IActionResult> Get([FromRoute] string emloyeeId)
        {
            return Ok(await _employeeRepository.GetEmployee(emloyeeId));
        }
        [HttpDelete("{emloyeeId}")]
        public async Task<ActionResult> DeleteNurse([FromRoute] string emloyeeId)
        {
            return Ok(await _employeeRepository.Delete((emloyeeId)));

        }
        /*[HttpGet,Route("forlist")]
        public IActionResult GetAllEmployees()
        {
            ListParameter listParameter = new();
            listParameter.Start = 0;
            listParameter.PageSize = 10;
            listParameter.SortCol = "";
            listParameter.SearchKey = "";

            ResponseList result = _nurseRepository.GetEmployeesList(listParameter);
            return Ok(result);
        }*/
    }
}
