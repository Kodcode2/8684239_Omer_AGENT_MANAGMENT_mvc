using Management_of_Mossad_agents___MVC.Enum;

namespace Management_of_Mossad_agents___MVC.ViewModels
{
    public class MissionDetailsViewModel2
    {
        public int MissionId { get; set; }
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public int TargetId { get; set; }
        public string TargetName { get; set; }
        public MissionStatus Status { get; set; }
        public double? TimeLeft { get; set; }
    }
}
