using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12
{
    public partial class Form1 : Form
    {
        string velociadIngresada;
        string tiempoIngresado;
        float calculo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {
            velociadIngresada = txtVelocidad.Text;
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            tiempoIngresado = txtTiempo.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float velocidad, tiempo;

            try
            {
                velocidad = float.Parse(velociadIngresada);
                tiempo = float.Parse(tiempoIngresado);

                if (velocidad < 0 || tiempo < 0)
                {
                    MessageBox.Show("Error: No se puede ingresar numeros negativos");
                }

                else
                {
                    calculo = Distancia.calcularDistanciaTotalRecorrida(velocidad, tiempo);

                    txtResultadoDistanciaTotal.Text = calculo.ToString();
                }
            }catch (FormatException z)
            {
                MessageBox.Show($"Error: Formato incorrecto");
            }
            
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtResultadoDistanciaTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtResultadoDistanciaTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    public class Distancia
    {
        public static float calcularDistanciaTotalRecorrida (float velocidad, float tiempo)
        {
            return velocidad * tiempo;
        }
    }

}
