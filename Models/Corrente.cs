using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Corrente : ContaClasseAbstrata
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}