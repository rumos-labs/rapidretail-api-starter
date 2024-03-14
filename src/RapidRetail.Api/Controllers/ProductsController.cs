using RapidRetail.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace RapidRetail.Api.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductsController : ControllerBase
{
    // TODO: Inject the repositories
    public ProductsController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Product> Post(Product product)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Product> Put(int id, Product product)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
