using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<StudentCourse>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public virtual ICollection<StudentCourse> JoinEntities { get; set; }
  }
}