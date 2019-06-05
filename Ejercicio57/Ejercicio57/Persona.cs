using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            
        }

        public static void Guardar(Persona p)
        {
            XmlTextWriter w = new XmlTextWriter("D:\\VisualStudio\\andrada-sebastian\\Ejercicio57\\xmltest.xml", Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            //w.WriteStartElement("Persona");
            //w.WriteString()
            ser.Serialize(w, p);

            w.Close();
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}, apellido: {1}", this.nombre, this.apellido);
        }
    }
}
