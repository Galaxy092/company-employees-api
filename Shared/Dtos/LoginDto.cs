using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record LoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
    }
}
