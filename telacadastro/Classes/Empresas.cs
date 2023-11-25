using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telacadastro
{
    public class Empresas
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string DataInicioAtividade { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public string CapitalSocial { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CPF { get; set; }

        public Empresas()
        {

        }

        public Empresas(int id, string nomeFantasia, string dataInicioAtividade, string cNPJ, string razaoSocial, string situacaoCadastral, string regimeTributario, string capitalSocial, string telefone, string estado, string tipo, string porteEmpresa, string naturezaJuridica, string nomeProprietario, string cPF)
        {
            this.Id = id;
            this.NomeFantasia = nomeFantasia;
            this.DataInicioAtividade = dataInicioAtividade;
            this.CNPJ = cNPJ;
            this.RazaoSocial = razaoSocial;
            this.SituacaoCadastral = situacaoCadastral;
            this.RegimeTributario = regimeTributario;
            this.CapitalSocial = capitalSocial;
            this.Telefone = telefone;
            this.Estado = estado;
            this.Tipo = tipo;
            this.PorteEmpresa = porteEmpresa;
            this.NaturezaJuridica = naturezaJuridica;
            this.NomeProprietario = nomeProprietario;
            this.CPF = cPF;
        }   
    }

}
