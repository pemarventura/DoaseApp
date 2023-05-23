using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DoaseApp.Shared.Enums
{
    public enum AreasEmpreendimento
    {
        [Description("Vendas")]
        Vendas,

        [Description("Marketing")]
        Marketing,

        [Description("Recursos Humanos")]
        RecursosHumanos,

        [Description("Finanças")]
        Financas,

        [Description("Tecnologia")]
        Tecnologia,

        [Description("Produção")]
        Producao,

        [Description("Logística")]
        Logistica,

        [Description("Serviços Sociais")]
        ServicosSociais
    }
}
