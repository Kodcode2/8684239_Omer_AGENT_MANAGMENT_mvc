using Management_of_Mossad_agents___MVC.Models;
using Management_of_Mossad_agents___MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Management_of_Mossad_agents___MVC.Controllers.MissionsController;

namespace Management_of_Mossad_agents___MVC.Controllers
{
    public class AgentsController : Controller
    {
        private HttpClient _httpClient;
        public AgentsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var apiUrl = "http://localhost:5288/Agents";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AgentsResponse>(jsonString);
            return View(result.Agents);
        }




    }
}
