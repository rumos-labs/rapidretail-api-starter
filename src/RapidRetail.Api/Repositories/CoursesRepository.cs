using RapidRetail.Api.Models;

namespace RapidRetail.Api.Repositories;

public class CoursesRepository : IRepository<Store>
{
    private readonly RapidRetailDbContext context;

    public CoursesRepository(RapidRetailDbContext context)
    {
        this.context = context;
    }

    public Store Add(Store entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Store? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Store> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Store entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
