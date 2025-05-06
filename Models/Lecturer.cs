using System.ComponentModel.DataAnnotations;

namespace PublicationApi.Models
{
    public class Lecturer
    {
        public Guid Id { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        public string Department { get; set; }

        // Navigation back to UserAccount

        //public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<PublicationAuthor> PublicationAuthors { get; set; }
    }

}