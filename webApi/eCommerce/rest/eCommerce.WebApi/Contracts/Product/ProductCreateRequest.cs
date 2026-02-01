using System.ComponentModel.DataAnnotations;

namespace eCommerce.WebApi.Contracts.Product;

public record ProductCreateRequest(
    [Required] string Name,
    [Required] decimal Price);