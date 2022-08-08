namespace TutorApp.Models
{
    public class Tutor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long? CityId { get; set; }
        public ICollection<TutorKeyword> TutorsKeywords { get; set; }
    }
}
