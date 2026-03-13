namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            double KM, preco;

            KM = Convert.ToDouble(txtDistancia.Text);
            if (KM <= 200)
            {
                preco = KM * 0.50;
            }
            else
            {
                preco = KM * 0.45;
            }

            lblResultado.Text = preco.ToString();
        }
    }


}
