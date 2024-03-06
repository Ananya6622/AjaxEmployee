using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxEmployeePayroll.Entity
{
    public class EmpEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        
        public string ProfileImage { get; set; }
        
        public string Gender { get; set; }
        
        public string Department { get; set; }
        
        public decimal Salary { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public string Notes { get; set; }
    }
}
