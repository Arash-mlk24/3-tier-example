using Microsoft.EntityFrameworkCore;
using ThreeTierApplication.Database;
using ThreeTierApplication.Model.Entities;

namespace ThreeTierApplication.Repository;

public class HumanRepository : IHumanRepository
{
    private readonly AppDb _database;

    public HumanRepository(AppDb database)
    {
        _database = database;
    }

    public Task<List<Human>> GetAll(CancellationToken cancellationToken)
    {
        return _database.Humans
            .ToListAsync();
    }
}