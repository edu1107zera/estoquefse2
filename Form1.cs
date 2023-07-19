using System.Xml;

namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        //variaveis globais
        List<string> produto_nome = new List<string>();
        List<int> produtosQuantidade = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        //Minhas funçoes
        void adicionarProdutos()
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produto_nome.Add(nome);
            produtosQuantidade.Add(quantidade);
        }
        void atualizaInterface()
        {
            int quantidade_cadastrada = produto_nome.Count();
            lblCadastros.Text = quantidade_cadastrada.ToString();
        }
        void limpaCampos()
        {
            txtNome.Text = "";
            txtQuantidade.Text = "";
            txtNome.Focus();
           

        }
        void verproduto(bool primeiro)
        {
            string nome;
            int quantidade;
            if (primeiro == true)
            {
                nome = produto_nome[0];
                quantidade = produtosQuantidade[0];
            }
            else
            {
                nome = produto_nome[produto_nome.Count - 1];
                quantidade = produtosQuantidade[produtosQuantidade.Count - 1];
            }
           
            MessageBox.Show($"nome: {nome},Quantidade: {quantidade}");
        }
        void removeProduto()
        {
            if(listaVazia() ==true)
            {
                MessageBox.Show("lista ja esta vazia");
            }
            else
            {
                produto_nome.RemoveAt(0);
                produtosQuantidade.RemoveAt(0);
            }
           
        }
        bool listaVazia()
        {
            if(produto_nome.Count()>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionarProdutos();
            atualizaInterface();
            limpaCampos();
            
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnVerPrimeiro_Click(object sender, EventArgs e)
        {
            verproduto(true);
        }

        private void btnVerUltimo_Click(object sender, EventArgs e)
        {
            verproduto(false);
        }

        private void btnDelUltimo_Click(object sender, EventArgs e)
        {
            removeProduto();
            atualizaInterface();
        }
    }
}