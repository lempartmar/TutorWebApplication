namespace TutorApp.ViewModels
{
    public class TutorVM
    {
        public TutorVM(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
      
    }
}
