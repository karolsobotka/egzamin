using egzamin.Models.DTOs;
using egzamin.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace egzamin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository repository;

        public ProjectController(IProjectRepository repository)
        {
            this.repository = repository;
        }


        [HttpPost("task")]
        public async Task<IActionResult> AddTask([FromBody] TaskDto dto)
        {
            var result = await repository.AddTaskAsync(dto);

            if (result != "Success!")
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject([FromRoute] int id)
        {
            var result = await repository.GetProjectAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }


    }
}
