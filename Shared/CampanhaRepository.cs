using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public class CampanhaRepository : ICampanhaRepository
    {
        private readonly List<Campanha> _campanha = new List<Campanha>
        {
        };

        public IEnumerable<Campanha> GetAll()
        {
            return _campanha.Select(campanha => campanha);
        }

        public Campanha GetCampanhaByUser(string email)
        {
            var campanha = _campanha.Where(campanha => campanha.Usuario == email).FirstOrDefault();

            if (campanha != null)
                return campanha;

            else
                return null;
        }

        public void AddCampanha(Campanha campanha)
        {
            _campanha.Add(campanha);
        }
    }
}
