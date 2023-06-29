using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public interface ICampanhaRepository
    {
        IEnumerable<Campanha> GetAll();
        Campanha GetCampanhaByUser(string email);
        void AddCampanha(Campanha campanha);
    }
}
