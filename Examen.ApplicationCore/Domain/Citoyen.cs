using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Citoyen
    {
        [Key]
        public int Code { get; set; }
        [MinLength(8),MaxLength(8)]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Le CIN doit contenir exactement 8 chiffres.")]
        public string CIN { get; set; }

        [Required]
        public string NomPrenom { get; set; }
        [Required]
        public Sexe MySexe { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }
        [Required]
        public Education MyEducation { get; set; }
        [Required]
        public virtual IList<Domicilaition> MyDomiciliations { get; set; }

    }
}
