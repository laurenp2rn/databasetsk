using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class AccessLevel
    {
        [Key]
        public int Access_Level_ID { get; set; }
        public string Level_Name { get; set; }
        public string Description { get; set; }
    }
}
