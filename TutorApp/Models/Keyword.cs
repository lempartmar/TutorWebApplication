namespace TutorApp.Models
{
    public class Keyword
    {
        public long Id { get; set; }
        public string Keyword_Text { get; set; } 
        public ICollection<TutorKeyword> TutorsKeywords { get; set; }

    }
}
