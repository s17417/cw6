using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw6.Models
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { set; get; }
        [Required]
        [MaxLength(100)]
        public string FirstName { set; get; }
        [Required]
        [MaxLength(100)]
        public string LastName { set; get; }
        [EmailAddress]
        public string Email { set; get; }

        public List<Prescription> Prescriptions { set; get; }
    }
}
