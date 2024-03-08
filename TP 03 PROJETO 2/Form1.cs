namespace TP_03_PROJETO_2
{
    public partial class Form1 : Form
    {
        public Livro umLivro = new Livro();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            umLivro.Titulo = txtTitulo.Text;
            umLivro.Autor = txtAutor.Text;
            umLivro.Editora = txtEditora.Text;
            umLivro.AnoEdicao = txtAnoEdicao.Text;
            umLivro.Local = txtLocal.Text;

            BLL_Livro.ValidarDados(umLivro);

            if (Erro.TemErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }
            else
            {

                txtTitulo.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtAnoEdicao.Enabled = false;
                txtLocal.Enabled = false;

                txtTitulo.Clear();
                txtAutor.Clear();
                txtEditora.Clear();
                txtAnoEdicao.Clear();
                txtLocal.Clear();


            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtAnoEdicao.Clear();
            txtLocal.Clear();

            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtEditora.Enabled = true;
            txtAnoEdicao.Enabled = true;
            txtLocal.Enabled = true;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = umLivro.Titulo;
            txtAutor.Text = umLivro.Autor;
            txtEditora.Text = umLivro.Editora;
            txtAnoEdicao.Text = umLivro.AnoEdicao;
            txtLocal.Text = umLivro.Local;
        }
    }
}