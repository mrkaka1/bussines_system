using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace telacadastro 
{
    public static class Validador
    {
        public static bool CPF(string cpf)
        {
            int soma = 0;
            int soma2 = 0;
            int resto = 0;
            int resto2 = 0;

            int[] verifica1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verifica2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace(",", "");
            cpf = cpf.Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * verifica1[i];
                verifica1[i]--;
            }
            //*MessageBox.Show("Erro aqui");*//
            if (soma % 11 < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - (soma % 11);
            }



            for (int i = 0; i < 10; i++)
            {
                soma2 += Convert.ToInt32(cpf[i].ToString()) * verifica2[i];
                verifica2[i]--;
            }

            //*MessageBox.Show("Ero aqui");*//

            if (soma2 % 11 < 2)
            {
                resto2 = 0;
            }
            else
            {
                resto2 = 11 - (soma2 % 11);
            }

            if (resto == Convert.ToInt32(cpf[9].ToString()) && resto2 == Convert.ToInt32(cpf[10].ToString()))
            {
                return true;
            }

            return false;

        }

        public static bool Email(string email)
        {
            string cdgEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(cdgEmail);

            Match comparaEmail = regex.Match(email);

            return comparaEmail.Success;
        }
    }
}
