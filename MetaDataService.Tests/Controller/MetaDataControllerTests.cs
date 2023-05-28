using Application.Services;
using Domain.Dtos;
using FakeItEasy;
using FluentAssertions;
using MetaDataService.Controllers;

namespace MetaDataService.Tests.Controller
{
    public class MetaDataControllerTests
    {
        private readonly IMetaDataServices _metaDataServices;
      
        

        public MetaDataControllerTests()
        {
            _metaDataServices = A.Fake<IMetaDataServices>();

        }

        [Fact]
        public void MetaDataController_GetMetaData_Return_Data()
        {
            //Arrange
            var id = Guid.NewGuid();       
            var metaData = A.Fake<MetaDataDto>();
            A.CallTo(() => _metaDataServices.GetMetaDataIdAsync(id)).Returns(metaData); 
            var controller = new MetaDataController(_metaDataServices);
            
            //Act
            var result = controller.GetMetaDataId(id);
          

            //Assert
            result.Should().NotBeNull();

        }
      
    }
}
