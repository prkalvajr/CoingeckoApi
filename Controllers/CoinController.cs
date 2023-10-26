using Microsoft.AspNetCore.Mvc;

namespace _angularJS.Controllers
{
    public class CoinController : Controller
    {
        private readonly HttpClient _httpClient;

        public CoinController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("api/resource");

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
