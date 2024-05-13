namespace PryLedoEtapa5
{
    partial class Form1
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
            this.BtnVehiculosAleatorios = new System.Windows.Forms.Button();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.LblBarco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVehiculosAleatorios
            // 
            this.BtnVehiculosAleatorios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnVehiculosAleatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculosAleatorios.Location = new System.Drawing.Point(141, 471);
            this.BtnVehiculosAleatorios.Name = "BtnVehiculosAleatorios";
            this.BtnVehiculosAleatorios.Size = new System.Drawing.Size(559, 46);
            this.BtnVehiculosAleatorios.TabIndex = 0;
            this.BtnVehiculosAleatorios.Text = "CREAR";
            this.BtnVehiculosAleatorios.UseVisualStyleBackColor = false;
            this.BtnVehiculosAleatorios.Click += new System.EventHandler(this.BtnVehiculosAleatorios_Click);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(29, 9);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(35, 13);
            this.lblAuto.TabIndex = 1;
            this.lblAuto.Text = "label1";
            this.lblAuto.Visible = false;
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Location = new System.Drawing.Point(283, 9);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(35, 13);
            this.lblAvion.TabIndex = 2;
            this.lblAvion.Text = "label1";
            this.lblAvion.Visible = false;
            // 
            // LblBarco
            // 
            this.LblBarco.AutoSize = true;
            this.LblBarco.Location = new System.Drawing.Point(536, 9);
            this.LblBarco.Name = "LblBarco";
            this.LblBarco.Size = new System.Drawing.Size(35, 13);
            this.LblBarco.TabIndex = 3;
            this.LblBarco.Text = "label1";
            this.LblBarco.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 529);
            this.Controls.Add(this.LblBarco);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.BtnVehiculosAleatorios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gneracion de Vehiculos Aleatoriamente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVehiculosAleatorios;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.Label LblBarco;
    }
}

