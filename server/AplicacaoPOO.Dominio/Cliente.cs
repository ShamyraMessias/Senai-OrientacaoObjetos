using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Cliente
    {
        public string  Nome { get; set; }
        private string Cpf { get; set; }
        public double  SaldoInicial  { get; set; }
        public Debito Debito { get; set; }
        public Credito Credito { get; set; }
    }
}
