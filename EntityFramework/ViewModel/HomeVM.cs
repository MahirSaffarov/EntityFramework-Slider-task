using EntityFramework.Models;

namespace EntityFramework.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Slider { get; set; }
        public List<Futures> Futures { get; set; }
        public List<Service> Services { get; set; }
        public List<Project> Projects { get; set; }
    }
}
