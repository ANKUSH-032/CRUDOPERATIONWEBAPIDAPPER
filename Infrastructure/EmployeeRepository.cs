using Core;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly IConfiguration _configuration;

        private static string con = string.Empty;
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            con = _configuration["ConnectionStrings:EmployeeApp"];
        }

        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(con);
            }
        }


        public async Task<Response> AddAsync(Employees employeeDetails)
        {

            Response response;
            // nurseDetails.CreatedBy = Guid.NewGuid();    
            using (IDbConnection db = Connection)
            {
                response = await db.QueryFirstOrDefaultAsync<Response>("dbo.USPEMPLOYEEADD", new
                {
                    employeeDetails.FullName,
                    employeeDetails.Adderess,
                    employeeDetails.CompanyName,
                    employeeDetails.Designation,
                    employeeDetails.MobailNumber,
                    employeeDetails.Email,
                    employeeDetails.CreatedBy
                }, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }

            return response;
        }
        public async Task<Response> Update(Employees employeeDetails)
        {

            Response response;

            using (IDbConnection db = Connection)
            {
                response = await db.QueryFirstOrDefaultAsync<Response>("dbo.USPEmployeeUpdate", new
                {
                    employeeDetails.EmloyeeId,
                    employeeDetails.FullName,
                    employeeDetails.Adderess,
                    employeeDetails.CompanyName,
                    employeeDetails.Designation,
                    employeeDetails.MobailNumber,
                    employeeDetails.Email,
                    employeeDetails.Active,
                    employeeDetails.UpdatedBy
                }, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }

            return response;
        }
        public async Task<Employees> GetEmployee(string EmloyeeId)
        {
            Employees response;
            using (IDbConnection db = Connection)
            {
                response = await db.QueryFirstOrDefaultAsync<Employees>("dbo.USPEmployeeGet", new
                {
                    EmloyeeId
                }, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
            return response;
        }
        public async Task<Response> Delete(string EmloyeeId)
        {

            Response response;

            using (IDbConnection db = Connection)
            {
                response = await db.QueryFirstOrDefaultAsync<Response>("dbo.USPEmployeeDelete", new
                {
                    EmloyeeId
                }, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }

            return response;
        }
        /*public ResponseList GetEmployeesList(ListParameter listParameter)
        {
            ResponseList response = new ResponseList();
            using (IDbConnection db = Connection)
            {
                var result =  db.QueryMultiple("[dbo].[UspNurseList]", new
                {
                    listParameter.Start,
                    listParameter.PageSize,
                    listParameter.SortCol,
                    listParameter.SearchKey
                    
                }, commandType: CommandType.StoredProcedure);


                response = result.Read<ResponseList>().FirstOrDefault();
                response.Data = result.Read<NursesList>().ToList();
                response.TotalRecords = result.Read<int>().FirstOrDefault();
                return response;
            }
            

        }*/
    }
}

