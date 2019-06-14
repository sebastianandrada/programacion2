namespace MainCorreo
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEstados = new System.Windows.Forms.GroupBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.groupBoxEstados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEstados
            // 
            this.groupBoxEstados.Controls.Add(this.lblEstadoEntregado);
            this.groupBoxEstados.Controls.Add(this.lblEstadoEnViaje);
            this.groupBoxEstados.Controls.Add(this.lstEstadoEntregado);
            this.groupBoxEstados.Controls.Add(this.lstEstadoEnViaje);
            this.groupBoxEstados.Controls.Add(this.lblEstadoIngresado);
            this.groupBoxEstados.Controls.Add(this.lstEstadoIngresado);
            this.groupBoxEstados.Location = new System.Drawing.Point(13, 13);
            this.groupBoxEstados.Name = "groupBoxEstados";
            this.groupBoxEstados.Size = new System.Drawing.Size(1007, 306);
            this.groupBoxEstados.TabIndex = 0;
            this.groupBoxEstados.TabStop = false;
            this.groupBoxEstados.Text = "Estados Paquetes";
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 16;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(32, 57);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(292, 228);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(32, 34);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(71, 17);
            this.lblEstadoIngresado.TabIndex = 1;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 16;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(359, 57);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(292, 228);
            this.lstEstadoEnViaje.TabIndex = 2;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 16;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(690, 57);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(292, 228);
            this.lstEstadoEntregado.TabIndex = 3;
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(359, 34);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(60, 17);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(690, 34);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(74, 17);
            this.lblEstadoEntregado.TabIndex = 5;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarTodos);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblTrackingID);
            this.groupBox1.Controls.Add(this.maskTxtTrackingID);
            this.groupBox1.Location = new System.Drawing.Point(602, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquete";
            // 
            // maskTxtTrackingID
            // 
            this.maskTxtTrackingID.Location = new System.Drawing.Point(6, 52);
            this.maskTxtTrackingID.Name = "maskTxtTrackingID";
            this.maskTxtTrackingID.Size = new System.Drawing.Size(203, 22);
            this.maskTxtTrackingID.TabIndex = 0;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(6, 29);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(80, 17);
            this.lblTrackingID.TabIndex = 1;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(241, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(241, 91);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(170, 45);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEstados);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Andrada.Sebastian.2C";
            this.groupBoxEstados.ResumeLayout(false);
            this.groupBoxEstados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstados;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.MaskedTextBox maskTxtTrackingID;
    }
}

