using System.ComponentModel.DataAnnotations;

namespace ISTAPRO12.Models
{
    public class Ticket
    {
        // Changed TicketNum to TicketID so EF would auto assign it as a Primary Key.
        public int TicketID { get; set; }
        public string SubmitDate { get; set; }
        public string OpenDate { get; set; }
        public string CloseDate { get; set; }
        public int EmpID { get; set; }
        [Required(ErrorMessage = "Please enter a full name")]
        public string CustName { get; set; }
        [Required(ErrorMessage = "Please enter an email address")]
        public string CustEmail { get; set; }
        [Required(ErrorMessage = "Please enter a device or software causing the issue")]
        public string Platform { get; set; }
        [Required(ErrorMessage = "Please enter a brief summary of the issue")]
        public string Summary { get; set; }
        [Required(ErrorMessage = "Please enter a detailed description of the issue")]
        public string Issue { get; set; }
        public string Resolution { get; set; }
    }
}
