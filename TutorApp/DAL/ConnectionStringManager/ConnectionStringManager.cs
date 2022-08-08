using TutorApp.DAL.ConnectionStringManager.ConnectionStringManagerInterface;

namespace TutorApp.DAL.ConnectionStringManager
{
    public class ConnectionStringManager : IConnectionStringManager
    {
        public string GetConnectionString()
        {
            return @"Data Source=LAPTOP-NH6R8H0H\SQLEXPRESS; Initial Catalog=DbModelWebTutor; Integrated Security = True";
        }
    }
}
