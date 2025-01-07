using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Domicilaition
    {
        public TypeDommiciliation MyTypeDommiciliation { get; set; }
        public int CitoyenCode { get; set; }
        public int DomicileCode { get; set; }
        public virtual Domicile MyDomicile { get; set; }
        public virtual Citoyen MyCitoyen { get; set; }
    }
}
