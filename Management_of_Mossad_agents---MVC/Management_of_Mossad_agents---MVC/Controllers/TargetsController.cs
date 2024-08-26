using Management_of_Mossad_agents___MVC.Models;
using Management_of_Mossad_agents___MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Management_of_Mossad_agents___MVC.Controllers.MissionsController;

namespace Management_of_Mossad_agents___MVC.Controllers
{
    public class TargetsController : Controller
    {
        private HttpClient _httpClient;
        public TargetsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var apiUrl = "http://localhost:5288/Targets";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TargetResponse>(jsonString);
            return View(result.Targets);
        }

        


    }
}
