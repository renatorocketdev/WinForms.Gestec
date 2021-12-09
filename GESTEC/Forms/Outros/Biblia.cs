using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class BibliaBunifu : MaterialForm
    {
        public BibliaBunifu()
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
        }

        #region Botões Superiores
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar
            if (WindowState == FormWindowState.Normal)
            { WindowState = FormWindowState.Maximized; }
            else if (WindowState == FormWindowState.Maximized)
            { WindowState = FormWindowState.Normal; }
        }
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        #region Manu Lateral
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
            VagasV2Bunifu Vagas = new VagasV2Bunifu();
            Vagas.Show();
            this.Hide();
        }

        private void picPost_Click(object sender, EventArgs e)
        {
            CargosV2Bunifu Cargos = new CargosV2Bunifu();
            Cargos.Show();
            this.Hide();
        }

        private void picEmail_Click(object sender, EventArgs e)
        {
            EmailBunifu Emails = new EmailBunifu();
            Emails.Show();
            this.Hide();
        }
        #endregion

        #region Biblia
        private void cbbLivro_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT capitulo FROM biblia WHERE livro LIKE '" + cbbLivro.Text + "' ORDER BY id_biblia asc", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                DataRow row = table.NewRow();
                row["CAPITULO"] = "";

                table.Rows.InsertAt(row, 0);

                cbbCapitulo.DataSource = table;
                cbbCapitulo.DisplayMember = "CAPITULO";

            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message); 
            }
        }

        private void cbbCapitulo_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT capitulo, texto FROM public.biblia WHERE capitulo LIKE '" + cbbCapitulo.Text + "'", Conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())

                {
                    rtTexto.Text = dr[1] + "\n"; //pontos
                }

                rtTexto.Focus();
            }
            catch (Exception Ex)
            {
                GESTEC.Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
        }
    }
}
