using mvcCodeFirst.Models;

namespace mvcCodeFirst.Services
{
    public interface ICourseService
    {
        public List<Student> Get();

        public List<Student> GetStudentList();
    }
}
