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
            var response = await _httpClient.GetAsync("http://localhost:5288/agents");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var agentApiResponse = JsonConvert.DeserializeObject<AgentApiResponse>(jsonResponse);

            return View(agentApiResponse.Agents);
        }









    }
}
