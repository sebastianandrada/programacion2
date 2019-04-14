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
                if (binario[i] == '1'|| binario[i] == '0')
                {
                    sum = sum + Math.Pow(2, (binario.Length - (i + 1)));
                } else
                {
                    valido = false;
                    break;
                }
            }
            return valido ? sum.ToString() : "Valor invalido";
        }

        public string DecimalBinario(double numero)
        {
            string rdo = string.Empty;
            double resto = 0;
            while (numero > 0)
            {
                resto = numero % 2;
                numero = numero / 2;
                rdo = resto.ToString() + rdo;
            }
            return rdo;
        }

        public string DecimalNumero(string numero)
        {
            string rdo = string.Empty;
            if (double.TryParse(numero, out double valor))
            {
                rdo = this.DecimalBinario(valor);
            } else
            {
                rdo = "Valor invalido";
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
            /*if(double.TryParse(strNumero, out double ret))
            {
                return ret;
            } else
            {
                return 0;
            }*/
            return double.TryParse(strNumero, out double ret) ? ret : 0;
        }

        public double GetNumero()
        {
            return this.numero;
        }
    }
}
