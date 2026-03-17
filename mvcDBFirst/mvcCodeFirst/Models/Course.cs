using System.Text.RegularExpressions;

namespace mvcCodeFirst.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
