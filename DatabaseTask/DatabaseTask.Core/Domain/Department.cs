using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public int Manager_ID { get; set; }
        public int Employee_ID { get; set; }
    }
}
