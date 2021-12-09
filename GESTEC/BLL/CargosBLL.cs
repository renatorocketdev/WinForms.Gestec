using GESTEC.DTO;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace GESTEC.BLL
{
    class CargosBLL
    {
        private static int IDRegistro;

        #region Botões Principais

        #region Metodo Inserir
        public void Inserir
            (
        #region Parametros
                            MaterialSingleLineTextField txtID,
                            MetroComboBox cbbNomeProf,
                            MetroComboBox cbbCPF,
                            MetroComboBox cbbEmpresa,
                            MetroComboBox cbbCargo,
                            MetroComboBox cbbSituacao
        #endregion
            )

        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO CANDIDATURAS (NM_EMPRESA, CARGO, ID_PROFISSIONAL, NOME_PROFISSIONAL, CPF, STATUS) " +
                "VALUES (@NM_EMPRESA, @CARGO, @ID_PROFISSIONAL, @NOME_PROFISSIONAL, @CPF, @STATUS)", Conn);

            cmd.Parameters.AddWithValue("NM_EMPRESA", cbbEmpresa.Text);
            cmd.Parameters.AddWithValue("CARGO", cbbCargo.Text);
            cmd.Parameters.AddWithValue("ID_PROFISSIONAL", txtID.Text);
            cmd.Parameters.AddWithValue("NOME_PROFISSIONAL", cbbNomeProf.Text);
            cmd.Parameters.AddWithValue("CPF", cbbCPF.Text);
            cmd.Parameters.AddWithValue("STATUS", cbbSituacao.Text);

            try
            {
                cmd.ExecuteNonQuery();
                GESTEC.Sucess.ShowDialog("Candidatura Adicionada com Sucesso");
                //MessageBox.Show("Candidatura Adicionada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            catch (Exception ex)
            {
                GESTEC.Warning.ShowDialog("Erro ao Salvar Candidatura: " + ex.Message);
                //MessageBox.Show("Erro ao Salvar Candidatura: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        #endregion

        #region Metodo Deletar
        public void DeletarCandidatura(MetroGrid DataGridStatus)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM CANDIDATURAS WHERE ID_CANDIDATURA = (@ID_CANDIDATURA) ", Conn);
            cmd.Parameters.AddWithValue("ID_CANDIDATURA", Convert.ToInt32(DataGridStatus.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                GESTEC.Sucess.ShowDialog("Candidatura Deletada com Sucesso");
                //MessageBox.Show("Candidatura Deletada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GESTEC.Warning.ShowDialog("Erro ao Deletar Candidatura: " + ex.Message);
                //MessageBox.Show("Erro ao Deletar Candidatura: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodo Atualizar
        public void AtualizarCandidatura
            (
        #region Parametros
                            MaterialSingleLineTextField txtID,
                            MetroComboBox cbbNomeProf,
                            MetroComboBox cbbCPF,
                            MetroComboBox cbbEmpresa,
                            MetroComboBox cbbCargo,
                            MetroComboBox cbbSituacao
        #endregion
            )
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();


            if (IDRegistro > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE CANDIDATURAS SET ID_CANDIDATURA = @ID_CANDIDATURA," +
                    "NM_EMPRESA = @NM_EMPRESA, CARGO = @CARGO, " +
                    "ID_PROFISSIONAL = @ID_PROFISSIONAL, NOME_PROFISSIONAL = @NOME_PROFISSIONAL, CPF = @CPF, " +
                    "STATUS = @STATUS WHERE ID_CANDIDATURA = @ID_CANDIDATURA", Conn);

                cmd.Parameters.AddWithValue("ID_CANDIDATURA", IDRegistro);
                cmd.Parameters.AddWithValue("NM_EMPRESA", cbbEmpresa.Text);
                cmd.Parameters.AddWithValue("CARGO", cbbCargo.Text);
                cmd.Parameters.AddWithValue("ID_PROFISSIONAL", txtID.Text);
                cmd.Parameters.AddWithValue("NOME_PROFISSIONAL", cbbNomeProf.Text);
                cmd.Parameters.AddWithValue("CPF", cbbCPF.Text);
                cmd.Parameters.AddWithValue("STATUS", cbbSituacao.Text);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    GESTEC.Sucess.ShowDialog("Candidatura Atualizada com Sucesso");
                    //MessageBox.Show("Candidatura Atualizada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    GESTEC.Warning.ShowDialog("Error ao Atualizar a Candidatura" + Ex.Message);
                    //MessageBox.Show("Error ao Atualizar a Candidatura" + Ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Metodo Limpar Campos
        public void LimparCampos
            (
        #region Parametros
                            MaterialSingleLineTextField txtID,
                            MetroComboBox cbbNomeProf,
                            MetroComboBox cbbCPF,
                            MetroComboBox cbbEmpresa,
                            MetroComboBox cbbCargo,
                            MetroComboBox cbbSituacao
        #endregion
            )
        {
            txtID.Text = "0";
            cbbNomeProf.SelectedIndex = -1;
            cbbCPF.SelectedIndex = -1;
            cbbEmpresa.SelectedIndex = -1;
            cbbCargo.SelectedIndex = -1;
            cbbSituacao.SelectedIndex = -1;
        }
        #endregion

        #endregion

        #region GRID

        #region Preenchimento do Grid
        public void PrencherGrid(MetroGrid DataGridStatus)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM CANDIDATURAS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<CandidaturasDTO.Candidaturas> Lista = new List<CandidaturasDTO.Candidaturas>();

                while (Dr.Read())
                {
                    Lista.Add(new CandidaturasDTO.Candidaturas
                    {
                        Idcandidatura = Convert.ToInt32(Dr["ID_CANDIDATURA"]),
                        Nm_empresa = Dr["NM_EMPRESA"].ToString(),
                        Cargo = Dr["CARGO"].ToString(),
                        Idprofissional = Dr["ID_PROFISSIONAL"].ToString(),
                        Nome = Dr["NOME_PROFISSIONAL"].ToString(),
                        Cpf = Dr["CPF"].ToString(),
                        Status = Dr["STATUS"].ToString()

                    });
                }
                DataGridStatus.DataSource = Lista;
            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        #region Passar Valores do Grid para os TextBox
        public void GridToText
            (
        #region Parametros
                            MetroGrid DataGridStatus,
                            MaterialSingleLineTextField txtID,
                            MetroComboBox cbbNomeProf,
                            MetroComboBox cbbCPF,
                            MetroComboBox cbbEmpresa,
                            MetroComboBox cbbCargo,
                            MetroComboBox cbbSituacao
        #endregion
            )
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(DataGridStatus.CurrentRow.Cells[0].Value);
            txtID.Text = DataGridStatus.CurrentRow.Cells[3].Value.ToString();
            cbbNomeProf.Text = DataGridStatus.CurrentRow.Cells[4].Value.ToString();
            cbbCPF.Text = DataGridStatus.CurrentRow.Cells[5].Value.ToString();
            cbbEmpresa.Text = DataGridStatus.CurrentRow.Cells[1].Value.ToString();
            cbbCargo.Text = DataGridStatus.CurrentRow.Cells[2].Value.ToString();
            cbbSituacao.Text = DataGridStatus.CurrentRow.Cells[6].Value.ToString();
        }
        #endregion

        #endregion

        #region Pesquisar

        #region CPF
        public DataTable PesquisarCargo(MaterialSingleLineTextField txtCargo)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM CANDIDATURAS WHERE CARGO LIKE '" + txtCargo.Text + "%'";

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

        #region 
        public DataTable PesquisarCPF(MaterialSingleLineTextField txtCPF)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM CANDIDATURAS WHERE CPF LIKE '" + txtCPF.Text + "%'";

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