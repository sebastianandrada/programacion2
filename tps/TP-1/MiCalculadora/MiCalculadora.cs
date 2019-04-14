﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text.Equals(string.Empty) || this.txtNumero2.Text.Equals(string.Empty) || this.cmbOperador.Text.Equals(string.Empty))
            {
                MessageBox.Show("Noooo!");
            } else
            {
                double rdo = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                this.lblResultado.Text = rdo.ToString();
            }
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
            return Calculadora.Operar(n1, n2, operador);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = "1231531";
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = "0000101";
        }
    }
}