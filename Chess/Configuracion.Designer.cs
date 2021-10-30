
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloConfiguracion
            // 
            this.tituloConfiguracion.AutoSize = true;
            this.tituloConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.tituloConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tituloConfiguracion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloConfiguracion.Location = new System.Drawing.Point(125, 207);
            this.tituloConfiguracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloConfiguracion.Name = "tituloConfiguracion";
            this.tituloConfiguracion.Size = new System.Drawing.Size(863, 49);
            this.tituloConfiguracion.TabIndex = 0;
            this.tituloConfiguracion.Text = "¡SE ENCONTRARON TODOS LOS TABLEROS!";
            // 
            // volverMainMenubtn
            // 
            this.volverMainMenubtn.BackColor = System.Drawing.Color.Transparent;
            this.volverMainMenubtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverMainMenubtn.Location = new System.Drawing.Point(41, 569);
            this.volverMainMenubtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volverMainMenubtn.Name = "volverMainMenubtn";
            this.volverMainMenubtn.Size = new System.Drawing.Size(229, 109);
            this.volverMainMenubtn.TabIndex = 1;
            this.volverMainMenubtn.Text = "Volver al menu";
            this.volverMainMenubtn.UseVisualStyleBackColor = false;
            this.volverMainMenubtn.Click += new System.EventHandler(this.volverMainMenubtn_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_salir.Location = new System.Drawing.Point(899, 571);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(247, 109);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Exit";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.volverMainMenubtn);
            this.Controls.Add(this.tituloConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloConfiguracion;
        private System.Windows.Forms.Button volverMainMenubtn;
        private System.Windows.Forms.Button btn_salir;
    }
}