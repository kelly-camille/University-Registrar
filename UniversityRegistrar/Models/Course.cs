using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<StudentCourse>();
    }

    public int CourseId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<StudentCourse> JoinEntities { get; }
  }
}