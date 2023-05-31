using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared.Classes
{
    public class DoacoesRequisitadas
    {
        public Item Item { get; set; } 
        public int QuantidadePedida { get; set; }
        public int QuantidadeArrecadada { get; set; }
        public decimal ValorPedido { get; set; }
        public decimal ValorArrecadado { get; set; }

    }
}
