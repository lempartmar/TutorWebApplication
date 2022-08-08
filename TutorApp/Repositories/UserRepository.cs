using TutorApp.DAL;
using TutorApp.Models;
using TutorApp.Repositories.Interfaces;

namespace TutorApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbWebContext _context;

        public UserRepository(DbWebContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public User GetUserById(long userId)
        {
            return _context.User.FirstOrDefault(x => x.Id == userId);
        }

        //public List<User> GetUsersWithKeyword(string Keyword)
        //{
        //    var result = new List<User>();



        //}

        public string Get()
        {
            return "string";
         }

        public int Save(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return 1;
        }
    }
}
