using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceCitoyen : IService<Citoyen>
    {
        public float pourcentageJeune();
        public float pourcentageNonEduqués();
        
    }
}
