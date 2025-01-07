using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Batiment
    {
        [Key]
        public int Code { get; set; }
        public string Adresse { get; set; }

        [Range(0, int.MaxValue ,ErrorMessage ="Superifice doit etre positive")]
        public int Superficie { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "SuperificeVente doit etre positive")]
        public int SuperficieVente { get; set; }
        public string Gouvernorat { get; set; }
        public string ville { get; set; }
        public virtual IList<Domicile> MyDomiciles { get; set; }
        

    }
}
