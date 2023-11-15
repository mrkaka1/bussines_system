
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                string nome = txt_nome.Text;
                string cpf = mtx_cpf.Text;
                string rg = txt_rg.Text;
                string endereco = txt_end.Text;
                string cargo = cmb_cargo.Text;
                string estado = txt_estado.Text;
                string estadoCivil = cbm_estadocivil.Text;
                string salario = txt_salario.Text;
                string cidade = txt_cidd.Text;
                string telefone = txt_telefone.Text;
                string id = txt_id.Text;
                string email = txt_email.Text;
                string datanas = dtp_nasci.Text;

                if(nome != "" && cpf != "" &&  rg != "" &&  endereco != "" && cargo != "" &&
                    estado != "" && estadoCivil != "" && salario != "" &&  cidade != "" &&
                    telefone != "" && id != "" && email != "" && datanas != "")
                {
                    Validador.CPF(cpf);
                    bool valido = Validador.CPF(cpf.ToString());

                    Validador.Email(email);
                    bool validoem = Validador.Email(email.ToString());

                    if (valido == true && validoem == true )
                    {
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


                        MessageBox.Show($"O CPF e o EMAIL são válidos!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("CPF/Email são inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Todos os campos são obrigatórios para ser preenchidos", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

            } catch(Exception ex) 
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_salario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
