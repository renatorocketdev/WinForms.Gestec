using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTEC.DTO
{
    class CandidaturasDTO
    {
        public class Candidaturas
        {
            private int idcandidatura;
            public int Idcandidatura { get => idcandidatura; set => idcandidatura = value; }

            private string nm_empresa;
            public string Nm_empresa { get => nm_empresa; set => nm_empresa = value; }
            private string cargo;
            public string Cargo { get => cargo; set => cargo = value; }

            private string idprofissional;
            public string Idprofissional { get => idprofissional; set => idprofissional = value; }
            private string nome;
            public string Nome { get => nome; set => nome = value; }
            private string cpf;
            public string Cpf { get => cpf; set => cpf = value; }

            private string status;
            public string Status { get => status; set => status = value; }
            
        }
    }
}
