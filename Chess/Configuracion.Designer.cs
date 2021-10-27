
namespace Chess
{
    partial class Configuracion
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
            this.tituloConfiguracion = new System.Windows.Forms.Label();
            this.volverMainMenubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloConfiguracion
            // 
            this.tituloConfiguracion.AutoSize = true;
            this.tituloConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.tituloConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tituloConfiguracion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloConfiguracion.Location = new System.Drawing.Point(265, 21);
            this.tituloConfiguracion.Name = "tituloConfiguracion";
            this.tituloConfiguracion.Size = new System.Drawing.Size(234, 33);
            this.tituloConfiguracion.TabIndex = 0;
            this.tituloConfiguracion.Text = "CONFIGURACIÓN";
            // 
            // volverMainMenubtn
            // 
            this.volverMainMenubtn.BackColor = System.Drawing.Color.Transparent;
            this.volverMainMenubtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverMainMenubtn.Location = new System.Drawing.Point(615, 384);
            this.volverMainMenubtn.Name = "volverMainMenubtn";
            this.volverMainMenubtn.Size = new System.Drawing.Size(158, 39);
            this.volverMainMenubtn.TabIndex = 1;
            this.volverMainMenubtn.Text = "Volver al Menu ";
            this.volverMainMenubtn.UseVisualStyleBackColor = false;
            this.volverMainMenubtn.Click += new System.EventHandler(this.volverMainMenubtn_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volverMainMenubtn);
            this.Controls.Add(this.tituloConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloConfiguracion;
        private System.Windows.Forms.Button volverMainMenubtn;
    }
}