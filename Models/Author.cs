using System.ComponentModel.DataAnnotations;

namespace PublicationApi.Models
{
    public class Author
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Department { get; set; }
        public int? LecturerId { get; set; }
        public Lecturer LecturerProfile { get; set; }

        public string Affiliation { get; set; } // University or organization

        public ICollection<PublicationAuthor> PublicationAuthors { get; set; }
    }

}
