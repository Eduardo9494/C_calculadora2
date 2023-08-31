namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;


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
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;

                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;

                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0 ");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;

                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
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

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");



        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";

        }
    }
}