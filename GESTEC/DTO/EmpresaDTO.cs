namespace GESTEC.DTO
{
    class EmpresaDTO
    {
        public class Empresa
        {
            private int id;
            public int Id { get => id; set => id = value; }
            private string razaosocial;
            public string Razaosocial { get => razaosocial; set => razaosocial = value; }
            private string nomefantasia;
            public string Nomefantasia { get => nomefantasia; set => nomefantasia = value; }
            private string cnpj;
            public string Cnpj { get => cnpj; set => cnpj = value; }
            private string inscricaoestadual;
            public string Inscricaoestadual { get => inscricaoestadual; set => inscricaoestadual = value; }
            private string inscricaomunicipal;
            public string Inscricaomunicipal { get => inscricaomunicipal; set => inscricaomunicipal = value; }


            private string estado;
            public string Estado { get => estado; set => estado = value; }
            private string municipio;
            public string Municipio { get => municipio; set => municipio = value; }
            private string bairro;
            public string Bairro { get => bairro; set => bairro = value; }
            private string rua;
            public string Rua { get => rua; set => rua = value; }
            private string numero;
            public string Numero { get => numero; set => numero = value; }


            private string contato1;
            public string Contato1 { get => contato1; set => contato1 = value; }
            private string contato2;
            public string Contato2 { get => contato2; set => contato2 = value; }
            private string observacao1;
            public string Observacao1 { get => observacao1; set => observacao1 = value; }
            private string observacao2;
            public string Observacao2 { get => observacao2; set => observacao2 = value; }
            private string email;
            public string Email { get => email; set => email = value; }
        }
    }
}
