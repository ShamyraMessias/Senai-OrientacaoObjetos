using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Cliente
    {
        string Nome { get; set; }
        string Cpf { get; set; }    
        Debito Debito { get; set; }
        Credito Credito { get; set; }
    }
}
