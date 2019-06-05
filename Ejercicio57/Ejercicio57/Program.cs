using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                XmlTextReader reader = new XmlTextReader("D:\\VisualStudio\\andrada-sebastian\\Ejercicio57\\xmltest.xml");
                XmlSerializer ser = new XmlSerializer(typeof(Persona));

                Persona persona = new Persona("sebastian", "andrada");
                Persona.Guardar(persona);

                Persona nuevaPersona;
                nuevaPersona = (Persona)ser.Deserialize(reader);

                Console.WriteLine(nuevaPersona.ToString());

                reader.Close();
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
