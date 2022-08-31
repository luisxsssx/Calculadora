using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora //Espacio de nombres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void suma_Click(object sender, EventArgs e)
        {
            clsuma osuma = new clsuma(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = osuma.sumar().ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            clresta oresta = new clresta(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = oresta.restar().ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            cldivision odiv = new cldivision(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = odiv.dividir().ToString();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            clmultiplicar omultiplicar = new clmultiplicar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = omultiplicar.multiplicar().ToString();
        }
    }
}
