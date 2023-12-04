
namespace pryPPT
{
    partial class frmPpt
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
            this.pctJugador = new System.Windows.Forms.PictureBox();
            this.pctCPU = new System.Windows.Forms.PictureBox();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.lblJugadorelige = new System.Windows.Forms.Label();
            this.lblCPUelige = new System.Windows.Forms.Label();
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.lblPuntuacionjugador = new System.Windows.Forms.Label();
            this.lblPuntuacionCPU = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblScoreusuario = new System.Windows.Forms.Label();
            this.lblScoreCPU = new System.Windows.Forms.Label();
            this.lblGanadas = new System.Windows.Forms.Label();
            this.lblEmpatadas = new System.Windows.Forms.Label();
            this.lblPerdidas = new System.Windows.Forms.Label();
            this.lblJugadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pctJugador
            // 
            this.pctJugador.Image = global::pryPPT.Properties.Resources.Titulo;
            this.pctJugador.Location = new System.Drawing.Point(89, 87);
            this.pctJugador.Name = "pctJugador";
            this.pctJugador.Size = new System.Drawing.Size(155, 150);
            this.pctJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctJugador.TabIndex = 0;
            this.pctJugador.TabStop = false;
            // 
            // pctCPU
            // 
            this.pctCPU.Image = global::pryPPT.Properties.Resources.Titulo;
            this.pctCPU.Location = new System.Drawing.Point(551, 87);
            this.pctCPU.Name = "pctCPU";
            this.pctCPU.Size = new System.Drawing.Size(155, 150);
            this.pctCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCPU.TabIndex = 1;
            this.pctCPU.TabStop = false;
            // 
            // btnPiedra
            // 
            this.btnPiedra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiedra.Location = new System.Drawing.Point(197, 368);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(105, 41);
            this.btnPiedra.TabIndex = 2;
            this.btnPiedra.Text = "Piedra";
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // lblJugadorelige
            // 
            this.lblJugadorelige.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorelige.Location = new System.Drawing.Point(88, 43);
            this.lblJugadorelige.Name = "lblJugadorelige";
            this.lblJugadorelige.Size = new System.Drawing.Size(158, 30);
            this.lblJugadorelige.TabIndex = 5;
            this.lblJugadorelige.Text = "Jugador elige: ";
            // 
            // lblCPUelige
            // 
            this.lblCPUelige.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUelige.Location = new System.Drawing.Point(550, 43);
            this.lblCPUelige.Name = "lblCPUelige";
            this.lblCPUelige.Size = new System.Drawing.Size(158, 30);
            this.lblCPUelige.TabIndex = 6;
            this.lblCPUelige.Text = "CPU elige: ";
            // 
            // btnTijera
            // 
            this.btnTijera.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTijera.Location = new System.Drawing.Point(512, 368);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(105, 41);
            this.btnTijera.TabIndex = 7;
            this.btnTijera.Text = "Tijera";
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Location = new System.Drawing.Point(355, 368);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(105, 41);
            this.btnPapel.TabIndex = 8;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // lblPuntuacionjugador
            // 
            this.lblPuntuacionjugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuntuacionjugador.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblPuntuacionjugador.Location = new System.Drawing.Point(87, 284);
            this.lblPuntuacionjugador.Name = "lblPuntuacionjugador";
            this.lblPuntuacionjugador.Size = new System.Drawing.Size(195, 23);
            this.lblPuntuacionjugador.TabIndex = 9;
            // 
            // lblPuntuacionCPU
            // 
            this.lblPuntuacionCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuntuacionCPU.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionCPU.Location = new System.Drawing.Point(548, 284);
            this.lblPuntuacionCPU.Name = "lblPuntuacionCPU";
            this.lblPuntuacionCPU.Size = new System.Drawing.Size(195, 23);
            this.lblPuntuacionCPU.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblResultado.Location = new System.Drawing.Point(328, 70);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(157, 23);
            this.lblResultado.TabIndex = 11;
            // 
            // lblScoreusuario
            // 
            this.lblScoreusuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreusuario.Location = new System.Drawing.Point(69, 240);
            this.lblScoreusuario.Name = "lblScoreusuario";
            this.lblScoreusuario.Size = new System.Drawing.Size(177, 23);
            this.lblScoreusuario.TabIndex = 12;
            this.lblScoreusuario.Text = "Puntuacion usuario: ";
            // 
            // lblScoreCPU
            // 
            this.lblScoreCPU.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCPU.Location = new System.Drawing.Point(544, 240);
            this.lblScoreCPU.Name = "lblScoreCPU";
            this.lblScoreCPU.Size = new System.Drawing.Size(162, 23);
            this.lblScoreCPU.TabIndex = 13;
            this.lblScoreCPU.Text = "Puntuacion CPU: ";
            // 
            // lblGanadas
            // 
            this.lblGanadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGanadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanadas.Location = new System.Drawing.Point(320, 169);
            this.lblGanadas.Name = "lblGanadas";
            this.lblGanadas.Size = new System.Drawing.Size(165, 23);
            this.lblGanadas.TabIndex = 15;
            // 
            // lblEmpatadas
            // 
            this.lblEmpatadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpatadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpatadas.Location = new System.Drawing.Point(320, 205);
            this.lblEmpatadas.Name = "lblEmpatadas";
            this.lblEmpatadas.Size = new System.Drawing.Size(165, 23);
            this.lblEmpatadas.TabIndex = 16;
            // 
            // lblPerdidas
            // 
            this.lblPerdidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerdidas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdidas.Location = new System.Drawing.Point(320, 240);
            this.lblPerdidas.Name = "lblPerdidas";
            this.lblPerdidas.Size = new System.Drawing.Size(165, 23);
            this.lblPerdidas.TabIndex = 17;
            // 
            // lblJugadas
            // 
            this.lblJugadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJugadas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadas.Location = new System.Drawing.Point(320, 132);
            this.lblJugadas.Name = "lblJugadas";
            this.lblJugadas.Size = new System.Drawing.Size(165, 23);
            this.lblJugadas.TabIndex = 18;
            // 
            // frmPpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJugadas);
            this.Controls.Add(this.lblPerdidas);
            this.Controls.Add(this.lblEmpatadas);
            this.Controls.Add(this.lblGanadas);
            this.Controls.Add(this.lblScoreCPU);
            this.Controls.Add(this.lblScoreusuario);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPuntuacionCPU);
            this.Controls.Add(this.lblPuntuacionjugador);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.lblCPUelige);
            this.Controls.Add(this.lblJugadorelige);
            this.Controls.Add(this.btnPiedra);
            this.Controls.Add(this.pctCPU);
            this.Controls.Add(this.pctJugador);
            this.Name = "frmPpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPT";
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctJugador;
        private System.Windows.Forms.PictureBox pctCPU;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Label lblJugadorelige;
        private System.Windows.Forms.Label lblCPUelige;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Label lblPuntuacionjugador;
        private System.Windows.Forms.Label lblPuntuacionCPU;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblScoreusuario;
        private System.Windows.Forms.Label lblScoreCPU;
        private System.Windows.Forms.Label lblGanadas;
        private System.Windows.Forms.Label lblEmpatadas;
        private System.Windows.Forms.Label lblPerdidas;
        private System.Windows.Forms.Label lblJugadas;
    }
}

