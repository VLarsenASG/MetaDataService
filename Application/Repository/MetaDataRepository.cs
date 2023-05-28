using Domain.Dtos;

namespace Application.Repository;

public class MetaDataRepository : IMetaDataRepository
{

    private readonly Dictionary<Guid, MetaDataDto> metaData = new Dictionary<Guid, MetaDataDto>()
    {
        { Guid.Parse("b5315028-60cb-4571-b81c-ecec008d908c"), new MetaDataDto(Guid.Parse(
            "b5315028-60cb-4571-b81c-ecec008d908c"), 
            "The Super Mario Bros. Movie", 
            2023, 
            "Adventure/Comedy")}
       
    };

    public Task<IReadOnlyList<MetaDataDto>> GetMetaDataAsync()
    {
        return Task.FromResult<IReadOnlyList<MetaDataDto>>(metaData.Values.ToList());
    }

    public Task<MetaDataDto> GetMetaDataIdAsync(Guid Id)
    {
        metaData.TryGetValue(Id, out var id);
        return Task.FromResult(id);
    }

   


}
