using RapidRetail.Api.Models;

namespace RapidRetail.Api.Repositories;

public class StudentsRepository : IRepository<Product>
{
    private readonly RapidRetailDbContext context;

    public StudentsRepository(RapidRetailDbContext context)
    {
        this.context = context;
    }

    public Product Add(Product entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Product? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
