namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Pessoas novapessoa = new Pessoas();

            novapessoa.Pessoa = txtNome.Text; 
            novapessoa.Idade = txtIdade.Text;

            Repositorio.adcionarpessoa.Add(novapessoa);
            lstpessoas.Items.Add($"{novapessoa.Pessoa} {novapessoa.Idade}");
        }
    }
}
