namespace PublicationApi.Models
{
    public class User
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g., "admin", "user"
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }  
        //public Lecturer LecturerProfile { get; set; } // Optional, if the user is a lecturer
        public User()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
