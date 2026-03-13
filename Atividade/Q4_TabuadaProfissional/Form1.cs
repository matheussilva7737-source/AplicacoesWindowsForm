namespace Q4_TabuadaProfissional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
          Tabuada.Items.Add(txtnumero.Text);
            int nu;

            nu = int.Parse(txtnumero.Text);
            for (int i = 1; i <= 10; i++)
            {
                Tabuada.Items.Add($"{nu} * {i} = {i * nu}");
                txtnumero.Clear();
                txtnumero.Focus();
            }
        }
    }
}
