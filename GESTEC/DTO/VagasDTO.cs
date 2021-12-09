namespace GESTEC.DTO
{
    class VagasDTO
    {
       public class Vagas
        {
            private int idvaga;
            public int Idvaga { get => idvaga; set => idvaga = value; }
            private string titulo;
            public string Titulo { get => titulo; set => titulo = value; }
            
            private string salario;
            public string Salario { get => salario; set => salario = value; }
            private string estado;
            public string Estado { get => estado; set => estado = value; }
            private string municipio;
            public string Municipio { get => municipio; set => municipio = value; }
            private string bairro;
            public string Bairro { get => bairro; set => bairro = value; }

            private string descricao;
            public string Descricao { get => descricao; set => descricao = value; }
            private string status;
            public string Status { get => status; set => status = value; }

            private string nomempresa;
            public string Nomempresa { get => nomempresa; set => nomempresa = value; }
            private string cnpj;
            public string Cnpj { get => cnpj; set => cnpj = value; }
            private string cargo;
            public string Cargo { get => cargo; set => cargo = value; }

        }
    }
}
