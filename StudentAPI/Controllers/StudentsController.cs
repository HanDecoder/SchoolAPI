using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private DataContext context;
        public StudentsController(DataContext data) => context = data;

        [HttpGet]
        public IAsyncEnumerable<Student> GetStudents() => context.Students;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(long id)
        {
            Student student = await context.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
        
        [HttpPost]
        public async Task<IActionResult> SaveStudent(StudentModelBindingTarget target)
        {
            Student student = target.ToStudent();
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpPut]
        public async Task UpdateStudent(Student student)
        {
            context.Students.Update(student);
            await context.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async Task DeleteStudent(long id)
        {
            context.Students.Remove(new Student() { StudentID = id });
            await context.SaveChangesAsync();
        }
    }
}
