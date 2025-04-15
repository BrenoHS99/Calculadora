using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoradedivisao
{
    public partial class frmCalculadora: Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        double numero1, numero2, resultado;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);

            resultado = numero1 + numero2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);

            resultado = numero1 - numero2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);

            resultado = numero1 / numero2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);

            resultado = numero1 * numero2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);

            resultado = Math.Sqrt(numero1);
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
