using System.ComponentModel.DataAnnotations;

namespace MinimalApiLearning.Dtos;

public class CommandCreateDto
{
    [Required]
    public string? HowTo { get; set; }
    [Required]
    public string? Platform { get; set; }
    [Required]
    public string? CommandLine { get; set; }
}
