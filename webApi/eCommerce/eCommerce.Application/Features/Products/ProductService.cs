using eCommerce.Domain.Features.Products;

namespace eCommerce.Application.Features.Products;

public class ProductService : IProductService
{
    public async Task<Product> CreateAsync(Product product)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Guid id, string name, decimal price)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}