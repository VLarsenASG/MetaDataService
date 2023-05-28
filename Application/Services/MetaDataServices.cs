using Application.Repository;
using Domain.Dtos;

namespace Application.Services
{
    public class MetaDataServices : IMetaDataServices
    {

        private readonly IMetaDataRepository metaDataRepository;

        public MetaDataServices(IMetaDataRepository metaDataRepository)
        {
            this.metaDataRepository = metaDataRepository;
        }
    
        public async Task<IReadOnlyList<MetaDataDto>> GetMetaDataAsync()
        {
            var metaData = await metaDataRepository.GetMetaDataAsync();
            return metaData;
        }

        public async Task<MetaDataDto> GetMetaDataIdAsync(Guid id)
        {
            var metaDataId = await metaDataRepository.GetMetaDataIdAsync(id);
            return metaDataId;
        }
    }
}
