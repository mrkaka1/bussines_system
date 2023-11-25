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
using telacadastro.Uteis;

namespace telacadastro.Forms
{
    public partial class ConsultarEmp : Form
    {
        private List<Empresas> listaEmpresas = new List<Empresas>();

        public ConsultarEmp()
        {
            InitializeComponent();
            Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.ShowDialog();
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Empresas");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    

                    Empresas empresas = new Empresas();
                    empresas.Id = leitor.GetInt32("id_emp");
                    empresas.NomeFantasia = DAOHelper.GetString(leitor, "nome_fantasia_emp");
                    empresas.RazaoSocial = DAOHelper.GetString(leitor, "razao_social_emp");
                    empresas.CNPJ = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresas.SituacaoCadastral = DAOHelper.GetString(leitor, "situacao_cadastral_emp");
                    empresas.DataInicioAtividade = DAOHelper.GetString(leitor, "inicio_atvd_emp");
                    empresas.Endereco = DAOHelper.GetString(leitor, "endereco_emp");
                    empresas.Estado = DAOHelper.GetString(leitor, "estado_emp");
                    empresas.Cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    empresas.RegimeTributario = DAOHelper.GetString(leitor, "regime_tributario_emp");
                    empresas.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresas.PorteEmpresa = DAOHelper.GetString(leitor, "porte_emp");
                    empresas.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresas.NaturezaJuridica = DAOHelper.GetString(leitor, "natureza_juridica_emp");
                    empresas.ValorMonetario = DAOHelper.GetDouble(leitor, "valor_monetario_emp");
                    empresas.NomeProprietario = DAOHelper.GetString(leitor, "nome_proprietario_emp");
                    empresas.CPF = DAOHelper.GetString(leitor, "cpf_emp"); ;

                    listaEmpresas.Add(empresas);
                }

                dgv_Func.DataSource = null;
                dgv_Func.Refresh();
                dgv_Func.DataSource = listaEmpresas;
            }

            catch
            {
                throw;
            }
        }
        private void AtualizarDataGridView()
        {
            listaEmpresas.Clear();

            Consultar();
        }
        private void ConsultarEmp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
