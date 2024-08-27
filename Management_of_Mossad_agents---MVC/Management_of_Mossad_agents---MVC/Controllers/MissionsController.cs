using Management_of_Mossad_agents___MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Management_of_Mossad_agents___MVC.Controllers
{
    public class MissionsController : Controller
    {
        private readonly HttpClient _httpClient;

        public MissionsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var apiUrl = "http://localhost:5288/Missions/proposal";
            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<MissionsResponse>(jsonString);

                return View(result.Missions);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> AssignForTheMission(int missionId)
        {
            

            var apiUrl = $"http://localhost:5288/Missions/{missionId}";
            var response = await _httpClient.PutAsync(apiUrl, null);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }



        public async Task<IActionResult> MissionDetails(int id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5288/missions/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return View("Error");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var mission = JsonConvert.DeserializeObject<MissionDetailsViewModel2>(jsonResponse);

            return View(mission);
        }
    }
}
