using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private Random random;

        #region "Constructores"
        public Profesor(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(legajo, nombre, apellido, dni, nacionalidad)
        {
        }
        #endregion

        #region "Metodos"

        private void _randomClases()
        {

        }

        protected string MostrarDatos()
        {
            return "";
        }

        protected override string ParticiparEnClase()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator !=(Profesor i, Universidad.EClases clases)
        {
            return true;
        }

        public static bool operator ==(Profesor i, Universidad.EClases clases)
        {
            return !(i == clases);
        }
        #endregion
    }
}
