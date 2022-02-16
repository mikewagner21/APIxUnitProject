using apiTestProject.Brewery;
using Xunit;

namespace apiTestProject
{
    public class BreweryTests
    {
        [Trait("Category", "API Test")]
        [Theory]
        [InlineData("madtree-brewing-cincinnati")]
        public async void Get_Brewery_Info(string brewery)
        {
            BreweryAPI api = new BreweryAPI();
            var response = await api.Get_Brewery(brewery);
            Assert.Equal("Cincinnati", response.city);
        }
    }
}