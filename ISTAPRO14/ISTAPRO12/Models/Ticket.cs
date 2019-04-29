using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISTAPRO12.Models
{
    public class Ticket
    {
        // Possible Ticket properties.
        public int TicketNum { get; set; }
        public string SubmitDate { get; set; }
        public string OpenDate { get; set; }
        public string CloseDate { get; set; }
        public int EmpID { get; set; }
        public int CustID { get; set; }
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
