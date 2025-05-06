using System.ComponentModel.DataAnnotations;

namespace PublicationApi.Models
{
    public class Review
    {
        public Guid Id { get; set; }

        [Required]
        public Guid PublicationId { get; set; }
        public Publication Publication { get; set; }

        [Required]
        public Guid ReviewerId { get; set; }
        public Lecturer Reviewer { get; set; }

        [Required]
        public DateTime DateReviewed { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }

        [Required]
        public ReviewStatus Status { get; set; } // e.g., Approved, Rejected, NeedsRevision
    }
}
