using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace telacadastro.Conexão
{
    class Conexao
    {
        private string _servidor = "localhost";

        private string _porta = "3306";

        private string _usuario = "root";

        private string _senha = "Kauan23@";

        private string _bancoDadosNome = "cadastro_funcionario_bd";

        private MySqlConnection connection;

        private MySqlCommand command;

        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta}; user={_usuario}; password={_senha};");
                connection.Open();
            }
            catch (Exception ex ) 
            {
                throw ex;
            }
        }

        public MySqlCommand Comando( string comando )
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                return command;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
