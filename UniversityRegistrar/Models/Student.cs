using System.Collections.Generic;

namespace UniversityResistrar.Models
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