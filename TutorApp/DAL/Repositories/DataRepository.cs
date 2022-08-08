using Dapper;
using Microsoft.Data.SqlClient;
using TutorApp.DAL.ConnectionStringManager.ConnectionStringManagerInterface;

namespace TutorApp.DAL.Repositories
{
    public class DataRepository
    {
        private readonly IConnectionStringManager _connectionStringManager;
        public DataRepository(IConnectionStringManager connectionStringManager)
        {
            _connectionStringManager = connectionStringManager;
        }

        public void GetAllTutorData()
        {

            var querySql = "SELECT Name, Age, GenderIt, CityId FROM dbo.[Tutor]";

            using (var connection = new SqlConnection(_connectionStringManager.GetConnectionString()))
            {
                var users = connection.Query(querySql);
                foreach (var user in users)
                {
                    System.Diagnostics.Debug.WriteLine($"{user.Id} {user.Name} {user.Age}");
                }
            }

        }

    }
}
