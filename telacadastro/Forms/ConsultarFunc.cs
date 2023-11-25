using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telacadastro.Conexão;
using telacadastro.Forms;
using telacadastro.Uteis;


namespace telacadastro
{
    public partial class ConsultarFunc : Form
    {
        private List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public ConsultarFunc()
        {
            InitializeComponent();
            Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadFuncionario form1 = new CadFuncionario();
            form1.ShowDialog();
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Id = leitor.GetInt32("id_Fun");
                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_Fun");
                    funcionario.DataNascimento = DAOHelper.GetString(leitor, "data_nas_Fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_Fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_Fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_Fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_Fun");
                    funcionario.Endereco = DAOHelper.GetString(leitor, "endereco_Fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_Fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_Fun");
                    funcionario.Estado_Civil = DAOHelper.GetString(leitor, "estado_civil_Fun");
                    funcionario.Funcao_Cargo = DAOHelper.GetString(leitor, "funcao_Fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_Fun");

                    listaFuncionarios.Add(funcionario);
                }

                dgv_Func.DataSource = null;
                dgv_Func.Refresh();
                dgv_Func.DataSource = listaFuncionarios;
            }

            catch
            {
                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AtualizarDataGridView()
        {
            listaFuncionarios.Clear();

            Consultar();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
