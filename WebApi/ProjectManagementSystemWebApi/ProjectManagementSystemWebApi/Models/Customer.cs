using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystemWebApi.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string NIP { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
