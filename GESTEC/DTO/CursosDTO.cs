namespace GESTEC.DTO
{
    class CursosDTO
    {
        public class Curso
        {
            private int id_curso;
            private string nome_curso;
            private string categoria_curso;
            private string duracao_curso;
            private string valor_curso;
            private string desc_curso;

            //Getters e Setters:
            public int Id_curso { get => id_curso; set => id_curso = value; }
            public string Nome_curso { get => nome_curso; set => nome_curso = value; }
            public string Categoria_curso { get => categoria_curso; set => categoria_curso = value; }
            public string Duracao_curso { get => duracao_curso; set => duracao_curso = value; }
            public string Valor_curso { get => valor_curso; set => valor_curso = value; }
            public string Desc_curso { get => desc_curso; set => desc_curso = value; }
        }
    }
}