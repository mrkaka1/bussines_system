using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using telacadastro.Conexão;

namespace telacadastro
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Funcionario func  = new Funcionario();
                func.Nome = txt_nome.Text;
                /*func.Cpf = mtx_cpf.Text;
                func.Rg = txt_rg.Text;
                func.Endereco = txt_end.Text;
                func.Funcao_Cargo = cmb_cargo.Text;
                func.Estado = txt_estado.Text;
                func.Estado_Civil = cbm_estadocivil.Text;
                func.Salario = txt_salario.Text;
                func.Cidade = txt_cidd.Text;
                func.Telefone = txt_telefone.Text;
                func.Email = txt_email.Text;
                func.DataNascimento = dtp_nasci.Text;*/

                /*if (txt_nome.Text != "" && mtx_cpf.Text != "" && txt_rg.Text != "" && txt_end.Text != "" && cmb_cargo.Text != "" &&
                    txt_estado.Text != "" && cbm_estadocivil.Text != "" && txt_salario.Text != "" && txt_cidd.Text != "" &&
                    txt_telefone.Text != "" && txt_email.Text != "" && dtp_nasci.Text != "")
                {*/
                    Validador.CPF(mtx_cpf.Text.ToString());
                    bool valido = Validador.CPF(mtx_cpf.Text.ToString());

                    Validador.Email(txt_email.Text.ToString());
                    bool validoem = Validador.Email(txt_email.Text.ToString());

                    if (valido == true && validoem == true )
                    {

                        Funcionario funcionario = new Funcionario();
                        funcionario.Nome = txt_nome.Text;
                        funcionario.Cpf = mtx_cpf.Text;
                        funcionario.Rg = txt_rg.Text;
                        funcionario.Endereco = txt_end.Text;
                        funcionario.Estado = txt_estado.Text;
                        funcionario.Estado_Civil = cbm_estadocivil.Text;
                        funcionario.Salario = Convert.ToDouble(txt_salario.Text);
                        funcionario.DataNascimento = dtp_nasci.Text;
                        funcionario.Funcao_Cargo = cmb_cargo.Text;
                        funcionario.Email = txt_email.Text;
                        funcionario.Telefone = txt_telefone.Text;
                        funcionario.Cidade = txt_cidd.Text;

                        Inserir(funcionario);
                        txt_nome.Clear();
                        mtx_cpf.Clear();
                        txt_rg.Clear();
                        txt_email.Clear();
                        txt_id.Clear();
                        txt_telefone.Clear();
                        txt_end.Clear();
                        cmb_cargo.Text = "";
                        cbm_estadocivil.Text = "";
                        dtp_nasci.Text = "";
                        txt_cidd.Clear();
                        txt_salario.Clear();
                        txt_estado.Clear();


                       /* MessageBox.Show($"O CPF e o EMAIL são válidos!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                    }
                    else
                    {
                        MessageBox.Show("CPF/Email são inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                /*}*/
                /*else { MessageBox.Show("Todos os campos são obrigatórios para ser preenchidos", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

            }*/
            /*catch (Exception ex) 
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun,telefone_Fun,email_Fun, endereco_Fun,cidade_Fun, estado_Fun , estado_civil_Fun , funcao_Fun, salario_Fun ) VALUES (@nome, @data_Nascimento, @cpf, @rg, @telefone,@email, @endereco, @cidade, @estado, @estado_civil,@funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_Nascimento", funcionario.DataNascimento);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade); 
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_Civil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao_Cargo);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionario Cadastrado com Sucesso", "OK", MessageBoxButtons.OK);
                }

            } catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void txt_salario_TextChanged(object sender, EventArgs e)
        {   

        }
    }
}
