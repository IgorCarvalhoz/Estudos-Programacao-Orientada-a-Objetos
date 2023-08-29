using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email {get; set;}

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }


        /* No metodo sempre passar os parametros criados fora do construtor
        Exemplo para o metodos o "nome" não existe mesmo que esteja no construtor
        O metodo só enxergo o Nome que esta declarado fora do construtor*/


        //Virtual indica que o metodo pode ser sobrescrito em outra classe
        public virtual void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}