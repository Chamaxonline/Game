using AutoMapper;
using CM.Repository.Abstract;
using Dapper;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CM.Repository.Repo
{
    public class UserManagerRepo : IUserManagerRepo
    {
        private readonly string connectionString = "Server=DESKTOP-E195Q8F\\MSSQLSERVER2017;Database=SCB_UAT;Database=SCB_UAT;User Id=sa;Password=sasql2017;";

        private SqlConnection sqlConnection;

        public async Task AddUser(User user)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                // dynamicParameters.Add("@UserId", user.Id);
                dynamicParameters.Add("@FirstName", user.FirstName);
                dynamicParameters.Add("@LastName", user.LastName);
                dynamicParameters.Add("@DistrictId", user.DistrictId);
                dynamicParameters.Add("@UserName", user.UserName);
                dynamicParameters.Add("@Email", user.Email);
                dynamicParameters.Add("@Password", user.Password);

                await sqlConnection.ExecuteAsync(
                    "spAddUser",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public async Task<User> GetUser(int Id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserId", Id);
                return await sqlConnection.QuerySingleOrDefaultAsync<User>(
                     "spGetUser",
                     dynamicParameters,
                     commandType: CommandType.StoredProcedure);

            }
        }
        //public async Task<District>
    }
}
