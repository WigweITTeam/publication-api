using Microsoft.Build.Framework;

namespace PublicationApi.DTOs
{
    public class CreateUpdateRoleDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
