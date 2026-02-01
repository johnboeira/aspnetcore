using eCommerce.WebApi.Contracts.Product;
using eCommerce.WebApi.Domain;

namespace eCommerce.WebApi.Mappings;

public static class ProductMappingExtensions
{
    public static ProductResponse ToProductResponse(this Product product)
    {
        return new ProductResponse(product.Id, product.Name, product.Price);
    }

    public static IEnumerable<ProductResponse> ToProductResponse(this IEnumerable<Product> products)
    {
        return products.Select(p => p.ToProductResponse());
    }
}