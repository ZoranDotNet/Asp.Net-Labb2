using Edugrade.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Edugrade.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly AppDbContext _context;

        public AdministrationController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> FilterOnCourse(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var students = await _context.Enrollments
                .Where(e => e.FkCourseId == id)
                .Include(e => e.Teacher)
                .Include(s => s.Student)
                .ThenInclude(sc => sc.SchoolClass)
                .Select(e => new
                {
                    Course = e.Course.Name,
                    Student = e.Student.Fullname,
                    SchoolClass = e.Student.SchoolClass.ClassName,
                    Teacher = e.Teacher.Fullname
                }).ToListAsync();

            ViewBag.Course = await _context.Courses.Where(c => c.Id == id).Select(c => c.Name).FirstOrDefaultAsync();
            return View(students);
        }

        public IActionResult FilterTeachers()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> TeacherResults(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var teachers = await _context.Enrollments
            .Where(c => c.FkCourseId == id)
            .Include(t => t.Teacher)
            .Select(e => new
            {
                Course = e.Course.Name,
                Teacher = e.Teacher.Fullname
            })
            .Distinct().ToListAsync();


            ViewBag.Course = await _context.Courses.Where(c => c.Id == id).Select(c => c.Name).FirstOrDefaultAsync();
            return View(teachers);
        }

        public async Task<IActionResult> AllStudents()
        {
            var studentAndTeachers = await _context.Enrollments
                .Include(s => s.Student)
                .Include(t => t.Teacher)
                .GroupBy(e => e.Student)
                .Select(g => new
                {
                    Student = g.Key.Fullname,
                    Teachers = g.Select(e => e.Teacher.Fullname).ToList()
                }).ToListAsync();


            return View(studentAndTeachers);
        }
    }
}
