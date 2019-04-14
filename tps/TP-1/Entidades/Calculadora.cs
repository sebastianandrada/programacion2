using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero2.Equals(new Numero(0)) ? double.MinValue : numero1 / numero2;
                    break;
            }
            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            return operador == "+" || operador == "-" || operador == "*" || operador == "/" ? operador : "+";
        }
    }
}
