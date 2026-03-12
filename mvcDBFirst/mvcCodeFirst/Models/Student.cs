using System.Text.RegularExpressions;

namespace mvcCodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int? GroupId { get; set; }

        public virtual Group? Group { get; set; }
    }
}
