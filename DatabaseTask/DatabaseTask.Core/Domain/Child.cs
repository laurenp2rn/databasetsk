using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int ChildID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int EmployeeID { get; set; }
    }
}

