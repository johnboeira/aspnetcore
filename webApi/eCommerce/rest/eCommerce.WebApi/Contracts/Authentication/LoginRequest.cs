using System.ComponentModel.DataAnnotations;

namespace eCommerce.WebApi.Models.Authentication;

public record LoginRequest(
    [Required] string UserName,
    [Required] string Password);