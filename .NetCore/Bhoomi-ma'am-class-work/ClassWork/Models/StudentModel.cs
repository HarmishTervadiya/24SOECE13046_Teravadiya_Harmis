using System.ComponentModel.DataAnnotations;

namespace ClassWork.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="name is required")]
        public string Name {  get; set; }
        public string Branch { get; set; }
        public string EnrollmentNo { get; set; }


    }
}
