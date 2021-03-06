﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystemWebApi.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [Required]
        public string ProjectNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
