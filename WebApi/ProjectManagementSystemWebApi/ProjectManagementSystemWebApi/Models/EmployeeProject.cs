using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystemWebApi.Models
{
    public class EmployeeProject
    {
        [Key]
        public int EmployeeProjectID { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
