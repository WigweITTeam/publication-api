using System.ComponentModel.DataAnnotations;

namespace PublicationApi.Models
{
    public class Publication
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Abstract { get; set; }

        [MaxLength(200)]
        public string JournalName { get; set; }

        [MaxLength(50)]
        public string Volume { get; set; }

        [MaxLength(50)]
        public string IssueNumber { get; set; }

        [MaxLength(50)]
        public string Pages { get; set; }

        [Range(1900, 2100)]
        public int PublicationYear { get; set; }

        [MaxLength(100)]
        public string DOI { get; set; }

        [MaxLength(500)]
        public string Keywords { get; set; }

        public string FilePath { get; set; }

        [MaxLength(100)]
        public string LicenseType { get; set; }

        public bool IsOpenAccess { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public ReviewStatus OverallStatus { get; set; } // calculated or set manually

        public ICollection<PublicationAuthor> PublicationAuthors { get; set; }
    }
}
