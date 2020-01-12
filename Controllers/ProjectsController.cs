using ContentHeroApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContentHeroApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public List<ProjectModel> GetAllProjects()
        {
            return new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Id = 1,
                    Name = "Massey Yacht's Website",
                    Status = "Draft",
                    CustomerId = 1
                },
                new ProjectModel()
                {
                    Id = 2,
                    Name = "Tesla Cyber Truck Project",
                    Status = "Stuck",
                    CustomerId = 2
                },
                new ProjectModel()
                {
                    Id = 3,
                    Name = "Mark's Super Fantastic Fun Project",
                    Status = "Work in Progress",
                    CustomerId = 3
                }
            };
        }
    }
}
