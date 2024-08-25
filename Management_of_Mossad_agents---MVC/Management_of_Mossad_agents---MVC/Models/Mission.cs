namespace Management_of_Mossad_agents___MVC.Models
{
    public class Mission
    {
        public int id { get; set; }
        public Agent agentid { get; set; }
        public Target targetid { get; set; }
        public Double timeLeft { get; set; }
        public Double actualExecutionTime { get; set; }
        public int status { get; set; }
    }
}
