using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public int SickLeave_ID { get; set; }
        public int Employee_ID { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}

