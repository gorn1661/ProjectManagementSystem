using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystemWebApi.Models;
using ProjectManagementSystemWebApi.Services;

namespace ProjectManagementSystemWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Projects")]
    public class ProjectsController : Controller
    {
        private readonly ProjectManagementSystemDbContext _context;

        public ProjectsController(ProjectManagementSystemDbContext context)
        {
            _context = context;
        }

        // GET: api/Projects
        [HttpGet]
        public IEnumerable<Project> GetProject()
        {
            return _context.Project;
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.SingleOrDefaultAsync(m => m.ProjectID == id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpGet("GetProjectByNumber")]
        public async Task<IActionResult> GetProjectByNumber([FromBody] string number)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.Where(m => m.ProjectNumber == number).Select(m => m).ToListAsync();

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpGet("GetProjectByName")]
        public async Task<IActionResult> GetProjectByName([FromBody] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.Where(m => m.Name == name).Select(m => m).ToListAsync();

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpGet("GetProjectByDate")]
        public async Task<IActionResult> GetProjectByDate([FromBody] DateTime startDate, [FromBody] DateTime endDate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.Where(m => m.StartDate > startDate && m.EndDate < endDate).Select(m => m).ToListAsync();

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpGet("GetProjectByCustomer")]
        public async Task<IActionResult> GetProjectByCustomer([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.Where(m => m.Customer == customer).Select(m => m).ToListAsync();

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpGet("GetProjectByEmployee")]
        public async Task<IActionResult> GetProjectByEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.EmployeeProject.Where(m => m.Employee == employee).Select(m => m.Project).ToListAsync();

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject([FromRoute] int id, [FromBody] Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != project.ProjectID)
            {
                return BadRequest();
            }

            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<IActionResult> PostProject([FromBody] Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Project.Add(project);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProject", new { id = project.ProjectID }, project);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var project = await _context.Project.SingleOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            _context.Project.Remove(project);
            await _context.SaveChangesAsync();

            return Ok(project);
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.ProjectID == id);
        }
    }
}