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
            _waterContext = temp ?? throw new ArgumentNullException(nameof(temp));
        }

        [HttpGet("AllProjects")]
        public IActionResult GetProjects(
            int pageSize = 10, 
            int pageNum = 1, 
            [FromQuery] List<string>? projectTypes = null)
        {
            if (_waterContext.Projects == null)
            {
                return StatusCode(500, "DB not initialized or Projects table missing.");
            }
            
            string? favProjType = Request.Cookies["FavoriteProjectType"];
            Console.WriteLine("~~~~~~~COOKIE~~~~~~~\n" + favProjType);
            
            HttpContext.Response.Cookies.Append(
                "FavoriteProjectType", 
                "Protected Spring", 
                new CookieOptions()
            {
                // Means that this is ONLY available to the server
                HttpOnly = true,
                Secure = true, // Cookie will ONLY be transported to clientover HTTPS
                SameSite = SameSiteMode.Strict, // Has to be secure
                Expires = DateTime.Now.AddMinutes(5),
            });

            // Different from a list because it doesn't have to be a COMPLETE
            // list to be sent over, built for using QUERIES (selecting and filtering
            // specific data from a dataset

            try
            {
                var query = _waterContext.Projects.AsQueryable();

                if (projectTypes != null && projectTypes.Any())
                {
                    query = query.Where(p =>
                        !string.IsNullOrEmpty(p.ProjectType) && projectTypes.Contains(p.ProjectType));
                }

                var totalNumProjects = query.Count();

                // Go into DB, go into Projects table, give me the
                // results of that table in a List
                var something = query
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();


                var someObject = new
                {
                    Projects = something,
                    TotalNumProjects = totalNumProjects
                };

                return Ok(someObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetProjects: " + ex.Message);
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
            
        }

        [HttpGet("GetProjectTypes")]
        public IActionResult GetProjectTypes()
        {
            var projectTypes = _waterContext.Projects
                .Select(p => p.ProjectType)
                .Distinct()
                .ToList();
            
            return Ok(projectTypes);
        }
        
    }
}
