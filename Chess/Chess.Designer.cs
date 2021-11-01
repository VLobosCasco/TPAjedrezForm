
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.labelTablero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablero n° ";
            // 
            // btn_fatales
            // 
            this.btn_fatales.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fatales.Location = new System.Drawing.Point(46, 390);
            this.btn_fatales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fatales.Name = "btn_fatales";
            this.btn_fatales.Size = new System.Drawing.Size(154, 52);
            this.btn_fatales.TabIndex = 1;
            this.btn_fatales.Text = "Filtrar casillas fatales";
            this.btn_fatales.UseVisualStyleBackColor = true;
            this.btn_fatales.Click += new System.EventHandler(this.btn_fatales_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(215, 390);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(142, 52);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Próximo tablero";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(703, 15);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // labelTablero
            // 
            this.labelTablero.AutoSize = true;
            this.labelTablero.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablero.Location = new System.Drawing.Point(152, 6);
            this.labelTablero.Name = "labelTablero";
            this.labelTablero.Size = new System.Drawing.Size(25, 29);
            this.labelTablero.TabIndex = 5;
            this.labelTablero.Text = "1";
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.labelTablero);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_fatales);
            this.Controls.Add(this.label1);
            this.Name = "Chess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fatales;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label labelTablero;
    }
}