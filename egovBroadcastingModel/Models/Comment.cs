using System.ComponentModel.DataAnnotations;

namespace egovBroadcastingModel.Models
{
    public class Comment
    {
        // Unique identifier for each comment
        public int Id { get; set; }

        // The content of the comment
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Content { get; set; }

        // The username of the person who made the comment
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Username { get; set; }

        // The date and time when the comment was posted
        [Required]
        public DateTime CommentDateTime { get; set; }

        // Foreign key reference to the associated disaster notice
        [Required]
        public int DisasterNoticeId { get; set; }

        // Navigation property to the related disaster notice
        public DisasterNotice DisasterNotice { get; set; }
    }
}
