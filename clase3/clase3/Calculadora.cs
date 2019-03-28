using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3
{
    class Calculadora
    {
        public static int Calcular(int num1, int num2, string operacion)
        {
            int resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }

        private static bool Validar(int num)
        {
            return num != 0;
        }
    }
}
