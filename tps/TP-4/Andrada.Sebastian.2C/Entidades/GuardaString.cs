using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool resultado = false;
            string path = String.Format("{0}\\{1}", (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), archivo);
            StreamWriter sw = new StreamWriter(path, true);
            
            try
            {
                sw.WriteLine(texto);
                resultado = true;
            }
            catch(Exception e)
            {
                throw new Exception("Error al escribir el archivo!!", e);
            }
            finally
            {
                sw.Close();
            }
            return resultado;
        }
    }
}
