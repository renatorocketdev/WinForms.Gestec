using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms.Listas
{
    public partial class ListaProfissionais : MaterialForm
    {
        public ListaProfissionais()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400,
                Primary.Blue500,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
                );

            EncherGrid();

            cbbMunicipio.Enabled = false;

            txtCPF.Text = "";
            txtCPF.Mask = "000,000,000-00";
        }

        #region Panel Superior

        int TogMove;
        int mValY;
        int mValX;

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValX = e.X;
            mValY = e.Y;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            { this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY); }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        #endregion

        #region Botões Superiores
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar
            if (WindowState == FormWindowState.Normal)
            { WindowState = FormWindowState.Maximized; }
            else if (WindowState == FormWindowState.Maximized)
            { WindowState = FormWindowState.Normal; }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Grid

        #region EncherGrid
        public void EncherGrid()
        {
            ProfissionaisBLL bll = new ProfissionaisBLL();
            bll.EncherGrid(DataGridProfissionais);
        }
        #endregion

        #region Grid To Text
        private void DataGridProfissionais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string Contato1;

            Contato1 = DataGridProfissionais.CurrentRow.Cells[46].Value.ToString();
            Contato1.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

            if (Contato1.Length == 14)
            {
                materialCheckBox1.Checked = true;
            }
            else if (Contato1.Length == 15)
            {
                materialCheckBox1.Checked = false;
            }

            ProfissionaisBLL bll = new ProfissionaisBLL();
            bll.GridToText(DataGridProfissionais, txtNomeCompleto, txtDataNascimento,
            txtCPF, txtRG, txtPIS, txtEstadoCivil,
            cbbEstado, cbbMunicipio, txtBairro, txtRua, txtCEP,
            cbbDiabete, cbbPcd, cbbCNH, cbbCatCnh, cbbTituloEleitoral, cbbReservista,
            cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
            txtCurso1, cbbSituacao1, txtCurso2, cbbSituacao2, txtCurso3, cbbSituacao3,
            txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
            txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
            txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3,
            txtContato1, txtContato2, txtEmail);


        }
        #endregion

        #endregion

        #region Botões Principais

        #region Atualizar
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "" || txtDataNascimento.Text == "" || txtCPF.Text == "" || txtPIS.Text == "" || cbbEstado.Text == "" || cbbMunicipio.Text == "" ||
               txtBairro.Text == "" || cbbEscolaridade.Text == "" || txtContato1.Text == "")
            {
                Warning.ShowDialog("Preencha os Campos Obrigatórios!! (*)");
            }
            else
            {
                if (txtRG.Text.Length >= 16)
                {
                    Warning.ShowDialog("Quantidade de Caracteres Inválida");
                }

                else
                {
                    if (txtCurso1.Text != string.Empty && txtCurso3.Text != string.Empty && txtCurso2.Text == string.Empty)
                    {
                        Warning.ShowDialog("A Ordem dos Cursos devem ser Preenchidas Corretamente.");
                    }
                    else
                    {
                        if (txtEmpresa1.Text != string.Empty && txtEmpresa3.Text != string.Empty && txtEmpresa2.Text == string.Empty)
                        {
                            Warning.ShowDialog("A Ordem das Empresas devem ser Preenchidas Corretamente.");
                        }
                        else
                        {
                            ProfissionaisBLL bll = new ProfissionaisBLL();
                            bll.AtualizarProfissional(txtNomeCompleto, txtDataNascimento,
                            txtCPF, txtRG, txtPIS, txtEstadoCivil,
                            cbbEstado, cbbMunicipio, txtBairro, txtRua, txtCEP,
                            cbbDiabete, cbbPcd, cbbCNH, cbbCatCnh, cbbTituloEleitoral, cbbReservista,
                            cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                            txtCurso1, cbbSituacao1, txtCurso2, cbbSituacao2, txtCurso3, cbbSituacao3,
                            txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                            txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                            txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3,
                            txtContato1, txtContato2, txtEmail);

                            bll.LimparCampos(txtNomeCompleto, txtDataNascimento, txtRG, txtCPF, txtEmail, txtEstadoCivil, cbbEstado, cbbMunicipio, txtBairro, txtRua, txtPIS, txtCEP,
                            cbbDiabete, cbbPcd, cbbCNH, cbbCatCnh, cbbReservista, cbbTituloEleitoral, txtContato1, txtContato2, cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                            txtCurso1, cbbSituacao1, txtCurso2, cbbSituacao2, txtCurso3, cbbSituacao3, txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1, txtEmpresa2,
                            txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2, txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3, materialCheckBox1);
                        }
                    }
                }
            }

            /*if (txtRG.Text.Length >= 16)
            {
                MessageBox.Show("Quantidade de Caracteres Inválida ", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                /**/

            EncherGrid();
        }
        #endregion

        #region Deletar
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            ProfissionaisBLL bll = new ProfissionaisBLL();
            bll.DeletarProfissional(DataGridProfissionais);

            bll.LimparCampos(txtNomeCompleto, txtDataNascimento, txtRG, txtCPF, txtEmail, txtEstadoCivil, cbbEstado, cbbMunicipio, txtBairro, txtRua, txtPIS, txtCEP,
            cbbDiabete, cbbPcd, cbbCNH, cbbCatCnh, cbbReservista, cbbTituloEleitoral, txtContato1, txtContato2, cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
            txtCurso1, cbbSituacao1, txtCurso2, cbbSituacao2, txtCurso3, cbbSituacao3, txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1, txtEmpresa2,
            txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2, txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3, materialCheckBox1);

            EncherGrid();
        }
        #endregion

        #region Limpar Campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ProfissionaisBLL bll = new ProfissionaisBLL();
            bll.LimparCampos(txtNomeCompleto, txtDataNascimento, txtRG, txtCPF, txtEmail, txtEstadoCivil, cbbEstado, cbbMunicipio, txtBairro, txtRua, txtPIS, txtCEP,
                cbbDiabete, cbbPcd, cbbCNH, cbbCatCnh, cbbReservista, cbbTituloEleitoral, txtContato1, txtContato2, cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                txtCurso1, cbbSituacao1, txtCurso2, cbbSituacao2, txtCurso3, cbbSituacao3, txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1, txtEmpresa2,
                txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2, txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3, materialCheckBox1);
        }
        #endregion

        #endregion

        #region Gerar PDF
        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            ProfissionaisBLL GerarPDF = new ProfissionaisBLL();
            GerarPDF.GerarDPF(txtNomeCompleto,
                txtDataNascimento, cbbEstado, cbbMunicipio, txtBairro,
                txtContato1, txtContato2, txtEmail,
                cbbEscolaridade, txtConclusao, txtFaculdade, txtCursoFaculdade,
                txtCurso1, txtCurso2, txtCurso3, cbbSituacao1, cbbSituacao2, cbbSituacao3,
                txtEmpresa1, txtCargo1, txtAdmissao1, txtSaida1, rtAtividades1, rtMotivoSaida1,
                txtEmpresa2, txtCargo2, txtAdmissao2, txtSaida2, rtAtividades2, rtMotivoSaida2,
                txtEmpresa3, txtCargo3, txtAdmissao3, txtSaida3, rtAtividades3, rtMotivoSaida3);
        }
        #endregion

        #region ComboBox
        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEstado.Text != "")
            {
                cbbMunicipio.Enabled = true;
                BLL.ComboBox bll = new BLL.ComboBox();
                bll.VerificaEstado(cbbEstado, cbbMunicipio);
            }
            else
            {
                cbbMunicipio.Enabled = false;
            }
        }
        #endregion

        #region LOGO
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
        }
        #endregion

        #region Pesquisar

        #region CPF
        private void txtBuscarCPF_TextChanged(object sender, EventArgs e)
        {
            ProfissionaisBLL BLL = new ProfissionaisBLL();
            BLL.PesquisarCPFProfissionais(txtBuscarCPF);

            DataGridProfissionais.DataSource = BLL.PesquisarCPFProfissionais(txtBuscarCPF);
        }
        #endregion

        #region Nome
        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            ProfissionaisBLL BLL = new ProfissionaisBLL();
            BLL.PesquisarNomeProfissionais(txtBuscarNome);

            DataGridProfissionais.DataSource = BLL.PesquisarNomeProfissionais(txtBuscarNome);
        }
        #endregion

        #region Area de Atuação
        private void txtBuscarArea_TextChanged(object sender, EventArgs e)
        {
            ProfissionaisBLL BLL = new ProfissionaisBLL();
            BLL.PesquisarAtuacaoProfissionais(txtBuscarArea);

            DataGridProfissionais.DataSource = BLL.PesquisarAtuacaoProfissionais(txtBuscarArea);
        }
        #endregion

        #endregion

        #region Ao Carregar
        private void ListaProfissionais_Load(object sender, EventArgs e)
        {
            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);

            //Foco:
            TabProfissionais.Focus();
        }




        #endregion

        private void cbbCNH_TextChanged(object sender, EventArgs e)
        {
            if (cbbCNH.Text == "Sim")
            {
                cbbCatCnh.Enabled = true;
            }
            if (cbbCNH.Text == "Não")
            {
                cbbCatCnh.Text = "";
                cbbCatCnh.Enabled = false;
            }
        }

        #region Valida CPF
        string mensagem = "";

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string valor = txtCPF.Text;

            if (ValidaBLL.IsCpf(valor))
            {
                mensagem = "O número é um CPF Válido !";
            }
            else
            {
                mensagem = "O número é um CPF Inválido !";
            }

            MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (materialCheckBox1.Checked == true)
            {
                txtContato1.Mask = "(00) 0000-0000";
            }
            else
            {
                txtContato1.Mask = "(00) 00000-0000";
            }
        }        
    }
}