using System.ComponentModel.DataAnnotations;

namespace TutorApp.Models
{
    public class Advertisement
    {
        
        public long Id { get; set; }
        public long KeywordId { get; set; }
        public long TutorId { get; set; }
        public DateTime DateOfExperience { get; set; }
        public decimal Value { get; set; }
    }
}
