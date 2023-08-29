using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplos.Interfaces;

namespace Exemplos.Models
{
    // Implementando a interface
    public class Calculadora : ICalculadora
    {
        // Implementando os metodos obrigatorios da interface.
        public int Somar (int numero1, int numero2){

            return numero1 + numero2;
        }

        public int Subtrair (int numero1, int numero2){

            return numero1 - numero2;
        }

        public int Dividir (int numero1, int numero2){

            return numero1 / numero2;
        }

        public int Multiplicar (int numero1, int numero2){

            return numero1 * numero2;

        }
    }
}


