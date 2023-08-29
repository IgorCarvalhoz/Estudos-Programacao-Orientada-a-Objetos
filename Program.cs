using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using ExemploEncapsulamento;
using ExemploEncapsulamento.Models;
using Exemplos.Interfaces;
using Exemplos.Models;

//Exemplo Herança
Aluno a1 = new Aluno("Igor Carvalho");
a1.Idade = 24;
a1.Nota = 7.45;
a1.Apresentar();

Professor p1 = new Professor("Leonardo Buta");
p1.Idade = 20;
p1.Salario = 10000M;
p1.Apresentar();



//Exemplo Classe Abstrata (Polimorfismo)
Corrente cc1 = new Corrente();
cc1.Creditar(700);
cc1.ExibirSaldo();



//Exemplo Encapsulamento
ContaCorrente conta1 = new ContaCorrente(02017, 1000);
conta1.ExibirSaldo();
conta1.Sacar(700);
conta1.ExibirSaldo();


/*Instanciando interface - Por padrão as interfaces não podem ser instanciadas, porem podemos instanciar
uma classe onde a interface já foi implementada,
*/
//Interface             //Classe com interface implementada
ICalculadora calc = new Calculadora();
//Chamando a funação Multilplicar da interface instanciada pela classe
Console.WriteLine(calc.Multiplicar(3, 6));