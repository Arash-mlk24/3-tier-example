using ThreeTierApplication.Model.Dtos;

namespace ThreeTierApplication.Application;

public interface IHumanUseCase
{
    public Task<IEnumerable<HumanDto>> GetHumans(CancellationToken cancellationToken);
}