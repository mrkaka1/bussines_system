using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CpfCnpjLibrary;
using telacadastro.Conexão;

namespace telacadastro.Forms
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();  
        }

        private void Empresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {

                if (CamposValidos() == true)
                {
                    if (Cnpj.Validar(mtx_cnpj.Text) == true && Validador.CPF(tx_cpfpro.Text))
                    {
                        Empresas empresa = new Empresas();
                        empresa.NomeFantasia = txt_nome_fanta.Text;
                        empresa.RazaoSocial = tx_razao_social.Text;
                        empresa.CNPJ = mtx_cnpj.Text;
                        empresa.ValorMonetario = Convert.ToDouble(txt_valormoneta.Text);
                        empresa.NaturezaJuridica = cmb_natureza.Text;
                        empresa.DataInicioAtividade = dtp_data.Text;
                        empresa.NomeProprietario = tx_nomepropri.Text;
                        empresa.Cidade = txt_cidd.Text;
                        empresa.Estado = cmb_estado.Text;
                        empresa.SituacaoCadastral = cmb_situation_cad.Text;
                        empresa.Telefone = tx_telefone.Text;
                        empresa.Endereco = txt_end.Text;
                        empresa.RegimeTributario = RadioRegime();
                        empresa.Tipo = RadioType();
                        empresa.PorteEmpresa = RadioPorte();
                        empresa.NomeProprietario = tx_nomepropri.Text;
                        empresa.CPF = tx_cpfpro.Text;

                        Inserir(empresa);

                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("CNPJ / CPF são inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
            catch
            {
                throw;
            }

        }
        public string RadioRegime()
        {
            string radio = "";

            foreach (Control ctrl in panelRegime.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string RadioType()
        {
            string radio = "";

            foreach (Control ctrl in panelTipo.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string RadioPorte()
        {
            string radio = "";

            foreach (Control ctrl in panelPorte.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        private void Inserir(Empresas empresa)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Empresas (nome_fantasia_emp, razao_social_emp," +
                    "cnpj_emp, situacao_cadastral_emp, inicio_atvd_emp, endereco_emp, estado_emp,cidade_emp," +
                    "regime_tributario_emp, tipo_emp, porte_emp, telefone_emp, natureza_juridica_emp, valor_monetario_emp, nome_proprietario_emp, cpf_emp) " +
                    " VALUES (@nomeFanta, @razaoSocial, @cnpj, @situacaoCad, @inicioAtvd, @endereco, @estado, @cidade, @regimeTributa," +
                    "@tipo, @porte, @telefone, @naturezaJudi, @valorMoneta, @nomePropri, @cpfPropri)");

                comando.Parameters.AddWithValue("@nomeFanta", empresa.NomeFantasia);
                comando.Parameters.AddWithValue("@razaoSocial", empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
                comando.Parameters.AddWithValue("@situacaoCad", empresa.SituacaoCadastral);
                comando.Parameters.AddWithValue("@inicioAtvd", empresa.DataInicioAtividade);
                comando.Parameters.AddWithValue("@endereco", empresa.Endereco);
                comando.Parameters.AddWithValue("@estado", empresa.Estado);
                comando.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comando.Parameters.AddWithValue("@regimeTributa", empresa.RegimeTributario);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte", empresa.PorteEmpresa);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@naturezaJudi", empresa.NaturezaJuridica);
                comando.Parameters.AddWithValue("@valorMoneta", empresa.ValorMonetario);
                comando.Parameters.AddWithValue("@nomePropri", empresa.NomeProprietario);
                comando.Parameters.AddWithValue("@cpfPropri", empresa.CPF);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa Cadastrada com Sucesso", "OK", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txt_nome_fanta.Text) ||
                string.IsNullOrWhiteSpace(tx_razao_social.Text) ||
                string.IsNullOrWhiteSpace(mtx_cnpj.Text) ||
                string.IsNullOrWhiteSpace(txt_valormoneta.Text) ||
                string.IsNullOrWhiteSpace(cmb_natureza.Text) ||
                string.IsNullOrWhiteSpace(dtp_data.Text) ||
                string.IsNullOrWhiteSpace(tx_nomepropri.Text) ||
                string.IsNullOrWhiteSpace(cmb_estado.Text) ||
                string.IsNullOrWhiteSpace(cmb_situation_cad.Text) ||
                string.IsNullOrWhiteSpace(tx_nomepropri.Text) ||
                string.IsNullOrWhiteSpace(tx_cpfpro.Text) ||
                !RadioButtonsSelecionados(panelRegime) ||
                !RadioButtonsSelecionados(panelTipo) ||
                !RadioButtonsSelecionados(panelPorte))
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool RadioButtonsSelecionados(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        private void LimparCampos()
        {
            txt_nome_fanta.Text = "";
            tx_razao_social.Text = "";
            mtx_cnpj.Text = "";
            txt_valormoneta.Text = "";
            cmb_natureza.Text = "";
            dtp_data.Text = "";
            txt_end.Text = "";
            txt_cidd.Text = "";
            tx_nomepropri.Text = "";
            cmb_estado.Text = "";
            cmb_situation_cad.Text = "";
            tx_telefone.Text = "";


            LimparRb(panelRegime);
            LimparRb(panelTipo);
            LimparRb(panelPorte);

            tx_nomepropri.Text = "";
            tx_cpfpro.Text = "";
        }
        private void LimparRb(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_salario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
