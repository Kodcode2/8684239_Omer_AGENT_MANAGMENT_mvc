using Management_of_Mossad_agents___MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Management_of_Mossad_agents___MVC.Controllers
{
    public class OverviewController : Controller
    {
        private readonly HttpClient _httpClient;

        public OverviewController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<IActionResult> Overview()
        {
            OverviewViewModel overview = null;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://localhost:5288/View/overview");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    overview = JsonConvert.DeserializeObject<OverviewViewModel>(jsonString);
                }
                else
                {
                    return View("Error");
                }
            }

            return View(overview);
        }




    }


}
