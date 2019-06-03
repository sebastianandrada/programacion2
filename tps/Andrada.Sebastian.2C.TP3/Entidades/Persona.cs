using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region "Propiedades"
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(nacionalidad, dato: value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region "Constructores"
        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            //this.dni = ValidarDni(nacionalidad, dni);
            int dniNumber;
            if (int.TryParse(dni, out dniNumber))
            {
                this.dni = dniNumber;
            }
        }
        #endregion

        #region "Sobrecargas"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}\n", this.apellido);
            sb.AppendFormat("Nacionalidad: {0}\n", this.nacionalidad.ToString());
            sb.AppendFormat("DNI: {0}\n", this.dni);
            return sb.ToString();
        }
        #endregion

        #region "Metodos"
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if ((nacionalidad == ENacionalidad.Argentino && dato < 89999999) || (nacionalidad == ENacionalidad.Extranjero && dato > 90000000 && dato < 99999999))
            {
                return dato;
            }
            else
            {
                //TODO:reemplazar por custom exceptions
                throw new Exception();
            }
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if (/*TODO:Validaciones con regex cantidad de caracteres, letras*/true)
            {
                if (int.TryParse(dato, out dni))
                {
                    dni = this.ValidarDni(nacionalidad, dni);
                }
            }
            else
            {
                //TODO: Reemplazar por customs exceptions
                throw new Exception();
            }

            return dni;
        }

        private string ValidarNombreApellido(string dato)
        {
            if (/*realizar validaciones con regex caracteres validos*/true)
            {
                return dato;
            }
            else
            {
                //TODO: reemplazar por customs exceptions
            }
        }
        #endregion
    }
}
