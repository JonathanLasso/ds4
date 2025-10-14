using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        string nota1Ingresada;
        string nota2Ingresada;
        string nota3Ingresada;
        float promedio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            nota1Ingresada = txtNota1.Text;
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {
            nota2Ingresada = txtNota2.Text;
        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {
            nota3Ingresada = txtNota3.Text;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3;
            try
            {
                nota1 = float.Parse(nota1Ingresada);
                nota2 = float.Parse(nota2Ingresada);
                nota3 = float.Parse(nota3Ingresada);

                if(nota1 < 0 || nota2 < 0 || nota3 < 0)
                {
                    MessageBox.Show("Error: No se permiten numeros negativos.");
                }

                else
                {
                    promedio = Promedio.calcularPromedio(nota1, nota2, nota3);

                    txtResultado.Text = promedio.ToString();
                }
            }catch (FormatException z)
            {
                MessageBox.Show("Error: Formato incorrecto.");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Promedio
    {
        public static float calcularPromedio(float nota1, float nota2, float nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
    
}
