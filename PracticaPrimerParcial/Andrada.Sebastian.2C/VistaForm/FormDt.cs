using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDt : Form
    {
        private DirectorTecnico dt; 

        public FormDt()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(this.txtNombre.ToString(), this.txtApellido.ToString(), int.Parse(this.txtEdad.ToString()), int.Parse(this.txtDni.ToString()), int.Parse(this.txtExperiencia.ToString()));
            MessageBox.Show("Se ha creado el DT", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
