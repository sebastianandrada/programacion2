using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado }


        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region "Constructor"
        public Alumno() { }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma):base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;   
        }
        #endregion
        
        #region "Operadores"
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        #endregion

        #region "Sobrecargas"
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Clases que toma: {0}\n", this.claseQueToma.ToString());
            sb.AppendFormat("Estado de cuenta: {0}\n", this.estadoCuenta.ToString());
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return String.Format("TOMA CLASE DE {0}\n", this.claseQueToma.ToString());
        }

        public override string ToString()
        {
            return String.Format("clase que toma {0}, estado de la cuenta: {1}\n", this.claseQueToma.ToString(), this.estadoCuenta.ToString());
        }
        #endregion
    }
}
