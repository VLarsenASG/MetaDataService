using Application.Services;
using Domain.Dtos;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace MetaDataService.Controllers;

public class MetaDataController : ApiController
{

    private readonly IMetaDataServices _metaDataService;
    public MetaDataController(IMetaDataServices metaDataService)
    {
        _metaDataService = metaDataService;
    }

    [HttpGet("api/v1/metadata")]
    public async Task<IReadOnlyList<MetaDataDto>> GetMetaData()
    {
        var metaData = await _metaDataService.GetMetaDataAsync();
        return metaData;
    }


    [HttpGet("api/v1/metadata/id")]
    public async Task<MetaDataDto> GetMetaDataId(Guid id)
    {
        var metaDataId = await _metaDataService.GetMetaDataIdAsync(id);
        return (MetaDataDto)metaDataId;
    }
}
