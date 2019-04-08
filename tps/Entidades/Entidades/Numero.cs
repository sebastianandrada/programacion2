using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        private double ValidarNumero(string strNumero)
        {
            int aux; double retorno;
            if(int.TryParse(strNumero, out aux))
            {
                retorno = aux;
            } else
            {
                retorno = 0;
            }
            return retorno;
        }

        private void SetNumero(string strNum)
        {
            this.numero = ValidarNumero(strNum);
        }

        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            int sum = 0;

            for(int i = 0; i<array.Length; i++)
            {
                if(array[i] == '1')
                {
                    if(i == 0)
                    {
                        sum += 1;
                    } else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
            }
            return sum.ToString();
        }


    }
}
