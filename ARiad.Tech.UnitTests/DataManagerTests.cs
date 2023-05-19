using ARiad.APITech.Infrastructure.Services;
using Xunit;

namespace ARiad.Tech.UnitTests
{
    public class DataManagerTests
    {
        private readonly DataManager _sut;
        public DataManagerTests()
        {
            _sut= new DataManager();
        }

        [Fact]
        public async Task Should_Return_Valid_Company()
        {
         var result= await   _sut.GetCompany(1);
            Assert.NotNull(result);
            Assert.Equal("CompanyA", result.Name);
        }
    }
}