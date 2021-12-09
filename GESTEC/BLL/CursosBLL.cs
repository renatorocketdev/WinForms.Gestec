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
    class CursosBLL
    {
        private static int IDCurso;

        #region Botões Principais

        #region Inserir
        public void Salvar(//Parametros
                          MaterialSingleLineTextField txtNomeCurso,
                          MaskedTextBox txtValorCurso,
                          MaterialSingleLineTextField txtDuracaoCurso,
                          RichTextBox rtDescricaoCurso,
                          MaterialSingleLineTextField txtCategoria)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO CURSO (NOME_CURSO, CATEGORIA_CURSO, DURACAO_CURSO, VALOR_CURSO, DESC_CURSO) " +
                "VALUES (@NOME_CURSO, @CATEGORIA_CURSO, @DURACAO_CURSO, @VALOR_CURSO, @DESC_CURSO)", Conn);

            cmd.Parameters.AddWithValue("NOME_CURSO", txtNomeCurso.Text.Trim());
            cmd.Parameters.AddWithValue("CATEGORIA_CURSO", txtCategoria.Text.Trim());
            cmd.Parameters.AddWithValue("DURACAO_CURSO", txtDuracaoCurso.Text.Trim());
            cmd.Parameters.AddWithValue("VALOR_CURSO", txtValorCurso.Text.Trim());
            cmd.Parameters.AddWithValue("DESC_CURSO", rtDescricaoCurso.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Curso Adicionado com Sucesso");
                //MessageBox.Show("Empresa Adicionada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Salvar Curso: " + ex.Message);
                //MessageBox.Show("Erro ao Salvar Empresa: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Atualizar
        public void Atualizar(//Parametros
                            MaterialSingleLineTextField txtNomeCurso,
                            MaskedTextBox txtValorCurso,
                            MaterialSingleLineTextField txtDuracaoCurso,
                            RichTextBox rtDescricaoCurso,
                            MaterialSingleLineTextField txtCategoria)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            if (IDCurso > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE CURSO SET NOME_CURSO = @NOME_CURSO, CATEGORIA_CURSO = @CATEGORIA_CURSO," +
                    "DURACAO_CURSO = @DURACAO_CURSO, VALOR_CURSO = @VALOR_CURSO, DESC_CURSO = @DESC_CURSO WHERE ID_CURSO = @ID_CURSO", Conn);

                cmd.Parameters.AddWithValue("ID_CURSO", IDCurso);
                cmd.Parameters.AddWithValue("NOME_CURSO", txtNomeCurso.Text.Trim());
                cmd.Parameters.AddWithValue("CATEGORIA_CURSO", txtCategoria.Text.Trim());
                cmd.Parameters.AddWithValue("DURACAO_CURSO", txtDuracaoCurso.Text.Trim());
                cmd.Parameters.AddWithValue("VALOR_CURSO", txtValorCurso.Text.Trim());
                cmd.Parameters.AddWithValue("DESC_CURSO", rtDescricaoCurso.Text.Trim());

                try
                {
                    cmd.ExecuteNonQuery();
                    Sucess.ShowDialog("Atualizado com Sucesso");
                }
                catch (Exception ex)
                { Warning.ShowDialog("Falha ao  Atualizar Curso" + ex.Message); }
            }
        }
        #endregion

        #region Deletar
        public void Deletar(//Parametros
                           MetroGrid DataGridCurso)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM CURSO WHERE ID_CURSO = (@ID_CURSO) ", Conn);
            cmd.Parameters.AddWithValue("ID_CURSO", Convert.ToInt32(DataGridCurso.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Curso Deletado com Sucesso");
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Deletar Curso: " + ex.Message);
            }
        }
        #endregion

        #region Limpar
        public void Limpar(//Parametros
                            MaterialSingleLineTextField txtNomeCurso,
                            MaskedTextBox txtValorCurso,
                            MaterialSingleLineTextField txtDuracaoCurso,
                            RichTextBox rtDescricaoCurso,
                            MaterialSingleLineTextField txtCategoria)
        {
            txtNomeCurso.Text = string.Empty;
            txtValorCurso.Text = string.Empty;
            txtDuracaoCurso.Text = string.Empty;
            rtDescricaoCurso.Text = string.Empty;
            txtCategoria.Text = string.Empty;
        }
        #endregion

        #endregion

        #region GRID

        #region Preenchimento do Grid
        public void PreencherGrid(MetroGrid DataGridCurso)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM CURSO", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<CursosDTO.Curso> Lista = new List<CursosDTO.Curso>();

                while (Dr.Read())
                {
                    Lista.Add(new CursosDTO.Curso
                    {
                        Id_curso = Convert.ToInt32(Dr["ID_CURSO"]),
                        Nome_curso = Dr["NOME_CURSO"].ToString(),
                        Categoria_curso = Dr["CATEGORIA_CURSO"].ToString(),
                        Duracao_curso = Dr["DURACAO_CURSO"].ToString(),
                        Valor_curso = Dr["VALOR_CURSO"].ToString(),
                        Desc_curso = Dr["DESC_CURSO"].ToString(),
                    });

                }
                DataGridCurso.DataSource = Lista;
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
                          MetroGrid DataGridCurso,
                          MaterialSingleLineTextField txtNomeCurso,
                          MaterialSingleLineTextField txtCategoria,
                          MaterialSingleLineTextField txtDuracaoCurso,
                          RichTextBox rtDescricaoCurso,
                          MaskedTextBox txtValorCurso)
        {
            IDCurso = 0;
            IDCurso = Convert.ToInt32(DataGridCurso.CurrentRow.Cells[0].Value);
            txtNomeCurso.Text = DataGridCurso.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = DataGridCurso.CurrentRow.Cells[2].Value.ToString();
            txtDuracaoCurso.Text = DataGridCurso.CurrentRow.Cells[3].Value.ToString();
            txtValorCurso.Text = DataGridCurso.CurrentRow.Cells[4].Value.ToString();
            rtDescricaoCurso.Text = DataGridCurso.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion

        #region Pesquisar
        public DataTable PesquisarCurso(MaterialSingleLineTextField txtBuscarCurso)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM CURSO WHERE (UPPER (NOME_CURSO) LIKE '" + txtBuscarCurso.Text + "%' OR LOWER (NOME_CURSO) LIKE '" + txtBuscarCurso.Text + "%')";

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
    }
}