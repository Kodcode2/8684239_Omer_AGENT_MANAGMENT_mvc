using Management_of_Mossad_agents___MVC.Enum;
using Management_of_Mossad_agents___MVC.Models;

namespace Management_of_Mossad_agents___MVC.ViewModels
{
    public class MissionDetailsViewModel
    {
        public int MissionId { get; set; }
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public Location AgentLocation { get; set; }
        public int TargetId { get; set; }
        public string TargetName { get; set; }
        public Location TargetLocation { get; set; }
        public double Distance { get; set; }
        public MissionStatus Status { get; set; } 
    }

    
}
