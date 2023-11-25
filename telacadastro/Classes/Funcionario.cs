using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telacadastro
{
        public class Funcionario
        {
            public string Nome { get; set; }
            public int Id { get; set; }
            public string DataNascimento { get; set; }
            public string Cpf { get; set; }
            public string Rg { get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
            public string Cidade { get; set; }
            public string Telefone { get; set; }
            public string Estado { get; set; }
            public string Estado_Civil { get; set;}
            public string Funcao_Cargo { get; set; }

            public double Salario { get; set; }

            public Funcionario(string nome, string data_Nascimento, string cpf, string rg, string email, string fone, string endereço, string estado, string estado_Civil, string funcao_Cargo, double salario)
            {
                Nome = nome;
                DataNascimento = data_Nascimento;
                Cpf = cpf;
                Rg = rg;
                Email = email;
                Endereco = endereço;
                Estado = estado;
                Estado_Civil = estado_Civil;
                Funcao_Cargo = funcao_Cargo;
                Salario = salario;
            }

            public Funcionario() { }

    }
 
}
