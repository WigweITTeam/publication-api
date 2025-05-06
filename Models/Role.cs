namespace PublicationApi.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public Role()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }   
    }
}
