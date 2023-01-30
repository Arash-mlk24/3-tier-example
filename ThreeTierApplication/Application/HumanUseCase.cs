using ThreeTierApplication.Model.Dtos;
using ThreeTierApplication.Repository;

namespace ThreeTierApplication.Application;

public class HumanUseCase : IHumanUseCase
{
    private readonly IHumanRepository _humanRepository;

    public HumanUseCase(IHumanRepository humanRepository)
    {
        _humanRepository = humanRepository;
    }

    public async Task<IEnumerable<HumanDto>> GetHumans(CancellationToken cancellationToken)
    {
        return (await _humanRepository.GetAll(cancellationToken)).Select(human => new HumanDto
        {
            Age = human.Age,
            Name = human.Name,
            HumanId = human.Id
        });
    }
}