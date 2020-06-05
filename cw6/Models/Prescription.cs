using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw6.Models
{
    public class Prescription
    {
        [Key]
        public int IdPrescription { set; get; }
        [Required]
        public DateTime Date { set; get; }
        [Required]
        public DateTime DueDate { set; get; }

        [ForeignKey("Patient")]
        public int IdPatient { set; get; }
        public Patient Patient { set; get; }

        [ForeignKey("Doctor")]
        public int IdDoctor { set; get; }
        public Doctor Doctor { set; get; }


    }
}
