using System.ComponentModel.DataAnnotations;

namespace MyPortifolioAdmin.Data;

public class PortifolioItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Image { get; set; } = string.Empty;
    [Required]
    public string Url { get; set; } = string.Empty;
    [Required]
    public string UrlGitHub { get; set; } = string.Empty;
}
