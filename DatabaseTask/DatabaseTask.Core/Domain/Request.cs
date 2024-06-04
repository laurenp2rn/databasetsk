using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Request_type { get; set; }
        public DateTime Request_date { get; set; }
        public int Status { get; set; }
        public int Description { get; set; }
    }
}

