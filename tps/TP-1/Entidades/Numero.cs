using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set {
                this.numero = ValidarNumero(value);
            }
        }

        public string BinarioDecimal(string binario)
        {
            bool valido = true;
            double sum = 0;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    sum = sum + Math.Pow(2, (binario.Length - (i + 1)));
                } else if(binario[i] != '0')
                {
                    valido = false;
                    break;
                }
            }
            return valido ? sum.ToString() : "Valor invalido";
        }

        public string DecimalBinario(string numero)
        {
            string rdo = string.Empty;
            if (double.TryParse(numero, out double valor))
            {
                rdo = this.DecimalBinario(valor);
            }
            else
            {
                rdo = "Valor invalido";
            }
            return rdo;
        }

        public string DecimalBinario(double numero)
        {
            string rdo = string.Empty;
            int enteroAbs = Math.Abs((int)numero);
            while (enteroAbs > 0)
            {
                rdo = (enteroAbs % 2).ToString() + rdo;
                enteroAbs = enteroAbs / 2;
            }
            return rdo;
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            return numero1.numero / numero2.numero;
        }

        private static double ValidarNumero(string strNumero)
        {
            return double.TryParse(strNumero, out double ret) ? ret : 0;
        }

        public double GetNumero()
        {
            return this.numero;
        }
    }
}
