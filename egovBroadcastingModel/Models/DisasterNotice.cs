using System.ComponentModel.DataAnnotations;

namespace egovBroadcastingModel.Models
{
    public enum Severity
    {
        Minor = 1,
        Moderate = 2,
        Severe = 3
    }
    public class DisasterNotice
    {
        // Unique identifier for each disaster notice
        public int Id { get; set; }

        // Type of disaster (e.g., Earthquake, Flood, Hurricane, etc.)
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string DisasterType { get; set; }

        // Title or brief description of the disaster
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        // Detailed description of the disaster and its impact
        [Required]
        public string Description { get; set; }

        // Date and time when the disaster occurred or is expected to occur
        [Required]
        public DateTime EventDateTime { get; set; }

        // Severity level of the disaster (e.g., Minor, Moderate, Severe)
        [Required]
        public Severity Severity { get; set; }

        // Location where the disaster occurred or is expected to occur
        [Required]
        [StringLength(200)]
        public string Location { get; set; }

        // Source of the information (e.g., Government Agency, News Outlet)
        [Required]
        [StringLength(100)]
        public string Source { get; set; }

        // Date and time when the notice was created or updated
        [Required]
        public DateTime NoticeDateTime { get; set; }


        // Additional remarks or notes
        public string Remarks { get; set; }

        // Collection of comments related to the disaster notice
        public ICollection<Comment> Comments { get; set; }
    }
}
