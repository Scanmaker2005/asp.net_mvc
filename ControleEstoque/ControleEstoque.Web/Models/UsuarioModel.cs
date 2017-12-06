using System.Data.SqlClient;

namespace ControleEstoque.Web.Models
{
    public class UsuarioModel
    {

        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = @"Data Source=DEV-PC\SQLEXPRESS;Initial Catalog=controle-estoque;User Id=root;Password=toor";
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection  = conexao;
                    comando.CommandText = string.Format("select count(*) from usuario where login='{0}' and senha='{1}'",login,senha);
                    ret = ((int) comando.ExecuteScalar() >0);
                }
            }
            return ret;
        }
    }
}