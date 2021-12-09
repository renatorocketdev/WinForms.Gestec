using GESTEC.BLL;
using GESTEC.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class Login : MaterialForm
    {
        public Login()
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

        #region Panel Superior
        //Controles do Form - Mover e Arrastar
        int TogMove;
        int mValX;
        int mValy;

        private void Panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValX = e.X;
            mValy = e.Y;
        }

        private void Panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValy);
            }
        }

        private void Panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        #endregion

        #region Botões Superiores
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Botões Principais
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            LoginBLL bll = new LoginBLL();
            bll.Login(txtEmail, txtSenhaEmail, cbbPermissaoLogin);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #endregion

        #region Registrar

        #region ADM
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNomeAdm.Text == "admin" && txtSenhaAdm.Text == "admin")
            {
                txtNomeUser.Enabled = true;
                txtSenhaUser.Enabled = true;
                txtCPFUser.Enabled = true;
                txtNascimentoUser.Enabled = true;
                cbbPermissao.Enabled = true;
                btnRegistrarUser.Enabled = true;

                timer2.Start();
                txtNomeAdm.Enabled = false;
                txtSenhaAdm.Enabled = false;
            }
            else
            {
                //MessageBox:
                Warning.ShowDialog("Credenciais Inválidas");
                //MessageBox.Show("Credenciais Inválidas", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Registrar Novo Usuarios
        private void btnRegistrarUser_Click_1(object sender, EventArgs e)
        {
            string mensagem = "";
            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            //Antes de Inserir, verifica se CPF é valido:
            string valor = txtCPFUser.Text;

            if (ValidaBLL.IsCpf(valor))
            {
                mensagem = "O número é um CPF Válido!";
                Sucess.ShowDialog(mensagem);
                //MessageBox.Show(mensagem, "Validação");

                OperacoesDAL dal = new OperacoesDAL();

                try
                {
                    string sqlInsert = "INSERT INTO USUARIOS (NOME, SENHA, CPF, NASCIMENTO, PERMISSAO) VALUES (@NOME, @SENHA, @CPF, @NASCIMENTO, @PERMISSAO)";
                    string[] campos = { "@NOME", "@SENHA", "@CPF", "@NASCIMENTO", "@PERMISSAO" };
                    string[] valores = { txtNomeUser.Text, txtSenhaUser.Text, txtCPFUser.Text, txtNascimentoUser.Text, cbbPermissao.Text};
                    dal.Salvar(campos, valores, sqlInsert);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                }


                /*NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO USUARIOS (NOME, SENHA, CPF, NASCIMENTO, PERMISSAO) VALUES (@NOME, @SENHA, @CPF, @NASCIMENTO, @PERMISSAO)", Conn);

                cmd.Parameters.AddWithValue("NOME", txtNomeUser.Text);
                cmd.Parameters.AddWithValue("SENHA", txtSenhaUser.Text);
                cmd.Parameters.AddWithValue("CPF", txtCPFUser.Text);
                cmd.Parameters.AddWithValue("NASCIMENTO", txtNascimentoUser.Text);
                cmd.Parameters.AddWithValue("PERMISSAO", cbbPermissao.Text);

                try
                {
                    cmd.ExecuteNonQuery();

                    Sucess.ShowDialog("Usuário Adicionado com Sucess");
                    Application.Restart();
                    //MessageBox.Show("Usuário Adicionado com Sucesso", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {
                    Warning.ShowDialog("Erro ao salvar Usuário:" + ex.Message);
                    //MessageBox.Show("Erro ao Salvar Usuário: " + ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }
            else
            {
                mensagem = "O número é um CPF Inválido !";
                Warning.ShowDialog(mensagem);
                //MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #endregion

        #region Evento Drop Down
        private void timer1_Tick(object sender, EventArgs e)
        {         
            while (ActiveForm.Height < 450)
            {
                ActiveForm.Height ++;                
            }
            timer1.Stop();
            bunifuCardAdm.Visible = true;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            while (ActiveForm.Height < 600)
            {
                ActiveForm.Height++;
            }
            timer2.Stop();
            bunifuCardsRegistro.Visible = true;
        }
        #endregion

        #region KeyPress
        private void txtSenhaEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginBLL bll = new LoginBLL();
                bll.Login(txtEmail, txtSenhaEmail, cbbPermissaoLogin);
            }
        }

        private void cbbPermissaoLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginBLL bll = new LoginBLL();
                bll.Login(txtEmail, txtSenhaEmail, cbbPermissaoLogin);
            }
        }
        #endregion
    }
}