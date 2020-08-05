using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

        [HttpGet("{cls}/{section}/{roll}")]
        public async Task<IActionResult> GetStudent(long cls, string section, long roll)
        {
            Student student = await context.Students.Where((stud) => stud.StudentClass == cls && stud.Section == section && stud.Roll == roll).FirstOrDefaultAsync();

            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpGet("{cls}/{section}")]
        public IQueryable<Student> GetStudent(long cls, string section)
        {
            IQueryable<Student> student = context.Students.Where((stud) => stud.StudentClass == cls && stud.Section == section);
            return student;
        }

        [HttpGet("{cls}")]
        public IQueryable<Student> GetStudent(long cls)
        {
            IQueryable<Student> student = context.Students.Where((stud) => stud.StudentClass == cls);
            return student;
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
