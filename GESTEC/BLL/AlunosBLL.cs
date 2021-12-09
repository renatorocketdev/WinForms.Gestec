using GESTEC.DTO;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.BLL
{
    class AlunosBLL
    {
        private static int IDAluno;
        private static bool valor;
        string valor_radioButton;

        #region Botões Principais

        #region Inserir
        public void Inserir(//Parametros
                          MaterialSingleLineTextField txtID,
                          MaterialSingleLineTextField txtNomeAluno,
                          MaterialSingleLineTextField txtCursando,
                          MaterialSingleLineTextField txtModulo,
                          MaterialSingleLineTextField txtStatus,
                          MaskedTextBox txtDataMatricula,
                          MaterialSingleLineTextField txtEmail,
                          MaskedTextBox txtContato,
                          MetroRadioButton rdbSim,
                          MetroRadioButton rdbNao)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO ALUNOS (NOME_ALUNO, CURSO_ALUNO, MODULO_ATUAL, STATUS_CURSO, DATA_MATRICULA, EMAIL_ALUNO, CONTATO_ALUNO, CONCLUIU_CURSO) " +
                "VALUES (@NOME_ALUNO, @CURSO_ALUNO, @MODULO_ATUAL, @STATUS_CURSO, @DATA_MATRICULA, @EMAIL_ALUNO, @CONTATO_ALUNO, @CONCLUIU_CURSO)", Conn);

            cmd.Parameters.AddWithValue("NOME_ALUNO", txtNomeAluno.Text.Trim());
            cmd.Parameters.AddWithValue("CURSO_ALUNO", txtCursando.Text.Trim());
            cmd.Parameters.AddWithValue("MODULO_ATUAL", txtModulo.Text.Trim());
            cmd.Parameters.AddWithValue("STATUS_CURSO", txtStatus.Text.Trim());
            cmd.Parameters.AddWithValue("DATA_MATRICULA", txtDataMatricula.Text.Trim());
            cmd.Parameters.AddWithValue("EMAIL_ALUNO", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("CONTATO_ALUNO", txtContato.Text.Trim());

            valor = GESTEC.Forms.Formulários_de_Cadastro.Alunos.ValorRDB;
            if(valor == true)
            {
                cmd.Parameters.AddWithValue("CONCLUIU_CURSO", "Sim");
            }
            else
            {
                cmd.Parameters.AddWithValue("CONCLUIU_CURSO", "Não");
            }            

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Aluno Adicionado com Sucesso");

                Limpar(txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbSim, rdbNao);
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Salvar Aluno: " + ex.Message);
            }
        }
        #endregion

        #region Atualizar
        public void Atualizar(//Parametros
                          MaterialSingleLineTextField txtID,
                          MaterialSingleLineTextField txtNomeAluno,
                          MaterialSingleLineTextField txtCursando,
                          MaterialSingleLineTextField txtModulo,
                          MaterialSingleLineTextField txtStatus,
                          MaskedTextBox txtDataMatricula,
                          MaterialSingleLineTextField txtEmail,
                          MaskedTextBox txtContato,
                          MetroRadioButton rdbSim,
                          MetroRadioButton rdbNao)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            if (IDAluno > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE ALUNOS SET NOME_ALUNO = @NOME_ALUNO, CURSO_ALUNO = @CURSO_ALUNO, MODULO_ATUAL = @MODULO_ATUAL, STATUS_CURSO = @STATUS_CURSO, DATA_MATRICULA = @DATA_MATRICULA, EMAIL_ALUNO = @EMAIL_ALUNO, CONTATO_ALUNO = @CONTATO_ALUNO, CONCLUIU_CURSO = @CONCLUIU_CURSO WHERE ID_ALUNO = @ID_ALUNO", Conn);

                cmd.Parameters.AddWithValue("ID_ALUNO", IDAluno);
                cmd.Parameters.AddWithValue("NOME_ALUNO", txtNomeAluno.Text.Trim());
                cmd.Parameters.AddWithValue("CURSO_ALUNO", txtCursando.Text.Trim());
                cmd.Parameters.AddWithValue("MODULO_ATUAL", txtModulo.Text.Trim());
                cmd.Parameters.AddWithValue("STATUS_CURSO", txtStatus.Text.Trim());
                cmd.Parameters.AddWithValue("DATA_MATRICULA", txtDataMatricula.Text.Trim());
                cmd.Parameters.AddWithValue("EMAIL_ALUNO", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("CONTATO_ALUNO", txtContato.Text.Trim());

                valor = GESTEC.Forms.Formulários_de_Cadastro.Alunos.ValorRDB;
                if (valor == true)
                {
                    cmd.Parameters.AddWithValue("CONCLUIU_CURSO", "Sim");
                }
                else
                {
                    cmd.Parameters.AddWithValue("CONCLUIU_CURSO", "Não");
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    Sucess.ShowDialog("Atualizado com Sucesso");

                    Limpar(txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbSim, rdbNao);
                }
                catch (Exception ex)
                { Warning.ShowDialog("Falha ao  Atualizar Curso" + ex.Message); }
            }
        }
        #endregion

        #region Deletar
        public void Deletar(//Parametros
                           MetroGrid DataGridAluno)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM ALUNOS WHERE ID_ALUNO = (@ID_ALUNO) ", Conn);
            cmd.Parameters.AddWithValue("ID_ALUNO", Convert.ToInt32(DataGridAluno.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Aluno Deletado com Sucesso");
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Deletar Aluno: " + ex.Message);
            }
        }
        #endregion

        #region Limpar
        public void Limpar(//Parametros
                          MaterialSingleLineTextField txtID,
                          MaterialSingleLineTextField txtNomeAluno,
                          MaterialSingleLineTextField txtCursando,
                          MaterialSingleLineTextField txtModulo,
                          MaterialSingleLineTextField txtStatus,
                          MaskedTextBox txtDataMatricula,
                          MaterialSingleLineTextField txtEmail,
                          MaskedTextBox txtContato,
                          MetroRadioButton rdbSim,
                          MetroRadioButton rdbNao)
        {
            txtID.Text = string.Empty;
            txtNomeAluno.Text = string.Empty;
            txtCursando.Text = string.Empty;
            txtModulo.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtDataMatricula.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContato.Text = string.Empty;
            rdbNao.Checked = true;
        }
        #endregion

        #endregion

        #region GRID
        #region Preenchimento do Grid
        public void PreencherGrid(MetroGrid DataGridAluno)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM ALUNOS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<AlunosDTO.Alunos> Lista = new List<AlunosDTO.Alunos>();

                while (Dr.Read())
                {
                    Lista.Add(new AlunosDTO.Alunos
                    {
                        Id_aluno = Convert.ToInt32(Dr["ID_ALUNO"]),
                        Nome_aluno = Dr["NOME_ALUNO"].ToString(),
                        Curso_aluno = Dr["CURSO_ALUNO"].ToString(),
                        Modulo_atual = Dr["MODULO_ATUAL"].ToString(),
                        Status_curso = Dr["STATUS_CURSO"].ToString(),
                        Data_matricula = Dr["DATA_MATRICULA"].ToString(),
                        Email_aluno = Dr["EMAIL_ALUNO"].ToString(),
                        Contato_aluno = Dr["CONTATO_ALUNO"].ToString(),
                        Concluiu_curso = Dr["CONCLUIU_CURSO"].ToString(),
                    });

                }
                DataGridAluno.DataSource = Lista;
            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GridToText
        public void GridToText(//Parametros
                          MetroGrid DataGridAluno,
                          MaterialSingleLineTextField txtID,
                          MaterialSingleLineTextField txtNomeAluno,
                          MaterialSingleLineTextField txtCursando,
                          MaterialSingleLineTextField txtModulo,
                          MaterialSingleLineTextField txtStatus,
                          MaskedTextBox txtDataMatricula,
                          MaterialSingleLineTextField txtEmail,
                          MaskedTextBox txtContato,
                          MetroRadioButton rdbSim,
                          MetroRadioButton rdbNao)
        {
            

            IDAluno = 0;
            IDAluno = Convert.ToInt32(DataGridAluno.CurrentRow.Cells[0].Value);
            txtNomeAluno.Text = DataGridAluno.CurrentRow.Cells[1].Value.ToString();
            txtCursando.Text = DataGridAluno.CurrentRow.Cells[2].Value.ToString();
            txtModulo.Text = DataGridAluno.CurrentRow.Cells[3].Value.ToString();
            txtStatus.Text = DataGridAluno.CurrentRow.Cells[4].Value.ToString();           
            txtEmail.Text = DataGridAluno.CurrentRow.Cells[6].Value.ToString();
            txtContato.Text = DataGridAluno.CurrentRow.Cells[7].Value.ToString();
            txtDataMatricula.Text = DataGridAluno.CurrentRow.Cells[8].Value.ToString();
            valor_radioButton = DataGridAluno.CurrentRow.Cells[5].Value.ToString();

            if (valor_radioButton == "Sim")
            {
                rdbSim.Checked = true;
                rdbNao.Checked = false;
            }
            else
            {
                rdbNao.Checked = true;
                rdbSim.Checked = false;
            }
        }
        #endregion

        #region Pesquisar

        #region Aluno
        public DataTable PesquisarAluno(MaterialSingleLineTextField txtBuscarAluno)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM ALUNOS WHERE (UPPER (NOME_ALUNO) LIKE '" + txtBuscarAluno.Text + "%' OR LOWER (NOME_ALUNO) LIKE '" + txtBuscarAluno.Text + "%')";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Conn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        #endregion

        #region Curso
        public DataTable PesquisarCurso(MaterialSingleLineTextField txtBuscarCurso)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM ALUNOS WHERE (UPPER (CURSO_ALUNO) LIKE '" + txtBuscarCurso.Text + "%' OR LOWER (CURSO_ALUNO) LIKE '" + txtBuscarCurso.Text + "%')";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Conn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #endregion
        #endregion
    }
}
