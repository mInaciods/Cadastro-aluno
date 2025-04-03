using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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

        private void txtbox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaoBanco = "Server=localhost; Database=cadastro; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();

                string listarAlunos = "SELECT id, nome, DATE_FORMAT(nascimento, '%d/%m/%Y') as nascimento, curso, telefone FROM alunos";
                MySqlCommand comandoSQL = new MySqlCommand(listarAlunos, conexao);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoSQL);
                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);
                datagrid1.DataSource = tabela;

                if (datagrid1.Columns.Contains("id"))
                {
                    datagrid1.Columns["id"].Visible = false;
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos: " + ex.Message);
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtbox_nome.Text;
                string nascimento = txtbox_nascimento.Text;
                string curso = txtbox_curso.Text;
                string telefone = txtbox_telefone.Text;

                DateTime dataNasc = DateTime.ParseExact(nascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string nascimentoFormatado = dataNasc.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localhost; Database=cadastro; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();

                string atualizarAluno = "UPDATE alunos SET nome = @nome, nascimento = @nascimento, curso = @curso, telefone = @telefone WHERE id = @id";
                MySqlCommand comandoSQL = new MySqlCommand(atualizarAluno, conexao);
                comandoSQL.Parameters.AddWithValue("@nome", nome);
                comandoSQL.Parameters.AddWithValue("@nascimento", nascimentoFormatado);
                comandoSQL.Parameters.AddWithValue("@curso", curso);
                comandoSQL.Parameters.AddWithValue("@telefone", telefone);
                comandoSQL.Parameters.AddWithValue("@id", idAluno);

                int registro = comandoSQL.ExecuteNonQuery();

                if (registro > 0)
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar os dados!");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar alunos: " + ex.Message);
            }
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int idAluno;

        private void datagrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (datagrid1.CurrentRow != null)
                {
                    DataGridViewRow linha = datagrid1.CurrentRow;

                    idAluno = Convert.ToInt32(linha.Cells["id"].Value);

                    txtbox_nome.Text = linha.Cells["nome"].Value.ToString();
                    txtbox_nascimento.Text = linha.Cells["nascimento"].Value.ToString();
                    txtbox_curso.Text = linha.Cells["curso"].Value.ToString();
                    txtbox_telefone.Text = linha.Cells["telefone"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar aluno: " + ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtbox_nome.Clear();
            txtbox_nascimento.Clear();
            txtbox_curso.Clear();
            txtbox_telefone.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAluno > 0)
                {
                    using (MySqlConnection conexao = new MySqlConnection("Server=localhost; Database=cadastro; Uid=root; pwd=''"))
                    {
                        conexao.Open();
                        MySqlCommand comandoSQL = new MySqlCommand("DELETE FROM alunos WHERE id = @id", conexao);
                        comandoSQL.Parameters.AddWithValue("@id", idAluno);
                        comandoSQL.ExecuteNonQuery();
                    }

                    MessageBox.Show("Aluno excluído com sucesso!");
                    btn_listar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selecione um aluno antes de excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
            }
        }
    }
}
