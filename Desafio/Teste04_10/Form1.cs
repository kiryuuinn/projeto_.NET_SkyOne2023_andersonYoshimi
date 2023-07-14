namespace Teste04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(login) )
            {
                lblValidacao.Text = "O Login é obrigatório.";
                return;
            }

            if (string.IsNullOrEmpty(senha) )
            {
                lblValidacao.Text = "A Senha é obrigatória.";
                return;
            }

            new LancamentoNotas().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}