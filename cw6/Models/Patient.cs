using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw6.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { set; get; }
        [Required]
        [MaxLength(100)]
        public string Firstame { set; get; }
        [Required]
        [MaxLength(100)]
        public string LastName { set; get; }
        [Required]
        public DateTime Birthdate { set; get; }

        public List<Prescription> Prescriptions { set; get; }
    }
}
