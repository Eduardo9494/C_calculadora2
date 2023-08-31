namespace Calculadora
{
    public partial class Form1 : Form
    {

        double valor1 = 0;
        double valor2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void cajaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void leerNumeros(String numero)
        {
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }

        }
         private double EjecutarOperacion(string operador)
        {
            double resultado = 0;
            switch (operador)
            {
                default:
            }
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            leerNumeros("1");

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            leerNumeros("2");

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            leerNumeros("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            leerNumeros("4");
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            leerNumeros("5");

        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            leerNumeros("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            leerNumeros("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            leerNumeros("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            leerNumeros("9");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + "+";
            cajaResultado.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = valor1 + valor2;
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }
    }
}