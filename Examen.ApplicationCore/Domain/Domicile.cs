using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Domicile
    {

        [Key]
        public int Code { get; set; }
        public int NbrChambre { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Superifice doit etre positive")]
        public int Superficie { get; set; }
        public int Etage { get; set; }
        public int BatimentFK { get; set; }
        public virtual Batiment MyBatiment { get; set; }
        public virtual IList<Domicilaition> MyDomiciliations { get; set; }

    }
}
