using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telacadastro
{
    internal class Funcionario
    {
        public class Funcionarios
        {
            public string Nome { get; set; }
            public int Id { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Cpf { get; set; }
            public string Rg { get; set; }
            public string Email { get; set; }
            public string Fone { get; set; }
            public string Endereço { get; set; }
            public string Estado { get; set; }
            public string Estado_Civil { get; set;}
            public string Funcao_Cargo { get; set; }

            public double Salario { get; set; }

            public Funcionarios(string nome, int id, DateTime data_Nascimento, string cpf, string rg, string email, string fone, string endereço, string estado, string estado_Civil, string funcao_Cargo, double salario)
            {
                Nome = nome;
                this.Id = id;
                DataNascimento = data_Nascimento;
                Cpf = cpf;
                Rg = rg;
                Email = email;
                Fone = fone;
                Endereço = endereço;
                Estado = estado;
                Estado_Civil = estado_Civil;
                Funcao_Cargo = funcao_Cargo;
                Salario = salario;
            }

            public Funcionarios() { }
        }
    }
}
