using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class VacationSchedule
    {
        [Key]
        public int EmployeeID { get; set; }
    }
}
