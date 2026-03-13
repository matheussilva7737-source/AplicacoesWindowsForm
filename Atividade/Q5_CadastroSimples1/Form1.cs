namespace Q5_CadastroSimples1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoas novapessoa = new Pessoas();

            novapessoa.Pessoa = txtNome.Text;
            novapessoa.Idade = txtIdade.Text;

            Repositorio.adicionarpessoa.Add(novapessoa);
            lstPessoas.Items.Add($"{novapessoa.Pessoa} {novapessoa.Idade}");
        }
    }
}
