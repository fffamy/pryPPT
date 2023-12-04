using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPPT
{
    public partial class frmPpt : Form
    {
        public frmPpt()
        {
            InitializeComponent();
        }

        Random obj = new Random();
        Int32 contadorJugador = 0;
        Int32 contadorCPU = 0;
        Int32 contadorJugadas = 0;
        Int32 contadorGanadas = 0;
        Int32 contadorEmpates = 0;
        Int32 contadorDerrotas = 0;

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            pctJugador.Image = pryPPT.Properties.Resources.piedra;
            Int32 CPUelige = obj.Next(1 , 4);
            
           switch (CPUelige)
           {
                case 1:
                    pctCPU.Image = pryPPT.Properties.Resources.piedra;
                    lblResultado.Text = "Empate!";
                    contadorEmpates = contadorEmpates + 1;
                    contadorJugadas = contadorJugadas + 1;
                    break;
                
                case 2:
                    pctCPU.Image = pryPPT.Properties.Resources.Papel;
                    lblResultado.Text = "Perdiste :(";
                    contadorCPU = contadorCPU + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorDerrotas = contadorDerrotas + 1;
                    break;

                case 3:
                    pctCPU.Image = pryPPT.Properties.Resources.Tijera;
                    lblResultado.Text = "Ganaste!";
                    contadorJugador = contadorJugador + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorGanadas = contadorGanadas + 1;
                    break;
           }
           lblPuntuacionjugador.Text = contadorJugador.ToString();
           lblPuntuacionCPU.Text = contadorCPU.ToString();
           lblJugadas.Text = "El total de jugadas es: " + contadorJugadas.ToString();
           lblGanadas.Text = "Ganadas: " + contadorGanadas.ToString();
           lblEmpatadas.Text = "Empatadas: " + contadorEmpates.ToString();
           lblPerdidas.Text = "Perdidas: " + contadorDerrotas.ToString();  
           
           if (contadorJugador >= 3)
           {
                MessageBox.Show("Jugador ha ganado!");
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                contadorJugador = 0;
                contadorCPU = 0;
           }
           if (contadorCPU >= 3)
           {
                MessageBox.Show("CPU ha ganado!");
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                contadorCPU = 0;
                contadorJugador = 0;
           }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            pctJugador.Image = pryPPT.Properties.Resources.Papel;
            Int32 CPUelige = obj.Next(1, 4);

            switch (CPUelige)
            {
                case 1:
                    pctCPU.Image = pryPPT.Properties.Resources.piedra;
                    lblResultado.Text = "Ganaste!";
                    contadorJugador = contadorJugador + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorGanadas = contadorGanadas + 1;
                    break;

                case 2:
                    pctCPU.Image = pryPPT.Properties.Resources.Papel;
                    lblResultado.Text = "Empate!";
                    contadorEmpates = contadorEmpates + 1;
                    contadorJugadas = contadorJugadas + 1;
                    break;

                case 3:
                    pctCPU.Image = pryPPT.Properties.Resources.Tijera;   
                    lblResultado.Text = "Perdiste :(";
                    contadorCPU = contadorCPU + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorDerrotas = contadorDerrotas + 1;
                    break;
            }
            lblPuntuacionjugador.Text = contadorJugador.ToString();
            lblPuntuacionCPU.Text = contadorCPU.ToString();
            lblJugadas.Text = "El total de jugadas es: " + contadorJugadas.ToString();
            lblGanadas.Text = "Ganadas: " + contadorGanadas.ToString();
            lblEmpatadas.Text = "Empatadas: " + contadorEmpates.ToString();
            lblPerdidas.Text = "Perdidas: " + contadorDerrotas.ToString();

            if (contadorJugador >= 3)
            {
                MessageBox.Show("Jugador ha ganado!");
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                contadorJugador = 0;
                contadorCPU = 0;
            }
            if (contadorCPU >= 3)
            {
                MessageBox.Show("CPU ha ganado!");
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                contadorCPU = 0;
                contadorJugador = 0;
            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            pctJugador.Image = pryPPT.Properties.Resources.Tijera;
            Int32 CPUelige = obj.Next(1, 4);

            switch (CPUelige)
            {
                case 1:
                    pctCPU.Image = pryPPT.Properties.Resources.piedra;
                    lblResultado.Text = "Perdiste :(";
                    contadorCPU = contadorCPU + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorDerrotas = contadorDerrotas + 1;
                    break;

                case 2:
                    pctCPU.Image = pryPPT.Properties.Resources.Papel;
                    lblResultado.Text = "Ganaste!";
                    contadorJugador = contadorJugador + 1;
                    contadorJugadas = contadorJugadas + 1;
                    contadorGanadas = contadorGanadas + 1;
                    break;

                case 3:
                    pctCPU.Image = pryPPT.Properties.Resources.Tijera;
                    lblResultado.Text = "Empate!";
                    contadorEmpates = contadorEmpates + 1;
                    contadorJugadas = contadorJugadas + 1;
                    break;
            }
            lblPuntuacionjugador.Text = contadorJugador.ToString();
            lblPuntuacionCPU.Text = contadorCPU.ToString();
            lblJugadas.Text = "El total de jugadas es: " + contadorJugadas.ToString();
            lblGanadas.Text = "Ganadas: " + contadorGanadas.ToString();
            lblEmpatadas.Text = "Empatadas: " + contadorEmpates.ToString();
            lblPerdidas.Text = "Perdidas: " + contadorDerrotas.ToString();

            if (contadorJugador >= 3)
            {
                MessageBox.Show("Jugador ha ganado!");
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                contadorJugador = 0;
                contadorCPU = 0;
            }
            if (contadorCPU >= 3)
            {
                MessageBox.Show("CPU ha ganado!");
                lblPuntuacionCPU.Text = "Puntuacion total: " + contadorCPU;
                lblPuntuacionjugador.Text = "Puntuacion total: " + contadorJugador;
                contadorCPU = 0;
                contadorJugador = 0;
            }
        }
    }
}
