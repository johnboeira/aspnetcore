using eCommerce.WebApi.Contracts.Product;
using eCommerce.WebApi.Infra;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebApi.Controllers;

[ApiController]
//[Route("api/[controller]")]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class ProductController(ProductRepository productRepository) : ControllerBase
{
    private readonly ProductRepository _productRepository = productRepository;

    [HttpGet]
    [Route(ApiEndpoints.Movies.Get)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProductResponse>> GetById([FromRoute] Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product is null)
            return NotFound();

        return Ok(product);
    }

    [HttpGet]
    [Route(ApiEndpoints.Movies.GetAll)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
    {
        var product = await _productRepository.GetAllAsync();

        return Ok(product);
    }

    [HttpPost]
    [Route(ApiEndpoints.Movies.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateProduct([FromBody] ProductCreateRequest product)
    {
        var createdProduct = await _productRepository.CreateAsync(product);

        return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPut]
    [Route(ApiEndpoints.Movies.Update)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateProduct([FromBody] ProductResponse product)
    {
        var productToUpdate = await _productRepository.GetByIdAsync(product.Id);

        if (productToUpdate is null)
            return NotFound();

        productToUpdate.Update(product.Name, product.Price);

        return NoContent();
    }

    [HttpDelete]
    [Route(ApiEndpoints.Movies.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
    {
        var productToDelete = await _productRepository.GetByIdAsync(id);

        if (productToDelete is null)
            return NotFound();

        await _productRepository.DeleteAsync(productToDelete);

        return NoContent();
    }
}