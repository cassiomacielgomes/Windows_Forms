using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_7
{
    static class CadastroUsuarios
    {
        //Criando usuários que poderão acessar
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Cassio", Senha = "1234"},
            new Usuario(){Nome = "Leo", Senha = "abc123"},
            new Usuario(){Nome = "Diego", Senha = "abcd"}
        };

        //Contem o usuário que está logado
        private static Usuario _userLogado = null;

        //Definir o valor e ativa o array acima
        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            set { _userLogado = value; }
        }

        //Controle de Login
        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
