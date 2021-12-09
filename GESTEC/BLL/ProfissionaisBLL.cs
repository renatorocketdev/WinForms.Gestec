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
    class ProfissionaisBLL
    {
        private static int IDRegistro;

        #region Botões Principais

        #region Metodo Inserir
        public void Salvar(
            MaterialSingleLineTextField txtNomeCompleto, MaskedTextBox txtDataNascimento,
            MaskedTextBox txtCPF, MaterialSingleLineTextField txtRG, MaskedTextBox txtPIS, MaterialSingleLineTextField txtEstadoCivil,
            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro,
            MaterialSingleLineTextField txtRua, MaskedTextBox txtCEP,
            MetroComboBox cbbDiabete, MetroComboBox cbbPcd, MetroComboBox cbbCNH, MetroComboBox cbbCatCnh,
            MetroComboBox cbbTituloEleitoral, MetroComboBox cbbReservista,
            MetroComboBox cbbEscolaridade, MaskedTextBox txtConclusao,
            MaterialSingleLineTextField txtFaculdade, MaterialSingleLineTextField txtCursoFaculdade,
            MaterialSingleLineTextField txtCurso1, MetroComboBox cbbSituacao1,
            MaterialSingleLineTextField txtCurso2, MetroComboBox cbbSituacao2,
            MaterialSingleLineTextField txtCurso3, MetroComboBox cbbSituacao3,
            MaterialSingleLineTextField txtEmpresa1, MaterialSingleLineTextField txtCargo1,
            MaskedTextBox txtAdmissao1, MaskedTextBox txtSaida1,
            RichTextBox rtAtividades1, RichTextBox rtMotivoSaida1,
            MaterialSingleLineTextField txtEmpresa2, MaterialSingleLineTextField txtCargo2,
            MaskedTextBox txtAdmissao2, MaskedTextBox txtSaida2,
            RichTextBox rtAtividades2, RichTextBox rtMotivoSaida2,
            MaterialSingleLineTextField txtEmpresa3, MaterialSingleLineTextField txtCargo3,
            MaskedTextBox txtAdmissao3, MaskedTextBox txtSaida3,
            RichTextBox rtAtividades3, RichTextBox rtMotivoSaida3,
            MaskedTextBox txtContato1, MaskedTextBox txtContato2,
            MaterialSingleLineTextField txtEmail)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("" +
                "INSERT INTO PROFISSIONAIS " +
                "(NOME, NASCIMENTO, CPF, RG, PIS, ESTADO_CIVIL, ESTADO, MUNICIPIO, BAIRRO, RUA, CEP, " +
                "DIABETES, PCD, CNH, CAT_CNH, RESERVISTA, TITULO," +
                "ESCOLARIDADE, CONCLUSAO, FACULDADE, CURSO," +
                "CURSO1, CURSO2, CURSO3, SITUACAO1, SITUACAO2, SITUACAO3, " +
                "EMPRESA1, CARGO1, ADMISSAO1, SAIDA1, ATIVIDADES1, MOTIVO1," +
                "EMPRESA2, CARGO2, ADMISSAO2, SAIDA2, ATIVIDADES2, MOTIVO2," +
                "EMPRESA3, CARGO3, ADMISSAO3, SAIDA3, ATIVIDADES3, MOTIVO3," +
                "EMAIL, CONTATO1, CONTATO2) " +
                "VALUES " +
                "(@NOME, @NASCIMENTO, @CPF, @RG, @PIS, @ESTADO_CIVIL, @ESTADO, @MUNICIPIO, @BAIRRO, @RUA, @CEP," +
                "@DIABETES, @PCD, @CNH, @CAT_CNH, @RESERVISTA, @TITULO, " +
                "@ESCOLARIDADE, @CONCLUSAO, @FACULDADE, @CURSO, " +
                "@CURSO1, @CURSO2, @CURSO3, @SITUACAO1, @SITUACAO2, @SITUACAO3, " +
                "@EMPRESA1, @CARGO1, @ADMISSAO1, @SAIDA1, @ATIVIDADES1, @MOTIVO1," +
                "@EMPRESA2, @CARGO2, @ADMISSAO2, @SAIDA2, @ATIVIDADES2, @MOTIVO2," +
                "@EMPRESA3, @CARGO3, @ADMISSAO3, @SAIDA3, @ATIVIDADES3, @MOTIVO3," +
                "@EMAIL, @CONTATO1, @CONTATO2) ", Conn);

            cmd.Parameters.AddWithValue("NOME", txtNomeCompleto.Text);
            cmd.Parameters.AddWithValue("NASCIMENTO", txtDataNascimento.Text);
            cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("RG", txtRG.Text.Trim());
            cmd.Parameters.AddWithValue("PIS", txtPIS.Text.Trim());
            cmd.Parameters.AddWithValue("ESTADO_CIVIL", txtEstadoCivil.Text.Trim());

            cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text.Trim());
            cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text);
            cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text.Trim());
            cmd.Parameters.AddWithValue("RUA", txtRua.Text.Trim());
            cmd.Parameters.AddWithValue("CEP", txtCEP.Text.Trim());

            cmd.Parameters.AddWithValue("DIABETES", cbbDiabete.Text);
            cmd.Parameters.AddWithValue("PCD", cbbPcd.Text);
            cmd.Parameters.AddWithValue("CNH", cbbCNH.Text);
            cmd.Parameters.AddWithValue("CAT_CNH", cbbCatCnh.Text);
            cmd.Parameters.AddWithValue("RESERVISTA", cbbReservista.Text);
            cmd.Parameters.AddWithValue("TITULO", cbbTituloEleitoral.Text);

            cmd.Parameters.AddWithValue("ESCOLARIDADE", cbbEscolaridade.Text);
            cmd.Parameters.AddWithValue("CONCLUSAO", txtConclusao.Text.Trim());
            cmd.Parameters.AddWithValue("FACULDADE", txtFaculdade.Text.Trim());
            cmd.Parameters.AddWithValue("CURSO", txtCursoFaculdade.Text.Trim());

            cmd.Parameters.AddWithValue("CURSO1", txtCurso1.Text.Trim());
            cmd.Parameters.AddWithValue("CURSO2", txtCurso2.Text.Trim());
            cmd.Parameters.AddWithValue("CURSO3", txtCurso3.Text.Trim());
            cmd.Parameters.AddWithValue("SITUACAO1", cbbSituacao1.Text.Trim());
            cmd.Parameters.AddWithValue("SITUACAO2", cbbSituacao2.Text.Trim());
            cmd.Parameters.AddWithValue("SITUACAO3", cbbSituacao3.Text.Trim());

            cmd.Parameters.AddWithValue("EMPRESA1", txtEmpresa1.Text.Trim());
            cmd.Parameters.AddWithValue("CARGO1", txtCargo1.Text.Trim());
            cmd.Parameters.AddWithValue("ADMISSAO1", txtAdmissao1.Text.Trim());
            cmd.Parameters.AddWithValue("SAIDA1", txtSaida1.Text.Trim());
            cmd.Parameters.AddWithValue("ATIVIDADES1", rtAtividades1.Text.Trim());
            cmd.Parameters.AddWithValue("MOTIVO1", rtMotivoSaida1.Text.Trim());

            cmd.Parameters.AddWithValue("EMPRESA2", txtEmpresa2.Text.Trim());
            cmd.Parameters.AddWithValue("CARGO2", txtCargo2.Text.Trim());
            cmd.Parameters.AddWithValue("ADMISSAO2", txtAdmissao2.Text.Trim());
            cmd.Parameters.AddWithValue("SAIDA2", txtSaida2.Text.Trim());
            cmd.Parameters.AddWithValue("ATIVIDADES2", rtAtividades2.Text.Trim());
            cmd.Parameters.AddWithValue("MOTIVO2", rtMotivoSaida2.Text.Trim());

            cmd.Parameters.AddWithValue("EMPRESA3", txtEmpresa3.Text.Trim());
            cmd.Parameters.AddWithValue("CARGO3", txtCargo3.Text.Trim());
            cmd.Parameters.AddWithValue("ADMISSAO3", txtAdmissao3.Text.Trim());
            cmd.Parameters.AddWithValue("SAIDA3", txtSaida3.Text.Trim());
            cmd.Parameters.AddWithValue("ATIVIDADES3", rtAtividades3.Text.Trim());
            cmd.Parameters.AddWithValue("MOTIVO3", rtMotivoSaida3.Text.Trim());

            cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("CONTATO1", txtContato1.Text.Trim());
            cmd.Parameters.AddWithValue("CONTATO2", txtContato2.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Salvo com Sucesso");
            }
            catch (Exception Ex)
            { Warning.ShowDialog(Ex.Message); }
        }
        #endregion

        #region Metodo Deletar
        public void DeletarProfissional(MetroGrid DataGridProfissionais)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM PROFISSIONAIS WHERE ID_PROFISSIONAL = (@ID_PROFISSIONAL) ", Conn);
            cmd.Parameters.AddWithValue("ID_PROFISSIONAL", Convert.ToInt32(DataGridProfissionais.CurrentRow.Cells[0].Value));

            try
            {
                cmd.ExecuteNonQuery();
                Sucess.ShowDialog("Profissional Deletado com Sucesso");
            }
            catch (Exception ex)
            {
                Warning.ShowDialog("Erro ao Deletar Profissional: " + ex.Message);
            }
        }
        #endregion

        #region Metodo Atualizar
        public void AtualizarProfissional(
            MaterialSingleLineTextField txtNomeCompleto, MaskedTextBox txtDataNascimento,
            MaskedTextBox txtCPF, MaterialSingleLineTextField txtRG, MaskedTextBox txtPIS, MaterialSingleLineTextField txtEstadoCivil,
            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro,
            MaterialSingleLineTextField txtRua, MaskedTextBox txtCEP,
            MetroComboBox cbbDiabete, MetroComboBox cbbPcd, MetroComboBox cbbCNH, MetroComboBox cbbCatCnh,
            MetroComboBox cbbTituloEleitoral, MetroComboBox cbbReservista,
            MetroComboBox cbbEscolaridade, MaskedTextBox txtConclusao,
            MaterialSingleLineTextField txtFaculdade, MaterialSingleLineTextField txtCursoFaculdade,
            MaterialSingleLineTextField txtCurso1, MetroComboBox cbbSituacao1,
            MaterialSingleLineTextField txtCurso2, MetroComboBox cbbSituacao2,
            MaterialSingleLineTextField txtCurso3, MetroComboBox cbbSituacao3,
            MaterialSingleLineTextField txtEmpresa1, MaterialSingleLineTextField txtCargo1,
            MaskedTextBox txtAdmissao1, MaskedTextBox txtSaida1,
            RichTextBox rtAtividades1, RichTextBox rtMotivoSaida1,
            MaterialSingleLineTextField txtEmpresa2, MaterialSingleLineTextField txtCargo2,
            MaskedTextBox txtAdmissao2, MaskedTextBox txtSaida2,
            RichTextBox rtAtividades2, RichTextBox rtMotivoSaida2,
            MaterialSingleLineTextField txtEmpresa3, MaterialSingleLineTextField txtCargo3,
            MaskedTextBox txtAdmissao3, MaskedTextBox txtSaida3,
            RichTextBox rtAtividades3, RichTextBox rtMotivoSaida3,
            MaskedTextBox txtContato1, MaskedTextBox txtContato2,
            MaterialSingleLineTextField txtEmail)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            if (IDRegistro > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE PROFISSIONAIS SET NOME = @NOME, NASCIMENTO = @NASCIMENTO," +
                                                      "CPF = @CPF, RG = @RG, PIS = @PIS, ESTADO_CIVIL = @ESTADO_CIVIL," +
                                                      "ESTADO = @ESTADO, MUNICIPIO = @MUNICIPIO, BAIRRO = @BAIRRO, RUA = @RUA, CEP = @CEP, " +
                                                      "DIABETES = @DIABETES, PCD = @PCD, CNH = @CNH, CAT_CNH = @CAT_CNH, RESERVISTA = @RESERVISTA, TITULO = @TITULO, " +
                                                      "ESCOLARIDADE = @ESCOLARIDADE, CONCLUSAO = @CONCLUSAO, FACULDADE = @FACULDADE, CURSO = @CURSO, " +
                                                      "CURSO1 = @CURSO1, CURSO2 = @CURSO2, CURSO3 = @CURSO3, " +
                                                      "SITUACAO1 = @SITUACAO1, SITUACAO2 = @SITUACAO2, SITUACAO3 = @SITUACAO3, " +
                                                      "EMPRESA1 = @EMPRESA1, CARGO1 = @CARGO1, " +
                                                      "ADMISSAO1 = @ADMISSAO1, SAIDA1 = @SAIDA1," +
                                                      "MOTIVO1 = @MOTIVO1, ATIVIDADES1 = @ATIVIDADES1, " +
                                                      "EMPRESA2 = @EMPRESA2, CARGO2 = @CARGO2, " +
                                                      "ADMISSAO2 = @ADMISSAO2, SAIDA2 = @SAIDA2, " +
                                                      "MOTIVO2 = @MOTIVO2, ATIVIDADES2 = @ATIVIDADES2, " +
                                                      "EMPRESA3 = @EMPRESA3, CARGO3 = @CARGO3, " +
                                                      "ADMISSAO3 = @ADMISSAO3, SAIDA3 = @SAIDA3," +
                                                      "MOTIVO3 = @MOTIVO3, ATIVIDADES3 = @ATIVIDADES3, " +
                                                      "EMAIL = @EMAIL, CONTATO1 = @CONTATO1, CONTATO2 = @CONTATO2 WHERE ID_PROFISSIONAL = @ID_PROFISSIONAL", Conn);

                cmd.Parameters.AddWithValue("ID_PROFISSIONAL", IDRegistro);
                cmd.Parameters.AddWithValue("NOME", txtNomeCompleto.Text);
                cmd.Parameters.AddWithValue("NASCIMENTO", txtDataNascimento.Text);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("RG", txtRG.Text);
                cmd.Parameters.AddWithValue("PIS", txtPIS.Text);
                cmd.Parameters.AddWithValue("ESTADO_CIVIL", txtEstadoCivil.Text);
                cmd.Parameters.AddWithValue("ESTADO", cbbEstado.Text);
                cmd.Parameters.AddWithValue("MUNICIPIO", cbbMunicipio.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("CEP", txtCEP.Text);
                cmd.Parameters.AddWithValue("DIABETES", cbbDiabete.Text);
                cmd.Parameters.AddWithValue("PCD", cbbPcd.Text);
                cmd.Parameters.AddWithValue("CNH", cbbCNH.Text);
                cmd.Parameters.AddWithValue("CAT_CNH", cbbCatCnh.Text);
                cmd.Parameters.AddWithValue("TITULO", cbbTituloEleitoral.Text);
                cmd.Parameters.AddWithValue("RESERVISTA", cbbReservista.Text);
                cmd.Parameters.AddWithValue("ESCOLARIDADE", cbbEscolaridade.Text);
                cmd.Parameters.AddWithValue("FACULDADE", txtFaculdade.Text);
                cmd.Parameters.AddWithValue("CURSO", txtCursoFaculdade.Text);
                cmd.Parameters.AddWithValue("CONCLUSAO", txtConclusao.Text);
                cmd.Parameters.AddWithValue("CURSO1", txtCurso1.Text);
                cmd.Parameters.AddWithValue("CURSO2", txtCurso2.Text);
                cmd.Parameters.AddWithValue("CURSO3", txtCurso3.Text);
                cmd.Parameters.AddWithValue("SITUACAO1", cbbSituacao1.Text);
                cmd.Parameters.AddWithValue("SITUACAO2", cbbSituacao2.Text);
                cmd.Parameters.AddWithValue("SITUACAO3", cbbSituacao3.Text);
                cmd.Parameters.AddWithValue("EMPRESA1", txtEmpresa1.Text);
                cmd.Parameters.AddWithValue("CARGO1", txtCargo1.Text);
                cmd.Parameters.AddWithValue("ADMISSAO1", txtAdmissao1.Text);
                cmd.Parameters.AddWithValue("SAIDA1", txtSaida1.Text);
                cmd.Parameters.AddWithValue("MOTIVO1", rtMotivoSaida1.Text);
                cmd.Parameters.AddWithValue("ATIVIDADEs1", rtAtividades1.Text);
                cmd.Parameters.AddWithValue("EMPRESA2", txtEmpresa2.Text);
                cmd.Parameters.AddWithValue("CARGO2", txtCargo2.Text);
                cmd.Parameters.AddWithValue("ADMISSAO2", txtAdmissao2.Text);
                cmd.Parameters.AddWithValue("SAIDA2", txtSaida2.Text);
                cmd.Parameters.AddWithValue("MOTIVO2", rtMotivoSaida2.Text);
                cmd.Parameters.AddWithValue("ATIVIDADES2", rtAtividades2.Text);
                cmd.Parameters.AddWithValue("EMPRESA3", txtEmpresa3.Text);
                cmd.Parameters.AddWithValue("CARGO3", txtCargo3.Text);
                cmd.Parameters.AddWithValue("ADMISSAO3", txtAdmissao3.Text);
                cmd.Parameters.AddWithValue("SAIDA3", txtSaida3.Text);
                cmd.Parameters.AddWithValue("MOTIVO3", rtMotivoSaida3.Text);
                cmd.Parameters.AddWithValue("ATIVIDADES3", rtAtividades3.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("CONTATO1", txtContato1.Text);
                cmd.Parameters.AddWithValue("CONTATO2", txtContato2.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    Sucess.ShowDialog("Atualizado com Sucesso");
                }
                catch (Exception ex)
                { Warning.ShowDialog("Falha ao  Atualizar Profissional" + ex.Message); }
            }
        }
        #endregion

        #region Metodo Limpa Campos
        public void LimparCampos(//Parametros
                                MaterialSingleLineTextField txtNomeCompleto, MaskedTextBox txtDataNascimento, MaterialSingleLineTextField txtRG,
                                MaskedTextBox txtCPF, MaterialSingleLineTextField txtEmail, MaterialSingleLineTextField txtEstadoCivil, MetroComboBox cbbEstado,
                                MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro, MaterialSingleLineTextField txtRua, MaskedTextBox txtPIS,
                                MaskedTextBox txtCEP, MetroComboBox cbbDiabete, MetroComboBox cbbPcd, MetroComboBox cbbCNH, MetroComboBox cbbCatCNH,
                                MetroComboBox cbbReservista, MetroComboBox cbbTituloEleitoral, MaskedTextBox txtContato1, MaskedTextBox txtContato2,
                                MetroComboBox cbbEscolaridade, MaskedTextBox txtConclusao, MaterialSingleLineTextField txtFaculdade,
                                MaterialSingleLineTextField txtCursoFaculdade, MaterialSingleLineTextField txtCurso1, MetroComboBox cbbSituacao1,
                                MaterialSingleLineTextField txtCurso2, MetroComboBox cbbSituacao2, MaterialSingleLineTextField txtCurso3,
                                MetroComboBox cbbSituacao3, MaterialSingleLineTextField txtEmpresa1, MaterialSingleLineTextField txtCargo1, MaskedTextBox txtAdmissao1,
                                MaskedTextBox txtSaida1, RichTextBox rtAtividades1, RichTextBox rtMotivoSaida1, MaterialSingleLineTextField txtEmpresa2,
                                MaterialSingleLineTextField txtCargo2, MaskedTextBox txtAdmissao2,
                                MaskedTextBox txtSaida2, RichTextBox rtAtividades2, RichTextBox rtMotivoSaida2, MaterialSingleLineTextField txtEmpresa3,
                                MaterialSingleLineTextField txtCargo3, MaskedTextBox txtAdmissao3,
                                MaskedTextBox txtSaida3, RichTextBox rtAtividades3, RichTextBox rtMotivoSaida3, MaterialCheckBox materialCheckBox1)
        {
            txtNomeCompleto.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEstadoCivil.Text = string.Empty;

            cbbEstado.SelectedIndex = -1;
            cbbMunicipio.SelectedIndex = -1;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtPIS.Text = string.Empty;
            txtCEP.Text = string.Empty;
            cbbDiabete.SelectedIndex = -1;
            cbbPcd.SelectedIndex = -1;
            cbbCNH.SelectedIndex = -1;
            cbbCatCNH.SelectedIndex = -1;
            cbbReservista.SelectedIndex = -1;
            cbbTituloEleitoral.SelectedIndex = -1;
            txtContato1.Text = string.Empty;
            txtContato2.Text = string.Empty;

            cbbEscolaridade.SelectedIndex = -1;
            txtConclusao.Text = string.Empty;
            txtFaculdade.Text = string.Empty;
            txtCursoFaculdade.Text = string.Empty;
            txtCurso1.Text = string.Empty;
            cbbSituacao1.SelectedIndex = -1;
            txtCurso2.Text = string.Empty;
            cbbSituacao2.SelectedIndex = -1;
            txtCurso3.Text = string.Empty;
            cbbSituacao3.SelectedIndex = -1;

            txtEmpresa1.Text = string.Empty;
            txtCargo1.Text = string.Empty;
            txtAdmissao1.Text = string.Empty;
            txtSaida1.Text = string.Empty;
            rtAtividades1.Text = string.Empty;
            rtMotivoSaida1.Text = string.Empty;

            txtEmpresa2.Text = string.Empty;
            txtCargo2.Text = string.Empty;
            txtAdmissao2.Text = string.Empty;
            txtSaida2.Text = string.Empty;
            rtAtividades2.Text = string.Empty;
            rtMotivoSaida2.Text = string.Empty;

            txtEmpresa3.Text = string.Empty;
            txtCargo3.Text = string.Empty;
            txtAdmissao3.Text = string.Empty;
            txtSaida3.Text = string.Empty;
            rtAtividades3.Text = string.Empty;
            rtMotivoSaida3.Text = string.Empty;

            materialCheckBox1.Checked = false;
        }
        #endregion

        #endregion

        #region GRID

        #region Preenchimento do Grid
        public void EncherGrid(MetroGrid DataGridProfissionais)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM PROFISSIONAIS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<ProfissinaisDTO.Profissionais> Lista = new List<ProfissinaisDTO.Profissionais>();

                while (Dr.Read())
                {
                    Lista.Add(new ProfissinaisDTO.Profissionais
                    {
                        Id = Convert.ToInt32(Dr["ID_PROFISSIONAL"]),
                        Nomecompleto = Dr["NOME"].ToString(),
                        Nascimento = Dr["NASCIMENTO"].ToString(),
                        Cpf = Dr["CPF"].ToString(),
                        Rg = Dr["RG"].ToString(),
                        Pis = Dr["PIS"].ToString(),
                        Estadocivil = Dr["ESTADO_CIVIL"].ToString(),
                        Estado = Dr["ESTADO"].ToString(),
                        Municipio = Dr["MUNICIPIO"].ToString(),
                        Bairro = Dr["BAIRRO"].ToString(),
                        Rua = Dr["RUA"].ToString(),
                        Cep = Dr["CEP"].ToString(),
                        Diabetes = Dr["DIABETES"].ToString(),
                        Pcd = Dr["PCD"].ToString(),
                        Cnh = Dr["CNH"].ToString(),
                        Catcnh = Dr["CAT_CNH"].ToString(),
                        Titulo = Dr["TITULO"].ToString(),
                        Reservista = Dr["RESERVISTA"].ToString(),
                        Escolaridade = Dr["ESCOLARIDADE"].ToString(),
                        Conclusao = Dr["CONCLUSAO"].ToString(),
                        Faculdade = Dr["FACULDADE"].ToString(),
                        Curso = Dr["CURSO"].ToString(),
                        Curso1 = Dr["CURSO1"].ToString(),
                        Situacao1 = Dr["SITUACAO1"].ToString(),
                        Curso2 = Dr["CURSO2"].ToString(),
                        Situacao2 = Dr["SITUACAO2"].ToString(),
                        Curso3 = Dr["CURSO3"].ToString(),
                        Situacao3 = Dr["SITUACAO3"].ToString(),
                        Empresa1 = Dr["EMPRESA1"].ToString(),
                        Cargo1 = Dr["CARGO1"].ToString(),
                        Admissao1 = Dr["ADMISSAO1"].ToString(),
                        Saida1 = Dr["SAIDA1"].ToString(),
                        Motivo1 = Dr["MOTIVO1"].ToString(),
                        Atividades1 = Dr["ATIVIDADES1"].ToString(),
                        Empresa2 = Dr["EMPRESA2"].ToString(),
                        Cargo2 = Dr["CARGO2"].ToString(),
                        Admissao2 = Dr["ADMISSAO2"].ToString(),
                        Saida2 = Dr["SAIDA2"].ToString(),
                        Motivo2 = Dr["MOTIVO2"].ToString(),
                        Atividades2 = Dr["ATIVIDADES2"].ToString(),
                        Empresa3 = Dr["EMPRESA3"].ToString(),
                        Cargo3 = Dr["CARGO3"].ToString(),
                        Admissao3 = Dr["ADMISSAO3"].ToString(),
                        Saida3 = Dr["SAIDA3"].ToString(),
                        Motivo3 = Dr["MOTIVO3"].ToString(),
                        Atividades3 = Dr["ATIVIDADES3"].ToString(),
                        Email = Dr["EMAIL"].ToString(),
                        Contato1 = Dr["CONTATO1"].ToString(),
                        Contato2 = Dr["CONTATO2"].ToString()
                    });
                }
                DataGridProfissionais.DataSource = Lista;
            }
            catch (Exception Ex)
            { Warning.ShowDialog(Ex.Message); }
        }
        #endregion

        #region Passar Valores do Grid para os TextBox
        public void GridToText(
            MetroGrid DataGridProfissionais,
            MaterialSingleLineTextField txtNomeCompleto, MaskedTextBox txtDataNascimento,
            MaskedTextBox txtCPF, MaterialSingleLineTextField txtRG, MaskedTextBox txtPIS, MaterialSingleLineTextField txtEstadoCivil,
            MetroComboBox cbbEstado, MetroComboBox cbbMunicipio, MaterialSingleLineTextField txtBairro,
            MaterialSingleLineTextField txtRua, MaskedTextBox txtCEP,
            MetroComboBox cbbDiabete, MetroComboBox cbbPcd, MetroComboBox cbbCNH, MetroComboBox cbbCatCnh,
            MetroComboBox cbbTituloEleitoral, MetroComboBox cbbReservista,
            MetroComboBox cbbEscolaridade, MaskedTextBox txtConclusao,
            MaterialSingleLineTextField txtFaculdade, MaterialSingleLineTextField txtCursoFaculdade,
            MaterialSingleLineTextField txtCurso1, MetroComboBox cbbSituacao1,
            MaterialSingleLineTextField txtCurso2, MetroComboBox cbbSituacao2,
            MaterialSingleLineTextField txtCurso3, MetroComboBox cbbSituacao3,
            MaterialSingleLineTextField txtEmpresa1, MaterialSingleLineTextField txtCargo1,
            MaskedTextBox txtAdmissao1, MaskedTextBox txtSaida1,
            RichTextBox rtAtividades1, RichTextBox rtMotivoSaida1,
            MaterialSingleLineTextField txtEmpresa2, MaterialSingleLineTextField txtCargo2,
            MaskedTextBox txtAdmissao2, MaskedTextBox txtSaida2,
            RichTextBox rtAtividades2, RichTextBox rtMotivoSaida2,
            MaterialSingleLineTextField txtEmpresa3, MaterialSingleLineTextField txtCargo3,
            MaskedTextBox txtAdmissao3, MaskedTextBox txtSaida3,
            RichTextBox rtAtividades3, RichTextBox rtMotivoSaida3,
            MaskedTextBox txtContato1, MaskedTextBox txtContato2,
            MaterialSingleLineTextField txtEmail)
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(DataGridProfissionais.CurrentRow.Cells[0].Value);
            txtNomeCompleto.Text = DataGridProfissionais.CurrentRow.Cells[1].Value.ToString();
            txtDataNascimento.Text = DataGridProfissionais.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = DataGridProfissionais.CurrentRow.Cells[3].Value.ToString();
            txtRG.Text = DataGridProfissionais.CurrentRow.Cells[4].Value.ToString();
            txtPIS.Text = DataGridProfissionais.CurrentRow.Cells[5].Value.ToString();
            txtEstadoCivil.Text = DataGridProfissionais.CurrentRow.Cells[6].Value.ToString();
            cbbEstado.Text = DataGridProfissionais.CurrentRow.Cells[7].Value.ToString();
            cbbMunicipio.Text = DataGridProfissionais.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = DataGridProfissionais.CurrentRow.Cells[9].Value.ToString();
            txtRua.Text = DataGridProfissionais.CurrentRow.Cells[10].Value.ToString();
            txtCEP.Text = DataGridProfissionais.CurrentRow.Cells[11].Value.ToString();
            cbbDiabete.Text = DataGridProfissionais.CurrentRow.Cells[12].Value.ToString();
            cbbPcd.Text = DataGridProfissionais.CurrentRow.Cells[13].Value.ToString();
            cbbCNH.Text = DataGridProfissionais.CurrentRow.Cells[16].Value.ToString();
            cbbCatCnh.Text = DataGridProfissionais.CurrentRow.Cells[17].Value.ToString();
            cbbTituloEleitoral.Text = DataGridProfissionais.CurrentRow.Cells[14].Value.ToString();
            cbbReservista.Text = DataGridProfissionais.CurrentRow.Cells[15].Value.ToString();
            cbbEscolaridade.Text = DataGridProfissionais.CurrentRow.Cells[18].Value.ToString();
            txtConclusao.Text = DataGridProfissionais.CurrentRow.Cells[21].Value.ToString();
            txtFaculdade.Text = DataGridProfissionais.CurrentRow.Cells[19].Value.ToString();
            txtCursoFaculdade.Text = DataGridProfissionais.CurrentRow.Cells[20].Value.ToString();
            txtCurso1.Text = DataGridProfissionais.CurrentRow.Cells[22].Value.ToString();
            cbbSituacao1.Text = DataGridProfissionais.CurrentRow.Cells[25].Value.ToString();
            txtCurso2.Text = DataGridProfissionais.CurrentRow.Cells[23].Value.ToString();
            cbbSituacao2.Text = DataGridProfissionais.CurrentRow.Cells[26].Value.ToString();
            txtCurso3.Text = DataGridProfissionais.CurrentRow.Cells[24].Value.ToString();
            cbbSituacao3.Text = DataGridProfissionais.CurrentRow.Cells[27].Value.ToString();
            txtEmpresa1.Text = DataGridProfissionais.CurrentRow.Cells[28].Value.ToString();
            txtCargo1.Text = DataGridProfissionais.CurrentRow.Cells[29].Value.ToString();
            txtAdmissao1.Text = DataGridProfissionais.CurrentRow.Cells[30].Value.ToString();
            txtSaida1.Text = DataGridProfissionais.CurrentRow.Cells[31].Value.ToString();
            rtMotivoSaida1.Text = DataGridProfissionais.CurrentRow.Cells[32].Value.ToString();
            rtAtividades1.Text = DataGridProfissionais.CurrentRow.Cells[33].Value.ToString();
            txtEmpresa2.Text = DataGridProfissionais.CurrentRow.Cells[34].Value.ToString();
            txtCargo2.Text = DataGridProfissionais.CurrentRow.Cells[35].Value.ToString();
            txtAdmissao2.Text = DataGridProfissionais.CurrentRow.Cells[36].Value.ToString();
            txtSaida2.Text = DataGridProfissionais.CurrentRow.Cells[37].Value.ToString();
            rtMotivoSaida2.Text = DataGridProfissionais.CurrentRow.Cells[38].Value.ToString();
            rtAtividades2.Text = DataGridProfissionais.CurrentRow.Cells[39].Value.ToString();
            txtEmpresa3.Text = DataGridProfissionais.CurrentRow.Cells[40].Value.ToString();
            txtCargo3.Text = DataGridProfissionais.CurrentRow.Cells[41].Value.ToString();
            txtAdmissao3.Text = DataGridProfissionais.CurrentRow.Cells[42].Value.ToString();
            txtSaida3.Text = DataGridProfissionais.CurrentRow.Cells[43].Value.ToString();
            rtMotivoSaida3.Text = DataGridProfissionais.CurrentRow.Cells[44].Value.ToString();
            rtAtividades3.Text = DataGridProfissionais.CurrentRow.Cells[45].Value.ToString();
            txtContato1.Text = DataGridProfissionais.CurrentRow.Cells[46].Value.ToString();
            txtContato2.Text = DataGridProfissionais.CurrentRow.Cells[47].Value.ToString();
            txtEmail.Text = DataGridProfissionais.CurrentRow.Cells[48].Value.ToString();
        }
        #endregion

        #endregion

        #region Gerar PDF
        public void GerarDPF(
        #region Parametros
                        MaterialSingleLineTextField txtNomeCompleto,
                        MaskedTextBox txtDataNascimento,
                        MetroComboBox cbbEstado,
                        MetroComboBox cbbMunicipio,
                        MaterialSingleLineTextField txtBairro,
                        MaskedTextBox txtContato1,
                        MaskedTextBox txtContato2,
                        MaterialSingleLineTextField txtEmail,
                        MetroComboBox cbbEscolaridade,
                        MaskedTextBox txtConclusao,
                        MaterialSingleLineTextField txtFaculdade,
                        MaterialSingleLineTextField txtCursoFaculdade,
                        MaterialSingleLineTextField txtCurso1,
                        MaterialSingleLineTextField txtCurso2,
                        MaterialSingleLineTextField txtCurso3,
                        MetroComboBox cbbSituacao1,
                        MetroComboBox cbbSituacao2,
                        MetroComboBox cbbSituacao3,
                        MaterialSingleLineTextField txtEmpresa1,
                        MaterialSingleLineTextField txtCargo1,
                        MaskedTextBox txtAdmissao1,
                        MaskedTextBox txtSaida1,
                        RichTextBox rtAtividades1,
                        RichTextBox rtMotivoSaida1,
                        MaterialSingleLineTextField txtEmpresa2,
                        MaterialSingleLineTextField txtCargo2,
                        MaskedTextBox txtAdmissao2,
                        MaskedTextBox txtSaida2,
                        RichTextBox rtAtividades2,
                        RichTextBox rtMotivoSaida2,
                        MaterialSingleLineTextField txtEmpresa3,
                        MaterialSingleLineTextField txtCargo3,
                        MaskedTextBox txtAdmissao3,
                        MaskedTextBox txtSaida3,
                        RichTextBox rtAtividades3,
                        RichTextBox rtMotivoSaida3)
        #endregion
        {
            if (cbbEscolaridade.Text == "Sem Escolaridade" || cbbEscolaridade.Text == "Ensino Fundamental" || cbbEscolaridade.Text == "Ensino Fundamental Incompleto" || 
                cbbEscolaridade.Text == "Ensino Médio" || cbbEscolaridade.Text == "Ensino Médio Incompleto")
            {
                #region 3 Cursos
                if (txtCurso1.Text != "" && txtCurso2.Text != "" && txtCurso3.Text != "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Sem Escolaridade, 3 Cursos, 3 Emprego
                        var Curriculo2 = new CurriculoBLL();
                        Curriculo2.SE3C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 3 Cursos, 2 Emprego
                        var Curriculo3 = new CurriculoBLL();
                        Curriculo3.SE3C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Emprego
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 3 Cursos, 1 Emprego
                        var Curriculo4 = new CurriculoBLL();
                        Curriculo4.SE3C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Emprego
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 3 Cursos, Sem Emprego
                        var Curriculo1 = new CurriculoBLL();
                        Curriculo1.SE3CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region 2 Cursos
                if (txtCurso1.Text != "" && txtCurso2.Text != "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Sem Escolaridade, 2 Cursos, 3 Empregos
                        var Curriculo6 = new CurriculoBLL();
                        Curriculo6.SE2C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" & txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 2 Cursos, 2 Empregos
                        var Curriculo7 = new CurriculoBLL();
                        Curriculo7.SE2C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 2 Cursos, 1 Emprego
                        var Curriculo8 = new CurriculoBLL();
                        Curriculo8.SE2C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 2 Cursos, Sem Emprego
                        var Curriculo5 = new CurriculoBLL();
                        Curriculo5.SE2CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region 1 Curso
                if (txtCurso1.Text != "" && txtCurso2.Text == "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Sem Escolaridade, 1 Cursos, 3 Empregos
                        var Curriculo10 = new CurriculoBLL();
                        Curriculo10.SE1C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 1 Cursos, 2 Empregos
                        var Curriculo11 = new CurriculoBLL();
                        Curriculo11.SE1C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 emprego
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 1 Cursos, 1 Empregos
                        var Curriculo12 = new CurriculoBLL();
                        Curriculo12.SE1C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, 1 Cursos, Sem Emprego
                        var Curriculo9 = new CurriculoBLL();
                        Curriculo9.SE1CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtCurso1, cbbSituacao1);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region Sem Curso
                if (txtCurso1.Text == "" && txtCurso2.Text == "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Sem Escolaridade, Sem Cursos, 3 Empregos
                        var Curriculo14 = new CurriculoBLL();
                        Curriculo14.SESC3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, Sem Cursos, 2 Empregos
                        var Curriculo15 = new CurriculoBLL();
                        Curriculo15.SESC2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, Sem Cursos, 1 Empregos
                        var Curriculo16 = new CurriculoBLL();
                        Curriculo16.SESC1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Sem Escolaridade, Sem Cursos, Sem Emprego
                        var Curriculo13 = new CurriculoBLL();
                        Curriculo13.SESCSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao);
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
            if (cbbEscolaridade.Text == "Ensino Superior" || cbbEscolaridade.Text == "Ensino Superior Incompleto")
            {
                #region 3 Cursos
                if (txtCurso1.Text != "" && txtCurso2.Text != "" && txtCurso3.Text != "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Com Escolaridade, 3 Cursos, 3 Emprego
                        var Curriculo2 = new CurriculoBLL();
                        Curriculo2.CE3C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtCursoFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 3 Cursos, 2 Emprego
                        var Curriculo3 = new CurriculoBLL();
                        Curriculo3.CE3C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtCursoFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Emprego
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 3 Cursos, 1 Emprego
                        var Curriculo4 = new CurriculoBLL();
                        Curriculo4.CE3C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtCursoFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Emprego
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 3 Cursos, Sem Emprego
                        var Curriculo1 = new CurriculoBLL();
                        Curriculo1.CE3CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtCursoFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region 2 Cursos
                if (txtCurso1.Text != "" && txtCurso2.Text != "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Com Escolaridade, 2 Cursos, 3 Empregos
                        var Curriculo6 = new CurriculoBLL();
                        Curriculo6.CE2C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" & txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 2 Cursos, 2 Empregos
                        var Curriculo7 = new CurriculoBLL();
                        Curriculo7.CE2C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 2 Cursos, 1 Emprego
                        var Curriculo8 = new CurriculoBLL();
                        Curriculo8.CE2C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 2 Cursos, Sem Emprego
                        var Curriculo5 = new CurriculoBLL();
                        Curriculo5.CE2CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, txtCurso2, cbbSituacao1, cbbSituacao2);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region 1 Curso
                if (txtCurso1.Text != "" && txtCurso2.Text == "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Com Escolaridade, 1 Cursos, 3 Empregos
                        var Curriculo10 = new CurriculoBLL();
                        Curriculo10.CE1C3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 1 Cursos, 2 Empregos
                        var Curriculo11 = new CurriculoBLL();
                        Curriculo11.CE1C2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 emprego
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 1 Cursos, 1 Empregos
                        var Curriculo12 = new CurriculoBLL();
                        Curriculo12.CE1C1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, cbbSituacao1,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, 1 Cursos, Sem Emprego
                        var Curriculo9 = new CurriculoBLL();
                        Curriculo9.CE1CSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtCurso1, cbbSituacao1);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region Sem Curso
                if (txtCurso1.Text == "" && txtCurso2.Text == "" && txtCurso3.Text == "")
                {
                    #region 3 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text != "")
                    {
                        #region Com Escolaridade, Sem Cursos, 3 Empregos
                        var Curriculo14 = new CurriculoBLL();
                        Curriculo14.CESC3E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                        txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
                        #endregion
                    }
                    #endregion

                    #region 2 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text != "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, Sem Cursos, 2 Empregos
                        var Curriculo15 = new CurriculoBLL();
                        Curriculo15.CESC2E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                        txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2);
                        #endregion
                    }
                    #endregion

                    #region 1 Empregos
                    if (txtEmpresa1.Text != "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, Sem Cursos, 1 Empregos
                        var Curriculo16 = new CurriculoBLL();
                        Curriculo16.CESC1E(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                        txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1);
                        #endregion
                    }
                    #endregion

                    #region Sem Empregos
                    if (txtEmpresa1.Text == "" && txtEmpresa2.Text == "" && txtEmpresa3.Text == "")
                    {
                        #region Com Escolaridade, Sem Cursos, Sem Emprego
                        var Curriculo13 = new CurriculoBLL();
                        Curriculo13.CESCSE(txtNomeCompleto,
                        txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                        txtContato1, txtContato2, txtEmail,
                        cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade);
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
        }
        #endregion

        #region Pesquisar

        #region CPF
        public DataTable PesquisarCPFProfissionais(MaterialSingleLineTextField txtBuscarCNPJ)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM PROFISSIONAIS WHERE CPF LIKE '" + txtBuscarCNPJ.Text + "%'";

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

        #region NOME
        public DataTable PesquisarNomeProfissionais(MaterialSingleLineTextField txtBuscarNome)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM PROFISSIONAIS WHERE (UPPER (NOME) LIKE '" + txtBuscarNome.Text + "%' OR LOWER (NOME) LIKE '" + txtBuscarNome.Text + "%')";

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

        #region AREA DE ATUAÇÃO
        public DataTable PesquisarAtuacaoProfissionais(MaterialSingleLineTextField txtBuscarArea)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            string sql = "SELECT * FROM PROFISSIONAIS WHERE (UPPER (CARGO1) LIKE '" + txtBuscarArea.Text + "%' OR UPPER (CARGO2) LIKE '" + txtBuscarArea.Text + "%' OR UPPER (CARGO3) LIKE '" + txtBuscarArea.Text + "%' OR LOWER (CARGO1) LIKE '" + txtBuscarArea.Text + "%' OR LOWER (CARGO2) LIKE '" + txtBuscarArea.Text + "%' OR LOWER (CARGO3) LIKE '" + txtBuscarArea.Text + "%')";

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