using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    public class ContaCorrente
    {
        //Construtor, coloca tudo na mesma linha
        public ContaCorrente(int conta, decimal saldoInicial)
        {
            Conta = conta;
            Saldo = saldoInicial;
        }
        //Numero da conta bancária
        public int Conta { get; set; }
        //Saldo encapsulado, somento a classe tem acesso
        private decimal Saldo;
        
        //Pega o valor do saldo encapsulado, verifica se há saldo suficiente e realiza a operação de saque
        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor;
            }
            else{
                Console.WriteLine("Valor de saque excede o saldo, não foi possivel realiza-lo");
            }
        }
        //Torna o saldo encapsulado publico
        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de {Saldo}");
        }
    }
}