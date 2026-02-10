using System.ComponentModel.DataAnnotations;

namespace NetCoreWebApp_Example.Models
{
    public class LoanModel
    {
       

        [Required(ErrorMessage = "*")]
        public int LoanNo { get; set; }
        [Required(ErrorMessage = "*")]

        public int AccountNo { get; set; }
        [Required(ErrorMessage = "*")]


        public int Amount { get; set; }
        [Required(ErrorMessage = "*")]

        public string LoanType { get; set; }
        [Required(ErrorMessage = "*")]

        public string LoanCategory { get; set; }
        [Required(ErrorMessage = "*")]

        public string CurrentAddress { get; set; }
        [Required(ErrorMessage = "*")]

        public string LoanRemarks { get; set; }

    }
}
