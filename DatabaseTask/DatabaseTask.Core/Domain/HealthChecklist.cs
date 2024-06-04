using System;

namespace DatabaseTask.Core.Domain
{
    public class HealthChecklist
    {
        public int EmployeeID { get; set; }
        public string Checklist_Item { get; set; }
        public string Status { get; set; }
    }
}
