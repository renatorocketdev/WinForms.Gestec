using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms.Listas
{
    public partial class ListaVagas : MaterialForm
    {
        public ListaVagas()
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

            VagasBLL vagas = new VagasBLL();
            vagas.EncherGrid(dgVagas);

            cbbMunicipio.Enabled = false;

            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);

            EncherNomeEmpresa();
        }

        public static NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");

        #region ComboBox

        #region Estados
        private void cbbEstado_TextChanged(object sender, EventArgs e)
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

        #region CNPJ
        private void cbbNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT cnpj, nm_fantasia FROM empresas WHERE nm_fantasia LIKE '" + cbbNomeEmpresa.Text + "'", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["cnpj"] = "";

                table.Rows.InsertAt(row, 0);

                cbbCNPJ.DataSource = table;
                cbbCNPJ.ValueMember = "cnpj";

            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Nome Empresa
        public void EncherNomeEmpresa()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                //NpgsqlCommand cmd = new NpgsqlCommand("SELECT capitulo FROM biblia WHERE livro LIKE '" + cbbLivro.Text + "' ORDER BY id_biblia asc", Conn);
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nm_fantasia FROM empresas", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["nm_fantasia"] = "";

                table.Rows.InsertAt(row, 0);

                cbbNomeEmpresa.DataSource = table;
                cbbNomeEmpresa.DisplayMember = "nm_fantasia";

            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }
        #endregion

        #endregion

        #region Grid To Text
        private void dgVagas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VagasBLL vagas = new VagasBLL();
            vagas.GridTotxt(dgVagas, txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);
        }
        #endregion

        #region Panel Superior
        int TogMove;
        int mValX;
        int mValy;

        private void panelControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValX = e.X;
            mValy = e.Y;
        }

        private void panelControlBox_MouseMove(object sender, MouseEventArgs e)
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
        #endregion

        #region Botões Superiores
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            { WindowState = FormWindowState.Maximized; }
            else if (WindowState == FormWindowState.Maximized)
            { WindowState = FormWindowState.Normal; }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Botões Principais

        #region Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            VagasBLL bll = new VagasBLL();
            bll.DeletaVaga(dgVagas);

            bll.LimparCampos(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);

            VagasBLL vagas = new VagasBLL();
            vagas.EncherGrid(dgVagas);
        }
        #endregion

        #region Limpar Campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            VagasBLL bll = new VagasBLL();
            bll.LimparCampos(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);
        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtCargo.Text == "" ||
                cbbNomeEmpresa.Text == "" || cbbCNPJ.Text == "" ||
                cbbEstado.Text == "" || cbbMunicipio.Text == "")
            { Warning.ShowDialog("Preencha os Campos Obrigatórios!! (*)"); }
            else
            {
                VagasBLL bll = new VagasBLL();
                bll.AtualizaVaga(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);

                bll.LimparCampos(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);

                VagasBLL vagas = new VagasBLL();
                vagas.EncherGrid(dgVagas);
            }
        }


        #endregion

        #endregion

        #region Pesquisar

        #endregion

        #region

        #endregion

        private void txtBuscarEmpresa_TextChanged(object sender, EventArgs e)
        {
            VagasBLL vagas = new VagasBLL();
            vagas.PesquisarNomeEmpresa(txtBuscarEmpresa);

            dgVagas.DataSource = vagas.PesquisarNomeEmpresa(txtBuscarEmpresa);
        }

        private void txtBuscarCargo_TextChanged(object sender, EventArgs e)
        {
            VagasBLL vagas = new VagasBLL();
            vagas.PesquisarCargoEmpresa(txtBuscarCargo);

            dgVagas.DataSource = vagas.PesquisarCargoEmpresa(txtBuscarCargo);
        }
    }
}