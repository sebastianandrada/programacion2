using System;
using static CentralitaHerencia.Provincial;

namespace TestForm
{
    partial class FrmLlamador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(68, 28);
            this.txtNroDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(335, 38);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.btnNumeral);
            this.groupBoxPanel.Controls.Add(this.btnCero);
            this.groupBoxPanel.Controls.Add(this.btnAsterisco);
            this.groupBoxPanel.Controls.Add(this.btn9);
            this.groupBoxPanel.Controls.Add(this.btn8);
            this.groupBoxPanel.Controls.Add(this.btn7);
            this.groupBoxPanel.Controls.Add(this.btn6);
            this.groupBoxPanel.Controls.Add(this.btn5);
            this.groupBoxPanel.Controls.Add(this.btn4);
            this.groupBoxPanel.Controls.Add(this.btn3);
            this.groupBoxPanel.Controls.Add(this.btn2);
            this.groupBoxPanel.Controls.Add(this.btn1);
            this.groupBoxPanel.Location = new System.Drawing.Point(31, 84);
            this.groupBoxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPanel.Size = new System.Drawing.Size(230, 267);
            this.groupBoxPanel.TabIndex = 1;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(165, 162);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 40);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(84, 162);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 40);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(8, 162);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 40);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(165, 101);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 40);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(84, 101);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(8, 101);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(165, 36);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(84, 36);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(8, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(288, 103);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(211, 45);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(288, 154);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(211, 45);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(288, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(288, 206);
            this.txtNroOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(210, 38);
            this.txtNroOrigen.TabIndex = 5;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // cmbFranja
            // 
            this.cmbFranja.BackColor = System.Drawing.SystemColors.Control;
            this.cmbFranja.DataSource = new CentralitaHerencia.Provincial.Franja[] {
        CentralitaHerencia.Provincial.Franja.Franja_1,
        CentralitaHerencia.Provincial.Franja.Franja_2,
        CentralitaHerencia.Provincial.Franja.Franja_3};
            this.cmbFranja.Items.AddRange(new object[] {
            CentralitaHerencia.Provincial.Franja.Franja_1,
            CentralitaHerencia.Provincial.Franja.Franja_2,
            CentralitaHerencia.Provincial.Franja.Franja_3});
            this.cmbFranja.Location = new System.Drawing.Point(39, 392);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(412, 24);
            this.cmbFranja.TabIndex = 6;
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(8, 220);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(50, 40);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(84, 220);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(50, 40);
            this.btnCero.TabIndex = 10;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(165, 220);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(50, 40);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 455);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.txtNroDestino);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLlamador";
            this.Text = "Llamador";
            this.groupBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnAsterisco;
    }
}