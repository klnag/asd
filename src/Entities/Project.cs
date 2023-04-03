using System.ComponentModel.DataAnnotations;

namespace src.Entities;

public class Project {
    [Key]
    public int Id { get; set; }
    [Required]
    public string? name { get; set; }
}