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


namespace telacadastro
{
    public partial class Form2 : Form
    {
        private List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public Form2()
        {
            InitializeComponent();
            Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
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
                    funcionario.Nome = leitor.GetString("nome_Fun");
                    funcionario.DataNascimento = leitor.GetString("data_nas_Fun");
                    funcionario.Cpf = leitor.GetString("cpf_Fun");
                    funcionario.Rg = leitor.GetString("rg_Fun");
                    funcionario.Telefone = leitor.GetString("telefone_Fun");
                    funcionario.Email = leitor.GetString("email_Fun");
                    funcionario.Endereco = leitor.GetString("endereco_Fun");
                    funcionario.Cidade = leitor.GetString("cidade_Fun");
                    funcionario.Estado = leitor.GetString("estado_Fun");
                    funcionario.Estado_Civil = leitor.GetString("estado_civil_Fun");
                    funcionario.Funcao_Cargo = leitor.GetString("funcao_Fun");
                    funcionario.Salario = leitor.GetDouble("salario_Fun");

                    var posicaoColuna = leitor.GetOrdinal("cpf_Fun");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {
                        funcionario.Cpf = leitor.GetString("cpf_Fun");
                    }

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

       
    }
}
