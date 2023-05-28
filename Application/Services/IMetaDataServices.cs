using Domain.Dtos;

namespace Application.Services
{
    public interface IMetaDataServices
    {

        Task<IReadOnlyList<MetaDataDto>> GetMetaDataAsync();

        Task<MetaDataDto> GetMetaDataIdAsync(Guid id);
    }
}
