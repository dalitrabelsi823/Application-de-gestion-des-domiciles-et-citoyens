using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class ServiceDomicile : Service<Domicile>, IServiceDomicile
    {
        public ServiceDomicile(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Domicile> VillesOrdonnées()
        {
             IEnumerable < Domicile > liste = this.GetAll()
            .OrderBy(d => d.MyDomiciliations.Select(dom => dom.MyCitoyen).Count())
            .Reverse();

            return liste.ToList();


        }
    }
}
