namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double Celsius, fahrenheit;

            Celsius = Convert.ToDouble(txtCelsius.Text);
            fahrenheit = (Celsius * 9) + 32;
            lblResultado.Text = Convert.ToString(fahrenheit);

        }
    }
}
