using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTEC.DTO
{
    class AlunosDTO
    {
        public class Alunos
        {
            private int id_aluno;
            private string nome_aluno;
            private string curso_aluno;
            private string modulo_atual;
            private string status_curso;
            private string concluiu_curso;
            private string email_aluno;
            private string contato_aluno;
            private string data_matricula;

            //Getters e Setters:
            public int Id_aluno { get => id_aluno; set => id_aluno = value; }
            public string Nome_aluno { get => nome_aluno; set => nome_aluno = value; }
            public string Curso_aluno { get => curso_aluno; set => curso_aluno = value; }
            public string Modulo_atual { get => modulo_atual; set => modulo_atual = value; }
            public string Status_curso { get => status_curso; set => status_curso = value; }
            public string Concluiu_curso { get => concluiu_curso; set => concluiu_curso = value; }
            public string Email_aluno { get => email_aluno; set => email_aluno = value; }
            public string Contato_aluno { get => contato_aluno; set => contato_aluno = value; }
            public string Data_matricula { get => data_matricula; set => data_matricula = value; }
        }
    }
}
