using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public abstract class ContaClasseAbstrata
    {
        protected decimal Saldo;
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine ($"Saldo: {Saldo}");
        }
    }
}