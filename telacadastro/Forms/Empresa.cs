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
            dtp_data.CustomFormat = "yyyy MMM ddd dd ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empresas empresa = new Empresas();
            empresa.NomeFantasia = txt_nome_fanta.Text;
            empresa.RazaoSocial = tx_razao_social.Text;
            empresa.CNPJ = mtx_cnpj.Text;
            empresa.CapitalSocial = tx_cps.Text;
            empresa.NaturezaJuridica = cmb_natureza.Text;
            empresa.DataInicioAtividade = dtp_data.Text;
            empresa.NomeProprietario = tx_nomepropri.Text;
            empresa.Estado = cmb_estado.Text;
            empresa.SituacaoCadastral = cmb_situation_cad.Text;
            empresa.RegimeTributario = RadioRegime();
            empresa.Tipo = RadioType();
            empresa.PorteEmpresa = RadioPorte();
            empresa.NomeProprietario = t
            
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
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_salario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
