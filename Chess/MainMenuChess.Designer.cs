
namespace Chess
{
    partial class MainMenuChess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuChess));
            this.Titulo = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.Configuracionbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.Location = new System.Drawing.Point(385, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(288, 72);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Problema del tablero \r\n         de Ajedrez";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startbtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startbtn.Location = new System.Drawing.Point(78, 400);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(123, 38);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // Configuracionbtn
            // 
            this.Configuracionbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Configuracionbtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracionbtn.Location = new System.Drawing.Point(33, 335);
            this.Configuracionbtn.Name = "Configuracionbtn";
            this.Configuracionbtn.Size = new System.Drawing.Size(208, 40);
            this.Configuracionbtn.TabIndex = 2;
            this.Configuracionbtn.Text = "CONFIGURACIÓN";
            this.Configuracionbtn.UseVisualStyleBackColor = false;
            this.Configuracionbtn.Click += new System.EventHandler(this.Configuracionbtn_Click);
            // 
            // MainMenuChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 480);
            this.Controls.Add(this.Configuracionbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.Titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuChess";
            this.Text = "MainMenuChess";
            this.Load += new System.EventHandler(this.MainMenuChess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button Configuracionbtn;
    }
}