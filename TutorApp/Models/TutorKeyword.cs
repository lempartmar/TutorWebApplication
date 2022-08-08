namespace TutorApp.Models
{
    public class TutorKeyword
    {
        public long TutorId { get; set; }
        public long KeywordId { get; set; }
        public Keyword Keyword { get; set; }
        public Tutor Tutor { get; set; }    
    }
}
