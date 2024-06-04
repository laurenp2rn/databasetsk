namespace DatabaseTask.Core.Domain
{
    public class LoanableItem
    {
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public int Quantity_Available { get; set; }
        public int Loan_Period { get; set; } // days
    }
}
