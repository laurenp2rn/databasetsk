using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class HealthChecklist
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Checklist_Item { get; set; }
        public string Status { get; set; }
    }
}