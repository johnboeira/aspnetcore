using eCommerce.Domain.Features.Products;

namespace eCommerce.Application.Features.Products
{
    public interface IProductService
    {
        /// <summary>
        /// Creates a new product asynchronously.
        /// </summary>
        Task<Product> CreateAsync(Product product);

        /// <summary>
        /// Deletes a product by its identifier asynchronously.
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// Retrieves all products asynchronously.
        /// </summary>
        Task<IEnumerable<Product>> GetAllAsync();

        /// <summary>
        /// Retrieves a product by its identifier asynchronously.
        /// /// Returns null if the product is not found.
        /// </summary>
        Task<Product?> GetByIdAsync(Guid id);

        /// <summary>
        /// Updates an existing product's name and price asynchronously.
        /// </summary>
        Task UpdateAsync(Guid id, string name, decimal price);
    }
}