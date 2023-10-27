using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace _angularJS.Controllers
{
    public class CoinController : Controller
    {
        private readonly HttpClient _httpClient;

        public CoinController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "CoinTech");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "apikey");
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("coins/markets?vs_currency=usd");
                // &ids=bitcoin&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();



                    // Deserialize the JSON data into a model class (if applicable)
                    // Example: var result = JsonConvert.DeserializeObject<MyModel>(data);

                    return View("Index", data);
                }

                return View();
            }
            catch (Exception e)
            {

                return View("Error");
            }     
        }
    }
}
