namespace Management_of_Mossad_agents___MVC.Models
{
    public class Agent
    {
        public int id { get; set; }
        public string photoUrl { get; set; }
        public string nickname { get; set; }
        public Location location { get; set; }
        public int status { get; set; }
    }
}
