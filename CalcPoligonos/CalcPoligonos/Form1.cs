using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace CalcPoligonos
{
    public partial class CalculadoraPoligonos : Form
    {
        private Poligono poligonoSeleccionado;
        public CalculadoraPoligonos()
        {
            InitializeComponent();
        }


        private void poligonosTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(poligonosTabControl1.SelectedIndex == 0)
            {
                poligonoSeleccionado = new Triangulo();
            }
            if (poligonosTabControl1.SelectedIndex == 1)
            {
                poligonoSeleccionado = new Cuadrado();
            }
            if (poligonosTabControl1.SelectedIndex == 2)
            {
                poligonoSeleccionado = new Circulo();
            }
            if (poligonosTabControl1.SelectedIndex == 3)
            {
                poligonoSeleccionado = new Rectangulo();
            }
            if (poligonosTabControl1.SelectedIndex == 4)
            {
                poligonoSeleccionado = new Pentagono();
            }
        }

        private void trianguloLado1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void trianguloLado1TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado1 = Convert.ToDouble(trianguloLado1TextBox.Text);
        }
        private void trianguloLado2TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado2 = Convert.ToDouble(trianguloLado2TextBox.Text);
        }

        private void trianguloLado3TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado3 = Convert.ToDouble(trianguloLado3TextBox.Text);
        }

        private void trianguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Altura = Convert.ToDouble(trianguloAlturaTextBox.Text);
        }

        private void cuadradoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Cuadrado cuadrado = (Cuadrado)poligonoSeleccionado;
            cuadrado.Lado = Convert.ToDouble(cuadradoLadoTextBox.Text);
        }

        private void circuloRadioTextBox_Leave(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)poligonoSeleccionado;
            circulo.Radio = Convert.ToDouble(circuloRadioTextBox.Text);
        }

        private void rectanguloAltoTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)poligonoSeleccionado;
            rectangulo.Lado1 = Convert.ToDouble(rectanguloAltoTextBox.Text);
        }

        private void rectanguloAnchoTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)poligonoSeleccionado;
            rectangulo.Lado2 = Convert.ToDouble(rectanguloAnchoTextBox.Text);
        }

        private void pentagonoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)poligonoSeleccionado;
            pentagono.Lado = Convert.ToDouble(pentagonoLadoTextBox.Text);
        }

        private void pentagonoApotemaTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)poligonoSeleccionado;
            pentagono.Apotema = Convert.ToDouble(pentagonoApotemaTextBox.Text);
        }

        private void botonPerimetro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El perimetro es: " + poligonoSeleccionado.CalcularPerimetro().ToString(), "Perimetro");
        }

        private void botonArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El area es: " + poligonoSeleccionado.CalcularArea().ToString(), "Area");
        }
    }
}
