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
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(51, 23);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(252, 32);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Location = new System.Drawing.Point(23, 68);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(192, 170);
            this.groupBoxPanel.TabIndex = 1;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 281);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.txtNroDestino);
            this.Name = "FrmLlamador";
            this.Text = "FrmLlamador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox groupBoxPanel;
    }
}