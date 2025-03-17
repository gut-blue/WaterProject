using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaterProject.API.Data;

namespace WaterProject.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WaterController : ControllerBase
    {
        private WaterDbContext _waterContext;
        
        // This line creates an instance of our database that we 
        // can use in C#
        public WaterController(WaterDbContext temp)
        {
            _waterContext = temp;
        }

        [HttpGet("AllProjects")]
        public IEnumerable<Project> GetProjects()
        {
            // Go into DB, go into Projects table, give me the
            // results of that table in a List
            var something = _waterContext.Projects.ToList();

            return something;
        }

        [HttpGet("FunctionalProjects")]
        public IEnumerable<Project> GetFunctionalProjects()
        {
            var something = _waterContext.Projects
                .Where(p => p.ProjectFunctionalityStatus == "Functional")
                .ToList();
            return something;
        }
        
    }
}
