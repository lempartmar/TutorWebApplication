using TutorApp.DAL;
using TutorApp.Models;
using TutorApp.ViewModels;

namespace TutorApp.Repositories.Interfaces
{
    public interface ITutorRepository
    {
        public List<Tutor> GetTutorsData();
        public List<TutorVM> GetTutorsDataByID(int Id);
        public List<Tutor> GetAllTutors();
    }
}
