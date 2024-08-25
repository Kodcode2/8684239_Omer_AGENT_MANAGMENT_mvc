namespace Management_of_Mossad_agents___MVC.Models
{
    public class Target
    {
        public int id { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public string position { get; set; }
        public Location location { get; set; }
        public int status { get; set; }
    }
}
