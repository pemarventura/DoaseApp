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

        public Campanha GetCampanhaByUser(string user)
        {
            var campanha = _campanha.Where(campanha => campanha.Criador == user).FirstOrDefault();

            return campanha;
        }

        public void AddCampanha(Campanha campanha)
        {
            _campanha.Add(campanha);
        }
    }
}
