using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            switch (operador) {
                case "+":
                case "-":
                case "/":
                case "*":
                    return operador;
                default:
                    return "+";
            }
        }

        /*public double Operar(Numero num1, Numero num2, string operador)
        {
            string opAux = ValidarOperador(operador);
            double resultado;
            switch (opAux)
            {
                case "+":
                    resultado = num1 + num2;
            }
        }*/
    }
}
