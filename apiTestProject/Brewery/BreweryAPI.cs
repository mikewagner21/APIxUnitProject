using apiTestProject.Brewery.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace apiTestProject.Brewery
{
    public class BreweryAPI
    {
        private HttpClient restClient = new HttpClient();
        private string URI = "https://api.openbrewerydb.org/breweries/";

        public async Task<GetBreweryResponse> Get_Brewery(string brewery)
        {
            UriBuilder builder = new UriBuilder($"{URI}{brewery}");
            var response = await restClient.GetAsync(builder.Uri);
            var context = await response.Content.ReadAsStringAsync();

            try
            {
                var responseModel = JsonConvert.DeserializeObject<GetBreweryResponse>(context);
                return responseModel;
            }
            catch
            {
                return null;
            }
        }
    }
}
