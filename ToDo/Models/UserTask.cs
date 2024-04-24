using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class UserTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }

    }
}
