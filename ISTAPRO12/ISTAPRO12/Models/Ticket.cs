﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTAPRO12.Models
{
    public class Ticket
    {
        // Possible Ticket properties.
        public int TicketNum { get; set; }
        public int SubmitDate { get; set; }
        public int OpenDate { get; set; }
        public int CloseDate { get; set; }
        public int EmpID { get; set; }
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string Platform { get; set; }
        public string Summary { get; set; }
        public string Issue { get; set; }
        public string Resolution { get; set; }
    }
}
