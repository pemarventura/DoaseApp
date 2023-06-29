using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared.Classes
{
    public class Campanha
    {
        public string Criador { get; set; }
        public string NomeCampanha { get; set; }
        public string Objetivos { get; set; }
        public List<DoacoesRequisitadas> DoacoesRequisitadas { get; set; } = new List<DoacoesRequisitadas> { };
        public string Usuario { get; set; }
    }
}
