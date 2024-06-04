using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public int Company_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Field { get; set; }
        public string Location { get; set; }
        public decimal Sales { get; set; }
    }
}
