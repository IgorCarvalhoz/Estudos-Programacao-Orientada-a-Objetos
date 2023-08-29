using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario {get;set;}

        //Sobrescreve o metodo aprsentar
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome}, tenho {Idade} anos e meu salário é de {Salario}");
        }
    }
}