using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matriz m1,m2,m3;
        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
            m3 = new Matriz();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = m2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = m3.Descargar();
        }

        private void sumaDeMatricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int digf1, digc1, digf2, digc2;
            digf1 = 0;digc1 = 0;digf2 = 0;digc2 = 0;
            m1.RetornarDimension(ref digf1, ref digc1);
            m2.RetornarDimension(ref digf2, ref digc2);
            if ((digf1==digf2)&&(digc1==digc2))
            {
                m1.Sumar(m2, m3);
                textBox8.Text = m3.Descargar();
            }           
            else
            {
                textBox8.Text = "Dimensiones no iguales para realizar la operación";
            }              
        }

        private void acumuladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Concat(m1.Acumulador());
        }

        private void multiplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Multiplicacion(m2, m3);
            textBox8.Text = m3.Descargar();
        }

        private void encontrarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Concat(m1.EncontrarElemento(int.Parse(textBox9.Text)));
        }

        private void encontrarElemetoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Concat(m1.EncontrarElementoW(int.Parse(textBox9.Text)));
        }

        private void cargarMatrizConEsquemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.CargarMatrizConEsquema(int.Parse(textBox1.Text), int.Parse(textBox2.Text),int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = m1.Descargar();
        }

        private void encontrarElementoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //int nf, nc;
            //    nf = 0; nc = 0;
            //m1.BuscarElemento(int.Parse(textBox1.Text), int.Parse(textBox2.Text),int.Parse(textBox9.Text));
        }

        private void mayorDeUnaFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Concat(m1.EncontrarElementoMayorDeFila(int.Parse(textBox1.Text)));
        }

        private void mayorDeTodasLasFilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.MayorDeTodasFilas();
            textBox8.Text = m1.Descargar();
        }

        private void ordenarUnaColumnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenarUnaColumna(int.Parse(textBox2.Text));
            textBox8.Text = m1.Descargar();
        }

        private void ordenarTodasLasColumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.OrdenarTodasLasColumnas();
            textBox8.Text = m1.Descargar();
        }

        private void cagar1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar1(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void cagar2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar2(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
    }
}
