using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee_api.Model
{
    [Table("employeeMaster")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string lastName { get; set; }
        public string email { get; set; }
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public string phone { get; set; }
        public string city { get; set; }
        public string address { get; set; }
    }
}
