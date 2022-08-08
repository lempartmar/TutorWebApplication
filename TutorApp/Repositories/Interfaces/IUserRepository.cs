using TutorApp.Models;

namespace TutorApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        int Save(User user);
        string Get();
    }
}
