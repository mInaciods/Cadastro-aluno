using MySql.Data.MySqlClient;

namespace Cadastro_aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtbox_nome.Text;
                string nascimento = txtbox_nascimento.Text;
                string curso = txtbox_curso.Text;
                string telefone = txtbox_telefone.Text;

                if (nome != "" && nascimento != "" && curso != "" && telefone != "")
                {
                    string conexaoBanco = "Server=localhost; Database=cadastro; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    // Conversão da data de "dd/MM/yyyy" para "yyyy-MM-dd"
                    DateTime dataNasc = DateTime.ParseExact(nascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    string nascimentoFormatado = dataNasc.ToString("yyyy-MM-dd");

                    // Inserindo os dados no banco de dados
                    string cadastrarAluno = "INSERT INTO alunos (nome, nascimento, curso, telefone) VALUES (@nome, @nascimento, @curso, @telefone)";
                    MySqlCommand comandoSQL = new MySqlCommand(cadastrarAluno, conexao);
                    comandoSQL.Parameters.AddWithValue("@nome", nome);
                    comandoSQL.Parameters.AddWithValue("@nascimento", nascimentoFormatado);
                    comandoSQL.Parameters.AddWithValue("@curso", curso);
                    comandoSQL.Parameters.AddWithValue("@telefone", telefone);

                    int registro = comandoSQL.ExecuteNonQuery();

                    if (registro > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Preencha corretamente os campos!");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro realizar login" + ex.Message);
                throw;
            }
        }
    }
}
