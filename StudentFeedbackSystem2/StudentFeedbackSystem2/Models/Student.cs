using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackSystem2.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Email { get; set; }
        public string Feedback { get; set; }
    }
}
