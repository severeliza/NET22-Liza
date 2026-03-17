using Microsoft.EntityFrameworkCore;
using mvcCodeFirst.Models;

namespace mvcCodeFirst.Services
{
    public class CourseService : ICourseService
    {

        private readonly CourseDbContext _context;

        public CourseService(CourseDbContext context)
        {
            _context = context;
        }

        public List<Student> Get()
        {
            return _context.Students.Where(s => !s.FirstName.StartsWith("Student")).OrderBy(s => s.FirstName).ToList();
        }

        public List<Student> GetStudentList()
        {
            return _context.Students.Where(s=>s.Group.CourseId == 1).OrderBy(s => s.FirstName).ToList();
        }

        #region добавление
        private void AddGroups()
        {
            Group[] g = {
            new Group()
            {
                Name = "GroupFromCode3",
                CourseId = 3,
                Students = {
                new Student(){ LastName = "Liza", FirstName = "Sev"},
                new Student(){ LastName = "Liza", FirstName = ""}
                }
            },
            new Group()
            {
                Name = "GroupFromCode4",
                CourseId = 1,
                Students = {
                new Student(){ LastName = "Ivan", FirstName = ""},
                new Student(){ LastName = "Ivan2", FirstName = "Ivan2"}
                }
            }
            };

            _context.Groups.AddRange(g);
            _context.SaveChanges();
        }
        #endregion
    }
}
