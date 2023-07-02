using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public void UpdateCampanha(Campanha campanha)
        {
            Campanha campanhaUpdate = _campanha.Where(a => a.Usuario == campanha.Usuario).FirstOrDefault();

            foreach (DoacoesRequisitadas doacaoRealizada in campanha.DoacoesRequisitadas)
            {
                DoacoesRequisitadas doacaoRequisitada = campanhaUpdate.DoacoesRequisitadas.Where(a => a.Item.NomeItem == doacaoRealizada.Item.NomeItem).FirstOrDefault();

                if (doacaoRequisitada != null)
                {
                    doacaoRequisitada.QuantidadeArrecadada += doacaoRealizada.QuantidadeArrecadada;
                }
            }
        }
    }
}
