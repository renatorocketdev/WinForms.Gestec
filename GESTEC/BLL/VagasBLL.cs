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
    class VagasBLL
    {
        private static int IDRegistro;
        public static NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");

        #region Botões Principais

        #region Metodo Inserir
        public void Inserir
            (
        #region Parametros
                            MaterialSingleLineTextField txtTitulo, MaskedTextBox txtSalario,
                            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio,
                            MaterialSingleLineTextField txtBairro, RichTextBox rtSobre,
                            MetroComboBox cbbStatus, MetroComboBox cbbNomeEmpresa, MetroComboBox cbbCNPJ,
                            MaterialSingleLineTextField txtCargo
        #endregion
            )
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO VAGAS (TITULO, SALARIO, ESTADO, MUNICIPIO, BAIRRO, DESCRICAO, STATUS, NM_EMPRESA, CNPJ, CARGO) " +
                "VALUES (@TITULO, @SALARIO, @ESTADO, @MUNICIPIO, @BAIRRO, @DESCRICAO, @STATUS, @NM_EMPRESA, @CNPJ, @CARGO)", Conn);

            cmd.Parameters.AddWithValue("TITULO", txtTitulo.Text);
            cmd.Parameters.AddWithValue("SALARIO", txtSalario.Text);
            cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text);
            cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text);
            cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
            cmd.Parameters.AddWithValue("DESCRICAO", rtSobre.Text);
            cmd.Parameters.AddWithValue("STATUS", cbbStatus.Text);
            cmd.Parameters.AddWithValue("NM_EMPRESA", cbbNomeEmpresa.Text);
            cmd.Parameters.AddWithValue("CNPJ", cbbCNPJ.Text);
            cmd.Parameters.AddWithValue("CARGO", txtCargo.Text);

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Vaga Adicionada com Sucesso");
            }
            catch (Exception ex)
            { Warning.ShowDialog("Erro ao Salvar Vaga: " + ex.Message); }

        }
        #endregion

        #region Metodo Atualizar
        public void AtualizaVaga(
                            MaterialSingleLineTextField txtTitulo, MaskedTextBox txtSalario,
                            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio,
                            MaterialSingleLineTextField txtBairro, RichTextBox rtSobre,
                            MetroComboBox cbbStatus, MetroComboBox cbbNomeEmpresa, MetroComboBox cbbCNPJ,
                            MaterialSingleLineTextField txtCargo)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();


            if (IDRegistro > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE VAGAS SET " +
                    "TITULO = @TITULO, SALARIO = @SALARIO, " +
                    "ESTADO = @ESTADO, MUNICIPIO = @MUNICIPIO, BAIRRO = @BAIRRO, " +
                    "DESCRICAO = @DESCRICAO, STATUS = @STATUS, NM_EMPRESA = @NM_EMPRESA, CNPJ = @CNPJ, CARGO = @CARGO " +
                    "WHERE ID_VAGA = @ID_VAGA", Conn);

                cmd.Parameters.AddWithValue("ID_VAGA", IDRegistro);
                cmd.Parameters.AddWithValue("TITULO", txtTitulo.Text);
                cmd.Parameters.AddWithValue("SALARIO", txtSalario.Text);
                cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text);
                cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("DESCRICAO", rtSobre.Text);
                cmd.Parameters.AddWithValue("STATUS", cbbStatus.Text);
                cmd.Parameters.AddWithValue("NM_EMPRESA", cbbNomeEmpresa.Text);
                cmd.Parameters.AddWithValue("CNPJ", cbbCNPJ.Text);
                cmd.Parameters.AddWithValue("CARGO", txtCargo.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    Sucess.ShowDialog("Vaga Atualizada com Sucesso");
                }
                catch (Exception Ex) { Warning.ShowDialog("Error ao Atualizar Vaga" + Ex.Message); }
            }
        }
        #endregion

        #region Metodo Deletar
        public void DeletaVaga(MetroGrid DataGridVagas)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM VAGAS WHERE ID_VAGA = (@ID_VAGA) ", Conn);
            cmd.Parameters.AddWithValue("ID_VAGA", Convert.ToInt32(DataGridVagas.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Vaga Deletada com Sucesso");
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Deletar Vaga: " + ex.Message);
            }

        }
        #endregion

        #region Limpar Campos
        public void LimparCampos
            (
        #region Parametros
                            MaterialSingleLineTextField txtTitulo, MaskedTextBox txtSalario,
                            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio,
                            MaterialSingleLineTextField txtBairro, RichTextBox rtSobre,
                            MetroComboBox cbbStatus, MetroComboBox cbbNomeEmpresa, MetroComboBox cbbCNPJ,
                            MaterialSingleLineTextField txtCargo
        #endregion
            )
        {
            txtTitulo.Text = string.Empty;
            txtSalario.Text = string.Empty;
            cbbEstado.SelectedIndex = -1;
            cbbMunicipio.SelectedIndex = -1;
            txtBairro.Text = string.Empty;
            rtSobre.Text = string.Empty;
            cbbStatus.SelectedIndex = -1;
            cbbNomeEmpresa.SelectedIndex = -1;
            cbbCNPJ.SelectedIndex = -1;
            txtCargo.Text = string.Empty;
        }
        #endregion

        #endregion

        #region GRID

        #region Preenchimento do Grid
        public void EncherGrid(MetroGrid dgVagas)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM VAGAS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<VagasDTO.Vagas> Lista = new List<VagasDTO.Vagas>();

                while (Dr.Read())
                {
                    Lista.Add(new VagasDTO.Vagas
                    {
                        Idvaga = Convert.ToInt32(Dr["ID_VAGA"]),
                        Titulo = Dr["TITULO"].ToString(),
                        Salario = Dr["SALARIO"].ToString(),
                        Estado = Dr["ESTADO"].ToString(),
                        Municipio = Dr["MUNICIPIO"].ToString(),
                        Bairro = Dr["BAIRRO"].ToString(),
                        Descricao = Dr["DESCRICAO"].ToString(),
                        Status = Dr["STATUS"].ToString(),
                        Nomempresa = Dr["NM_EMPRESA"].ToString(),
                        Cnpj = Dr["CNPJ"].ToString(),
                        Cargo = Dr["CARGO"].ToString()
                    });
                }
                dgVagas.DataSource = Lista;

                Conn.Close();
            }
            catch (Exception Ex)
            { Warning.ShowDialog(Ex.Message); }
        }
        #endregion

        #region Passar Valores do Grid para os TextBox
        public void GridTotxt
            (
        #region Parametros
                            MetroGrid dgVagas,
                            MaterialSingleLineTextField txtTitulo, MaskedTextBox txtSalario,
                            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio,
                            MaterialSingleLineTextField txtBairro, RichTextBox rtSobre,
                            MetroComboBox cbbStatus, MetroComboBox cbbNomeEmpresa, MetroComboBox cbbCNPJ,
                            MaterialSingleLineTextField txtCargo
        #endregion
            )
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(dgVagas.CurrentRow.Cells[0].Value);
            txtTitulo.Text = dgVagas.CurrentRow.Cells[1].Value.ToString();
            txtSalario.Text = dgVagas.CurrentRow.Cells[2].Value.ToString();
            cbbEstado.Text = dgVagas.CurrentRow.Cells[3].Value.ToString();
            cbbMunicipio.Text = dgVagas.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = dgVagas.CurrentRow.Cells[5].Value.ToString();
            rtSobre.Text = dgVagas.CurrentRow.Cells[6].Value.ToString();
            cbbStatus.Text = dgVagas.CurrentRow.Cells[7].Value.ToString();
            cbbNomeEmpresa.Text = dgVagas.CurrentRow.Cells[8].Value.ToString();
            cbbCNPJ.Text = dgVagas.CurrentRow.Cells[9].Value.ToString();
            txtCargo.Text = dgVagas.CurrentRow.Cells[10].Value.ToString();

        }

        #endregion

        #endregion

        #region Pesquisar

        #region ID
        public DataTable PesquisarNomeEmpresa(MaterialSingleLineTextField txtBuscarEmpresa)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM VAGAS WHERE nm_empresa LIKE '" + txtBuscarEmpresa.Text + "%'";

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

        #region Cargo
        public DataTable PesquisarCargoEmpresa(MaterialSingleLineTextField txtBuscarCargo)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM VAGAS WHERE (UPPER (CARGO) LIKE '" + txtBuscarCargo.Text + "%' OR LOWER (CARGO) LIKE '" + txtBuscarCargo.Text + "%')";

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