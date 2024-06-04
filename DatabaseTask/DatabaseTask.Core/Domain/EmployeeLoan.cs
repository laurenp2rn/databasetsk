using System;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeLoan
    {
        public int Loan_ID { get; set; }
        public int Employee_ID { get; set; }
        public int Item_ID { get; set; }
        public DateTime Loan_Date { get; set; }
        public DateTime Return_Date { get; set; }
    }
}
