using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTEC.DTO
{
    class UsuariosDTO
    {
        public class Usuarios
        {
            private int id;
            public int Id { get => id; set => id = value; }

            private string email;
            public string Email { get => email; set => email = value; }

            private string senha;
            public string Senha { get => senha; set => senha = value; }

            private string cpf;
            public string Cpf { get => cpf; set => cpf = value; }

            private string nascimento;
            public string Nascimento { get => nascimento; set => nascimento = value; }

            private string permissao;
            public string Permissao { get => permissao; set => permissao = value; }
        }
    }
}
