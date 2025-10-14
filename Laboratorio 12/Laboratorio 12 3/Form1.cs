using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        string longitudAIngresada, longitudBIngresada, longitudCIngresada;
        double semiPerimetro, areaTriangulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLongitudA_TextChanged(object sender, EventArgs e)
        {
            longitudAIngresada = txtLongitudA.Text;
        }

        private void txtLongitudB_TextChanged(object sender, EventArgs e)
        {
            longitudBIngresada = txtLongitudB.Text;
        }

        private void txtLongitudC_TextChanged(object sender, EventArgs e)
        {
            longitudCIngresada = txtLongitudC.Text;
        }

        private void btnSemiPerimetro_Click(object sender, EventArgs e)
        {
            float longitudA, longitudB, longitudC;
            try
            {
                longitudA = float.Parse(longitudAIngresada);
                longitudB = float.Parse(longitudBIngresada);
                longitudC = float.Parse(longitudCIngresada);

                if (longitudA < 0 || longitudB < 0 || longitudC < 0)
                {
                    MessageBox.Show("Error: No se permiten numeros negativos.");
                }
                else
                {
                    semiPerimetro = Calculos.CalcularSemiPerimetro(longitudA, longitudB, longitudC);
                    txtCalculoSemiPerimetro.Text = semiPerimetro.ToString();
                }
            }
            catch (FormatException z)
            {
                MessageBox.Show("Error: Formato incorrecto.");
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double longitudA, longitudB, longitudC;
            try
            {
                longitudA = double.Parse(longitudAIngresada);
                longitudB = double.Parse(longitudBIngresada);
                longitudC = double.Parse(longitudCIngresada);

                if (longitudA < 0 || longitudB < 0 || longitudC < 0)
                {
                    MessageBox.Show("Error: No se permiten numeros negativos.");
                }
                else
                {
                    areaTriangulo = Calculos.CalcularAreaTriangulo(longitudA, longitudB, longitudC);
                    txtAreaTriangulo.Text = areaTriangulo.ToString();
                }
            }
            catch (FormatException z)
            {
                MessageBox.Show("Error: Formato incorrecto.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLongitudA.Clear();
            txtLongitudB.Clear();
            txtLongitudC.Clear();
            txtCalculoSemiPerimetro.Clear();
            txtAreaTriangulo.Clear();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCalculoSemiPerimetro_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtAreaTriangulo_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Calculos
    {
        public static double CalcularSemiPerimetro(double longitudA, double longitudB, double longitudC)
        {
            return (longitudA + longitudB + longitudC) / 2;
        }

        public static double CalcularAreaTriangulo(double longitudA, double longitudB, double longitudC)
        {
            double semiPerimetro;
            double resta1, resta2, resta3, multiplicacion, resultado;

            semiPerimetro = CalcularSemiPerimetro(longitudA, longitudB, longitudC);

            resta1 = (semiPerimetro - longitudA);
            resta2 = (semiPerimetro - longitudB);
            resta3 = (semiPerimetro - longitudC);

            multiplicacion = semiPerimetro * resta1 * resta2 * resta3;

            resultado = Math.Sqrt(multiplicacion);

            return resultado;
        }
    }
}
