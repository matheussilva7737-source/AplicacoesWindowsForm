namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double cotacao, qtde, resultado;

            cotacao = Convert.ToDouble(txtcotacao.Text);
            qtde = Convert.ToDouble(txtDolares.Text);

            resultado = qtde * cotacao;

            lblResultado.Text = resultado.ToString();


           



           
           
        }
    }
}
