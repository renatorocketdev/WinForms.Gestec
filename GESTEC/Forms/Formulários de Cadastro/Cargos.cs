using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class CargosV2Bunifu : MaterialForm
    {
        public CargosV2Bunifu()
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

            EncherNomeEmpresa();
            EncherGridStatus();

            cbbNomeProf.SelectedIndex = -1;
            cbbCPF.SelectedIndex = -1;
        }

        public static NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");

        #region Panel Superior
        int TogMove;
        int mValX;
        int mValy;

        private void panelControlBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValX = e.X;
            mValy = e.Y;
        }

        private void panelControlBox_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValy);
            }
        }
        private void panelControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBoxLogo_Click_1(object sender, EventArgs e)
        {
            ControleBunifu controle = new ControleBunifu();
            controle.Show();
            this.Hide();
        }
        #endregion

        #region Botões Superiores
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Botões Pricipais

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || cbbNomeProf.Text == "" || cbbCPF.Text == "" || cbbEmpresa.Text == "" || cbbCargo.Text == "")
            {
                GESTEC.Warning.ShowDialog("Preencha os Campos Obrigatórios!!(*)");
                //MessageBox.Show("Preencha os Campos Obrigatórios!! (*)", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CargosBLL bll = new CargosBLL();
                bll.Inserir(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);

                bll.LimparCampos(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);

                bll.PrencherGrid(DataGridStatus);
            }
        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CargosBLL bll = new CargosBLL();
            bll.AtualizarCandidatura(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);
            bll.PrencherGrid(DataGridStatus);
            bll.LimparCampos(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);
        }
        #endregion

        #region Limpar Campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            CargosBLL bll = new CargosBLL();
            bll.LimparCampos(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);
        }
        #endregion

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            CargosBLL bll = new CargosBLL();
            bll.DeletarCandidatura(DataGridStatus);
            bll.LimparCampos(txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);
            bll.PrencherGrid(DataGridStatus);
        }
        #endregion

        #endregion

        #region Menu Lateral
        private void picUser_Click(object sender, EventArgs e)
        {
            UsuariosBunifu Usuarios = new UsuariosBunifu();
            Usuarios.Show();
            this.Hide();
        }

        private void picProfissionais_Click(object sender, EventArgs e)
        {
            ProfissionaisBunifu Profissionais = new ProfissionaisBunifu();
            Profissionais.Show();
            this.Hide();
        }

        private void picEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaBunifu Empresa = new EmpresaBunifu();
            Empresa.Show();
            this.Hide();
        }

        private void picVagas_Click(object sender, EventArgs e)
        {
            VagasV2Bunifu vagas = new VagasV2Bunifu();
            vagas.Show();
            this.Hide();
        }

        private void picEmail_Click(object sender, EventArgs e)
        {
            EmailBunifu Emails = new EmailBunifu();
            Emails.Show();
            this.Hide();
        }

        private void picBiblia_Click(object sender, EventArgs e)
        {
            BibliaBunifu Biblia = new BibliaBunifu();
            Biblia.Show();
            this.Hide();
        }
        #endregion

        #region Combo Box

        #region Por Empresa - Nome Empresa
        public void EncherNomeEmpresa()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                //NpgsqlCommand cmd = new NpgsqlCommand("SELECT capitulo FROM biblia WHERE livro LIKE '" + cbbLivro.Text + "' ORDER BY id_biblia asc", Conn);
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nm_empresa FROM vagas", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["nm_empresa"] = "Selecione a Empresa";

                table.Rows.InsertAt(row, 0);

                cbbEmpresa.DataSource = table;
                cbbEmpresa.DisplayMember = "nm_empresa";

                cbbEmpresa.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        #region Por Empresa - Cargos
        private void cbbEmpresa_TextChanged(object sender, EventArgs e)
        {

            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nm_empresa, cargo FROM vagas WHERE nm_empresa LIKE '" + cbbEmpresa.Text + "'", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["cargo"] = "Selecione o Cargo";

                table.Rows.InsertAt(row, 0);

                cbbCargo.DataSource = table;
                cbbCargo.ValueMember = "cargo";

                cbbCargo.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        #endregion

        #region GRID

        #region EncherGrid
        public void EncherGridStatus()
        {
            CargosBLL bll = new CargosBLL();
            bll.PrencherGrid(DataGridStatus);
        }
        #endregion

        #region Grid To Text
        private void DataGridStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargosBLL bll = new CargosBLL();
            bll.GridToText(DataGridStatus, txtID, cbbNomeProf, cbbCPF, cbbEmpresa, cbbCargo, cbbSituacao);
        }
        #endregion

        #endregion

        #region LOGO
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu controle = new ControleBunifu();
            controle.Show();
            this.Hide();
        }
        #endregion

        #region TextChanged
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_profissional, nome, cpf FROM profissionais WHERE id_profissional = '" + txtID.Text + "'", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["nome"] = "";

                table.Rows.InsertAt(row, 0);

                cbbNomeProf.DataSource = table;
                cbbNomeProf.ValueMember = "nome";

                cbbNomeProf.SelectedIndex = -1;

                cbbCPF.DataSource = table;
                cbbCPF.ValueMember = "cpf";

                cbbCPF.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message);
            }
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            CargosBLL cargos = new CargosBLL();
            cargos.PesquisarCargo(txtCargo);

            DataGridStatus.DataSource = cargos.PesquisarCargo(txtCargo);

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            CargosBLL cargos = new CargosBLL();
            cargos.PesquisarCPF(txtCPF);

            DataGridStatus.DataSource = cargos.PesquisarCPF(txtCPF);
        }

        #endregion        
    }
}
