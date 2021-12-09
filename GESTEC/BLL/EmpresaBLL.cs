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
    class EmpresaBLL
    {
        private static int IDRegistro;

        #region Botões Principais

        #region Metodo Inserir
        public void Inserir(//Parametros
                           MaskedTextBox txtCNPJ,
                           MaterialSingleLineTextField txtInscEstadual,
                           MaterialSingleLineTextField txtInscMunicipal,
                           MaterialSingleLineTextField txtRazaoSocial,
                           MaterialSingleLineTextField txtNomeFantasia,
                           
                           MaterialSingleLineTextField txtRua,
                           MaterialSingleLineTextField txtNumero,
                           MaterialSingleLineTextField txtBairro,
                           MetroComboBox cbbEstado,
                           MetroComboBox cbbMunicipio,

                           MaskedTextBox txtContato1,
                           MaskedTextBox txtContato2,
                           MaterialSingleLineTextField txtObservacao1,
                           MaterialSingleLineTextField txtObservacao2,
                           MaterialSingleLineTextField txtEmail)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO EMPRESAS (CNPJ, INSC_EST, INSC_MUN, RZ_SOCIAL, NM_FANTASIA, ESTADO, MUNICIPIO, BAIRRO, RUA, NUMERO, CONTATO1, CONTATO2, OBSERVACAO1, OBSERVACAO2, EMAIL) " +
                "VALUES (@CNPJ, @INSC_EST, @INSC_MUN, @RZ_SOCIAL, @NM_FANTASIA, @ESTADO, @MUNICIPIO, @BAIRRO, @RUA, @NUMERO, @CONTATO1, @CONTATO2, @OBSERVACAO1, @OBSERVACAO2, @EMAIL)", Conn);

            cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);
            cmd.Parameters.AddWithValue("INSC_EST", txtInscEstadual.Text);
            cmd.Parameters.AddWithValue("INSC_MUN", txtInscMunicipal.Text);
            cmd.Parameters.AddWithValue("RZ_SOCIAL", txtRazaoSocial.Text.Trim());
            cmd.Parameters.AddWithValue("NM_FANTASIA", txtNomeFantasia.Text.Trim());
            cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text.Trim());
            cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text.Trim());
            cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text.Trim());
            cmd.Parameters.AddWithValue("RUA", txtRua.Text.Trim());
            cmd.Parameters.AddWithValue("NUMERO", txtNumero.Text.Trim());
            cmd.Parameters.AddWithValue("CONTATO1", txtContato1.Text.Trim());
            cmd.Parameters.AddWithValue("CONTATO2", txtContato2.Text.Trim());
            cmd.Parameters.AddWithValue("OBSERVACAO1", txtObservacao1.Text.Trim());
            cmd.Parameters.AddWithValue("OBSERVACAO2", txtObservacao2.Text.Trim());
            cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Empresa Adicionada com Sucesso");
                //MessageBox.Show("Empresa Adicionada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Salvar Empresa: " + ex.Message);
                //MessageBox.Show("Erro ao Salvar Empresa: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodo Deletar
        public void DeletarEmpresa(MetroGrid DataGridEmpresa)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM EMPRESAS WHERE ID_EMPRESA = (@ID_EMPRESA) ", Conn);
            cmd.Parameters.AddWithValue("ID_EMPRESA", Convert.ToInt32(DataGridEmpresa.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                GESTEC.Sucess.ShowDialog("Empresa Deletado com Sucesso");
                //MessageBox.Show("Empresa Deletado com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GESTEC.Warning.ShowDialog("Erro ao Deletar Empresa: " + ex.Message);
                //MessageBox.Show("Erro ao Deletar Empresa: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodo Atualizar
        public void AtualizarEmpresa(
            MaskedTextBox txtCNPJ, 
            MaterialSingleLineTextField txtInscEstadual, MaterialSingleLineTextField txtInscMunicipal,           
            MaterialSingleLineTextField txtRazaoSocial, MaterialSingleLineTextField txtNomeFantasia, MetroComboBox cbbEstado,
            MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro, MaterialSingleLineTextField txtRua,
            MaterialSingleLineTextField txtNumero, MaskedTextBox txtContato1, MaskedTextBox txtContato2,
            MaterialSingleLineTextField txtObservacao1, MaterialSingleLineTextField txtObservacao2, MaterialSingleLineTextField txtEmail)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();


            if (IDRegistro > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE EMPRESAS SET " +
                    "CNPJ = @CNPJ, INSC_EST = @INSC_EST, INSC_MUN = @INSC_MUN,  RZ_SOCIAL = @RZ_SOCIAL, NM_FANTASIA = @NM_FANTASIA, " +
                    "ESTADO = @ESTADO, MUNICIPIO = @MUNICIPIO, OBSERVACAO1 = @OBSERVACAO1, OBSERVACAO2 = @OBSERVACAO2, " +
                    "NUMERO = @NUMERO, CONTATO1 = @CONTATO1, CONTATO2 = @CONTATO2, EMAIL = @EMAIL " +
                    "WHERE ID_EMPRESA = @ID_EMPRESA", Conn);

                cmd.Parameters.AddWithValue("ID_EMPRESA", IDRegistro);
                cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("INSC_EST", txtInscEstadual.Text);
                cmd.Parameters.AddWithValue("INSC_MUN", txtInscMunicipal.Text);
                cmd.Parameters.AddWithValue("RZ_SOCIAL", txtRazaoSocial.Text.Trim());
                cmd.Parameters.AddWithValue("NM_FANTASIA", txtNomeFantasia.Text.Trim());
                cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text.Trim());
                cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text.Trim());
                cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text.Trim());
                cmd.Parameters.AddWithValue("RUA", txtRua.Text.Trim());
                cmd.Parameters.AddWithValue("NUMERO", txtNumero.Text.Trim());
                cmd.Parameters.AddWithValue("CONTATO1", txtContato1.Text.Trim());
                cmd.Parameters.AddWithValue("CONTATO2", txtContato2.Text.Trim());
                cmd.Parameters.AddWithValue("OBSERVACAO1", txtObservacao1.Text.Trim());
                cmd.Parameters.AddWithValue("OBSERVACAO2", txtObservacao2.Text.Trim());
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text.Trim());

                try
                {
                    cmd.ExecuteNonQuery();
                    GESTEC.Sucess.ShowDialog("Empresa Atualizada com Sucesso");
                    //MessageBox.Show("Empresa Atualizada com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    GESTEC.Warning.ShowDialog("Error ao  Atualizar Empresa: " + Ex.Message);
                    //MessageBox.Show("Error ao  Atualizar Empresa: " + Ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Metodo Limpa Campos
        public void LimparCampos(//Parametros
                          MaskedTextBox txtCNPJ, MaterialSingleLineTextField txtInscEstadual, MaterialSingleLineTextField txtInscMunicipal,
                          MaterialSingleLineTextField txtRazaoSocial, MaterialSingleLineTextField txtNomeFantasia, MetroComboBox cbbEstado,
                          MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro, MaterialSingleLineTextField txtRua,
                          MaterialSingleLineTextField txtNumero, MaskedTextBox txtContato1, MaskedTextBox txtContato2,
                          MaterialSingleLineTextField txtObservacao1, MaterialSingleLineTextField txtObservacao2, MaterialSingleLineTextField txtEmail, MaterialCheckBox materialCheckBox1)
        {
            txtCNPJ.Text = string.Empty;
            txtInscEstadual.Text = string.Empty;
            txtInscMunicipal.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            cbbEstado.SelectedIndex = -1;
            cbbMunicipio.SelectedIndex = -1;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtContato1.Text = string.Empty;
            txtContato2.Text = string.Empty;
            txtObservacao1.Text = string.Empty;
            txtObservacao2.Text = string.Empty;
            txtEmail.Text = string.Empty;
            materialCheckBox1.Checked = false;
        }
        #endregion
       
        #endregion

        #region Grid

        #region Preenchimento do Grid
        public void EncherGrid(MetroGrid DataGridEmpresa)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM EMPRESAS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<EmpresaDTO.Empresa> Lista = new List<EmpresaDTO.Empresa>();

                while (Dr.Read())
                {
                    Lista.Add(new EmpresaDTO.Empresa
                    {
                        Id = Convert.ToInt32(Dr["ID_EMPRESA"]),
                        Razaosocial = Dr["RZ_SOCIAL"].ToString(),
                        Nomefantasia = Dr["NM_FANTASIA"].ToString(),
                        Cnpj = Dr["CNPJ"].ToString(),
                        Inscricaoestadual = Dr["INSC_EST"].ToString(),
                        Inscricaomunicipal = Dr["INSC_MUN"].ToString(),
                        Estado = Dr["ESTADO"].ToString(),
                        Municipio = Dr["MUNICIPIO"].ToString(),
                        Bairro = Dr["BAIRRO"].ToString(),
                        Rua = Dr["RUA"].ToString(),
                        Numero = Dr["NUMERO"].ToString(),
                        Contato1 = Dr["CONTATO1"].ToString(),
                        Contato2 = Dr["CONTATO2"].ToString(),
                        Observacao1 = Dr["OBSERVACAO1"].ToString(),
                        Observacao2 = Dr["OBSERVACAO2"].ToString(),
                        Email = Dr["EMAIL"].ToString(),
                    });

                }
                DataGridEmpresa.DataSource = Lista;
            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Passar Valores do Grid para os TextBox
        public void GridToTxt(MetroGrid DataGridEmpresa, MaskedTextBox txtCNPJ, MaterialSingleLineTextField txtInscEstadual, MaterialSingleLineTextField txtInscMunicipal,
                          MaterialSingleLineTextField txtRazaoSocial, MaterialSingleLineTextField txtNomeFantasia, MetroComboBox cbbEstado,
                          MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro, MaterialSingleLineTextField txtRua,
                          MaterialSingleLineTextField txtNumero, MaskedTextBox txtContato1, MaskedTextBox txtContato2,
                          MaterialSingleLineTextField txtObservacao1, MaterialSingleLineTextField txtObservacao2, MaterialSingleLineTextField txtEmail)
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(DataGridEmpresa.CurrentRow.Cells[0].Value);
            txtRazaoSocial.Text = DataGridEmpresa.CurrentRow.Cells[1].Value.ToString();
            txtNomeFantasia.Text = DataGridEmpresa.CurrentRow.Cells[2].Value.ToString();
            txtCNPJ.Text = DataGridEmpresa.CurrentRow.Cells[3].Value.ToString();
            txtInscEstadual.Text = DataGridEmpresa.CurrentRow.Cells[4].Value.ToString();
            txtInscMunicipal.Text = DataGridEmpresa.CurrentRow.Cells[5].Value.ToString();           
            cbbEstado.Text = DataGridEmpresa.CurrentRow.Cells[6].Value.ToString();
            cbbMunicipio.Text = DataGridEmpresa.CurrentRow.Cells[7].Value.ToString();
            txtBairro.Text = DataGridEmpresa.CurrentRow.Cells[8].Value.ToString();
            txtRua.Text = DataGridEmpresa.CurrentRow.Cells[9].Value.ToString();
            txtNumero.Text = DataGridEmpresa.CurrentRow.Cells[10].Value.ToString();
            txtContato1.Text = DataGridEmpresa.CurrentRow.Cells[11].Value.ToString();
            txtContato2.Text = DataGridEmpresa.CurrentRow.Cells[12].Value.ToString();
            txtObservacao1.Text = DataGridEmpresa.CurrentRow.Cells[13].Value.ToString();
            txtObservacao2.Text = DataGridEmpresa.CurrentRow.Cells[14].Value.ToString();
            txtEmail.Text = DataGridEmpresa.CurrentRow.Cells[15].Value.ToString();
        }
        #endregion

        #endregion

        #region Pesquisa

        #region CNPJ
        public DataTable PesquisarCNPJEmpresa(MaterialSingleLineTextField txtBuscarCNPJ)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM EMPRESAS WHERE CNPJ LIKE '" + txtBuscarCNPJ.Text + "%'";

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

        #region Nome
        public DataTable PesquisarNomeEmpresa(MaterialSingleLineTextField txtBuscarNome)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM EMPRESAS WHERE (UPPER (rz_social) LIKE '" + txtBuscarNome.Text + "%' OR LOWER (rz_social) LIKE '" + txtBuscarNome.Text + "%' OR UPPER (nm_fantasia) LIKE '" + txtBuscarNome.Text + "%' OR LOWER (nm_fantasia) LIKE '" + txtBuscarNome.Text + "%')";

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