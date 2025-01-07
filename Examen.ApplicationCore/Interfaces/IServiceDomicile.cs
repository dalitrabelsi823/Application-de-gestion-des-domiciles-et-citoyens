using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceDomicile : IService<Domicile>
    {
        public IList<Domicile> VillesOrdonnées();
    }
}
