using GESTEC.BLL;
using GESTEC.Forms.Formulários_de_Cadastro;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class ControleBunifu : Form
    {
        public ControleBunifu()
        {
            InitializeComponent();
        }
        public static string permsisao;

        #region Panel Superior
        //Controles do Form - Mover e Arrastar
        int TogMove;
        int mValX;
        int mValy;

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValX = e.X;
            mValy = e.Y;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValy);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        #endregion

        #region Botões Superiores
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        #region Menu Principal
        private void PicUser_Click(object sender, EventArgs e)
        {
            UsuariosBunifu Usuarios = new UsuariosBunifu();
            Usuarios.Show();
            this.Hide();
        }

        private void PicEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaBunifu Empresa = new EmpresaBunifu();
            Empresa.Show();
            this.Hide();
        }

        private void PicProfissionais_Click(object sender, EventArgs e)
        {
            ProfissionaisBunifu Profissionais = new ProfissionaisBunifu();
            Profissionais.Show();
            this.Hide();
        }

        private void PicVagas_Click(object sender, EventArgs e)
        {
            VagasV2Bunifu Vagas = new VagasV2Bunifu();
            Vagas.Show();
            this.Hide();
        }

        private void PicCargos_Click(object sender, EventArgs e)
        {
            CargosV2Bunifu Cargos = new CargosV2Bunifu();
            Cargos.Show();
            this.Hide();
        }

        private void PicEmails_Click(object sender, EventArgs e)
        {
            EmailBunifu Emails = new EmailBunifu();
            Emails.Show();
            this.Hide();
        }

        private void PicBiblia_Click(object sender, EventArgs e)
        {
            BibliaBunifu Biblia = new BibliaBunifu();
            Biblia.Show();
            this.Hide();
        }
        #endregion

        //Ao abrir form:
        private void ControleBunifu_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            string formattedTime = time.ToString("dd/MM/yyyy");

            lblData.Text = "Maragori - " + formattedTime;

            permsisao = LoginBLL.ValorPermissao;
            //Permissão Logado:
            if (permsisao == "OPERADOR")
            {
                bunifuCustomLabelPermissao.Text = "Logado como Operador";
                bunifuCustomLabelPermissao.Left = 735;
                bunifuCustomLabelPermissao.Top = 11;

            }
            else if (permsisao == "ADMINISTRADOR")
            {
                bunifuCustomLabelPermissao.Text = "Logado como Administrador";
            }

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            //Desloga:
            Application.Restart();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos frm = new Cursos();
            frm.Show();
            //this.Hide();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            Alunos frm = new Alunos();
            frm.Show();
            //this.Hide();
        }
    }
}
