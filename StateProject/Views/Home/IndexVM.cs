using System.ComponentModel.DataAnnotations;

namespace StateProject.Views
{
    public class IndexVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
