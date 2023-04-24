using System.ComponentModel.DataAnnotations;

namespace MyPortifolioAdmin.Data;

public class ContactItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string Icon { get; set; } = string.Empty;
}
