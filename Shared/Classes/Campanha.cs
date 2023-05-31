using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared.Classes
{
    public class Campanha
    {
        public string Criador { get; }
        public string NomeCampanha { get; }
        public string Objetivos { get; }
        public List<DoacoesRequisitadas> DoacoesRequisitadas { get; set; }

    }
}
