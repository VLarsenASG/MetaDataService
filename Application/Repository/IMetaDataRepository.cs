using Domain.Dtos;

namespace Application.Repository
{
    public interface IMetaDataRepository
    {
        Task<IReadOnlyList<MetaDataDto>> GetMetaDataAsync();
        Task<MetaDataDto> GetMetaDataIdAsync(Guid Id);
    }
}
  