using ThreeTierApplication.Model.Entities;

namespace ThreeTierApplication.Repository;

public interface IHumanRepository
{
    public Task<List<Human>> GetAll(CancellationToken cancellationToken);
}