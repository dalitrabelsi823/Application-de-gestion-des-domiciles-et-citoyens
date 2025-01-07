using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class ServiceCitoyen : Service<Citoyen>, IServiceCitoyen
    {
        public ServiceCitoyen(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public float pourcentageJeune()
        {
            IEnumerable<Citoyen> listJeune = this.GetMany(c=>c.DateNaissance.Year>1989 && c.DateNaissance.Year <2006 );
            IEnumerable<Citoyen> listTotal = this.GetAll();

            int totalJeune = listJeune.Count();
            int totalCitoyen = listTotal.Count();

            return (totalCitoyen != 0) ? (totalJeune / totalCitoyen) * 100 : 0;
            
        }

        public float pourcentageNonEduqués()
        {
            IEnumerable<Citoyen> listNonEduqués = this.GetMany(c => c.MyEducation==Education.Aucun);
            IEnumerable<Citoyen> listTotal = this.GetAll();

            int totalNonEduqués = listNonEduqués.Count();
            int totalCitoyen = listTotal.Count();

            return(totalCitoyen != 0) ? (totalNonEduqués / totalCitoyen) * 100 : 0;
        }
    }
}
