using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeLoan
    {
        [Key]
        public int EmployeeID { get; set; }
        public int LoanID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Employee Employee { get; set; }
        public LoanableItem LoanableItem { get; set; }
    }
}
