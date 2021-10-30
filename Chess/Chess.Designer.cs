
namespace Chess
{
    partial class Chess
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fatales = new System.Windows.Forms.Button();
            this.btn_proximoTablero = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablero n° ";
            // 
            // btn_fatales
            // 
            this.btn_fatales.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fatales.Location = new System.Drawing.Point(69, 600);
            this.btn_fatales.Name = "btn_fatales";
            this.btn_fatales.Size = new System.Drawing.Size(231, 80);
            this.btn_fatales.TabIndex = 1;
            this.btn_fatales.Text = "Filtrar casillas fatales";
            this.btn_fatales.UseVisualStyleBackColor = true;
            this.btn_fatales.Click += new System.EventHandler(this.btn_fatales_Click);
            // 
            // btn_proximoTablero
            // 
            this.btn_proximoTablero.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximoTablero.Location = new System.Drawing.Point(317, 600);
            this.btn_proximoTablero.Name = "btn_proximoTablero";
            this.btn_proximoTablero.Size = new System.Drawing.Size(238, 80);
            this.btn_proximoTablero.TabIndex = 2;
            this.btn_proximoTablero.Text = "Proximo Tablero";
            this.btn_proximoTablero.UseVisualStyleBackColor = true;
            this.btn_proximoTablero.Click += new System.EventHandler(this.btn_proximoTablero_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(277, 19);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(161, 37);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar Tableros";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_proximoTablero);
            this.Controls.Add(this.btn_fatales);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fatales;
        private System.Windows.Forms.Button btn_proximoTablero;
        private System.Windows.Forms.Button btn_generar;
    }
}