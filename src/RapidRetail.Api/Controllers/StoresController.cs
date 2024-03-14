using RapidRetail.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace RapidRetail.Api.Controllers;

[ApiController]
[Route("api/v1/stores")]
public class StoresController : ControllerBase
{
    // TODO: Inject the repositories
    public StoresController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Store>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Store> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Store> Post(Store store)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Store> Put(int id, Store store)
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

    [HttpPost("{id}/register/{productId}")]
    public ActionResult<Store> Enroll(int id, int productId, Inventory inventory)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
