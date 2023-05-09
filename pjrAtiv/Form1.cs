using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string mensagem;

            if (txtLogin.Text == String.Empty || txtLogin.TextLength<11)
            {
                mensagem = "Prencha a caixa de login corretamente!";
            }
            else if (txtSenha.Text == String.Empty || txtSenha.TextLength<6)
            {
                mensagem= "Prencha a caixa de senha corretamente!";
            }
            else
            {
                if (txtLogin.Text != "12345678901")
                {
                    mensagem = "Login inválido!";
                }
                else if (txtSenha.Text != "123456")
                {
                    mensagem = "Senha inválida";
                }
                else
                {
                    mensagem = "Usuário autenticado!";
                }
            }


            //lblMensagem.Text = mensagem;  // mensagem em um label
            MessageBox.Show(mensagem, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
            
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}