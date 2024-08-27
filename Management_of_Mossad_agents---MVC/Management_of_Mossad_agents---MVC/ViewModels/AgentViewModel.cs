using Management_of_Mossad_agents___MVC.Enum;
using Management_of_Mossad_agents___MVC.Models;

namespace Management_of_Mossad_agents___MVC.ViewModels
{
    public class AgentViewModel
    {
        public int AgentId { get; set; }
        public string PhotoUrl { get; set; } 
        public string AgentName { get; set; }
        public Location Location { get; set; }
        public AgentStatus Status { get; set; }
        public int? MissionId { get; set; } 
        public double? TimeToEliminate { get; set; }
        public int EliminationsCount { get; set; }
    }

   

}
