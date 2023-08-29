using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Models
{
    public class Aluno : Pessoa 
    {
        public double Nota {get; set;}
        public Aluno (string nome) : base(nome){
            
        }


        //Sobrescreve o metodo apresentar
        public override void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} e minha nota é {Nota}");
        }
    }
    
}