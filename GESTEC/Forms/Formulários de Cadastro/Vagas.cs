using GESTEC.BLL;
using GESTEC.Forms.Listas;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class VagasV2Bunifu : MaterialForm
    {
        public VagasV2Bunifu()
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

            cbbMunicipio.Enabled = false;

            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);

            EncherNomeEmpresa();
        }

        public static NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");

        #region ComboBox


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
                row["nm_fantasia"] = "Selecione a Empresa";

                table.Rows.InsertAt(row, 0);

                cbbNomeEmpresa.DataSource = table;
                cbbNomeEmpresa.DisplayMember = "nm_fantasia";

            }
            catch (Exception Ex)
            { Warning.ShowDialog(Ex.Message); }
        }
        #endregion

        #region ComboBox CNPJ
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
                row["cnpj"] = "Selecione o CNPJ";

                table.Rows.InsertAt(row, 0);

                cbbCNPJ.DataSource = table;
                cbbCNPJ.ValueMember = "cnpj";

            }
            catch (Exception Ex)
            { Warning.ShowDialog(Ex.Message); }
        }
        #endregion

        #region ComboBox Estados
        private void cbbEstado_TextChanged(object sender, EventArgs e)
        {
            if(cbbEstado.Text != "")
            {
                cbbMunicipio.Enabled = true;
                BLL.ComboBox bll = new BLL.ComboBox();
                bll.VerificaEstado(cbbEstado, cbbMunicipio);
            } else
            {
                cbbMunicipio.Enabled = false;
            }

        }
        #endregion

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

        private void panelControlBox_MouseLeave(object sender, EventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValy);
            }
        }

        private void panelControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        #endregion

        #region Botões Superiores
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Menu Lateral
        private void picUsuarios_Click(object sender, EventArgs e)
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

        private void picCargos_Click(object sender, EventArgs e)
        {
            CargosV2Bunifu Cargos = new CargosV2Bunifu();
            Cargos.Show();
            this.Hide();
        }

        private void picEmails_Click(object sender, EventArgs e)
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

        #region Botões Principais
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtTitulo.Text == "" || txtCargo.Text == "" || 
                cbbEstado.Text == "" || cbbMunicipio.Text == "" || cbbStatus.Text == "")
            {
                Warning.ShowDialog("Preencha Todos os Campos Obrigatórios (*)");
            }
            else
            {
                VagasBLL vagas = new VagasBLL();
                vagas.Inserir(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);
                vagas.LimparCampos(txtTitulo, txtSalario, cbbEstado, cbbMunicipio, txtBairro, rtSobre, cbbStatus, cbbNomeEmpresa, cbbCNPJ, txtCargo);
            }
            
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaVagas lista = new ListaVagas();
            lista.ShowDialog();
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
    }
}
