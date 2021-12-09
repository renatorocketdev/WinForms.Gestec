using GESTEC.BLL;
using GESTEC.Forms.Listas;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class EmpresaBunifu : MaterialForm
    {
        public EmpresaBunifu()
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

            txtCNPJ.Text = "";
            txtCNPJ.Mask = "00,000,000/0000-00";
        }

        #region Panel Superior
        //Mover e Arrastar
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

        private void picVagas_Click(object sender, EventArgs e)
        {
            VagasV2Bunifu Vagas = new VagasV2Bunifu();
            Vagas.Show();
            this.Hide();
        }

        private void picCargos_Click(object sender, EventArgs e)
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

        private void picBiblia_Click(object sender, EventArgs e)
        {
            BibliaBunifu Biblia = new BibliaBunifu();
            Biblia.Show();
            this.Hide();
        }
        #endregion

        #region Botões Principais
        private void BtnLista_Click(object sender, EventArgs e)
        {
            ListaEmpresa Lista = new ListaEmpresa();
            Lista.ShowDialog();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtInscEstadual.Text == "" || txtInscMunicipal.Text == "" ||
               txtNomeFantasia.Text == "" || cbbEstado.Text == "" || cbbMunicipio.Text == " " ||
               txtContato1.Text == "" || txtCNPJ.Text == "")
            {
                Warning.ShowDialog("Preencha os Campos Obrigatórios! (*)");
                //MessageBox.Show("Preencha os Campos Obrigatórios!! (*)", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(1) FROM EMPRESAS WHERE CNPJ = '" + txtCNPJ.Text + "'", Conn);

                int UserExist = Convert.ToInt32(cmd.ExecuteScalar());

                if (UserExist > 0)
                {
                    Warning.ShowDialog("Este CNPJ Já Existe no Banco de Dados");
                    //MessageBox.Show("Este CNPJ Já Existe no Banco de Dados", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string valor = txtCNPJ.Text;

                    if (ValidaBLL.IsCnpj(valor))
                    {
                        mensagem = "O número é um CNPJ Válido !";
                        Sucess.ShowDialog(mensagem);

                        var bll = new BLL.EmpresaBLL();
                        bll.Inserir(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                            txtRua, txtNumero, txtBairro, cbbEstado, cbbMunicipio, txtContato1, txtContato2, txtObservacao1,
                            txtObservacao2, txtEmail);

                        bll.LimparCampos(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                        cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2,
                        txtObservacao1, txtObservacao2, txtEmail, materialCheckBox1);
                    }
                    else
                    {
                        mensagem = "O número é um CNPJ Inválido !";
                        Warning.ShowDialog(mensagem);
                    }
                    //MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /**/
            }

        }
        #endregion

        #region Valida CNPJ
        string mensagem = "";

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valor = txtCNPJ.Text;
            if (ValidaBLL.IsCnpj(valor))
            {
                mensagem = "O número é um CNPJ Válido !";
                Sucess.ShowDialog(mensagem);
            }
            else
            {
                mensagem = "O número é um CNPJ Inválido !";
                Warning.ShowDialog(mensagem);
            }

            //MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Ao Carregar
        private void EmpresaBunifu_Load(object sender, EventArgs e)
        {
            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);
        }
        #endregion

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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
        }

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