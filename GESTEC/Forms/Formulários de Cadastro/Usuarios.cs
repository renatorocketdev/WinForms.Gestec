using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class UsuariosBunifu : MaterialForm
    {
        public UsuariosBunifu()
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
        public static string PERMISSAO;
        public static string login;
        public static string senha;

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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
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
        private void PicProfissionais_Click(object sender, EventArgs e)
        {
            ProfissionaisBunifu Profissionais = new ProfissionaisBunifu();
            Profissionais.Show();
            this.Hide();
        }

        private void PicEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaBunifu Empresa = new EmpresaBunifu();
            Empresa.Show();
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

        #region Ao Carregar
        private void UsuariosBunifu_Load(object sender, EventArgs e)
        {
            //Verifica qual usuario está logado:
            PERMISSAO = LoginBLL.ValorPermissao;
            if (PERMISSAO == "ADMINISTRADOR")
            {
                UsuariosBLL bll = new UsuariosBLL();
                bll.CarregarGrid_Administrador(DataGridUsuarios);
            }
            else if (PERMISSAO == "OPERADOR")
            {
                UsuariosBLL bll = new UsuariosBLL();
                bll.CarregarGrid_Operador(DataGridUsuarios);
            }

        }
        #endregion

        #region GridToTXT
        private void DataGridUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica qual usuario está logado:
            PERMISSAO = LoginBLL.ValorPermissao;

            if (PERMISSAO == "ADMINISTRADOR")
            {
                UsuariosBLL bll = new UsuariosBLL();
                bll.GridTotxt_ADM(DataGridUsuarios, txtNome, txtSenha, txtDataNascimento, txtCPF, cbbPermissao);
            }
            else if (PERMISSAO == "OPERADOR")
            {
                UsuariosBLL bll = new UsuariosBLL();
                bll.GridTotxt_Operador(DataGridUsuarios, txtNome, txtDataNascimento, txtCPF, cbbPermissao);
            }

        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            senha = LoginBLL.SalvaSenha;
            login = LoginBLL.SalvaEmail;
            PERMISSAO = LoginBLL.ValorPermissao;
            string mensagem = "";

            NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            //Alterar Somente Senha:
            if (rdbDocumentos.Checked == true)
            {
                //Se o Login e Senha estiverem Corretos:
                if(PERMISSAO.Contains("ADMINISTRADOR"))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE USUARIOS SET " +
                        "CPF = @CPF, NASCIMENTO = @NASCIMENTO WHERE NOME = @NOME", Conn);

                    //Recebe CPF:
                    string valor = txtCPF.Text;

                    //Se o CPF for Valido:
                    if (ValidaBLL.IsCpf(valor))
                    {
                        mensagem = "O número é um CPF Válido !";

                        cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                        cmd.Parameters.AddWithValue("NASCIMENTO", txtDataNascimento.Text);
                        cmd.Parameters.AddWithValue("NOME", txtNome.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            Sucess.ShowDialog("Dados Atualizados com Sucesso");
                            Application.Restart();

                            if (PERMISSAO == "ADMINISTRADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Administrador(DataGridUsuarios);
                            }
                            else if (PERMISSAO == "OPERADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Operador(DataGridUsuarios);
                            }

                            //Limpar Campos:
                            txtCPF.Text = string.Empty;
                            txtDataNascimento.Text = string.Empty;
                            //txtNovaSenha.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtNome.Text = string.Empty;

                        }
                        catch (Exception Ex) { Warning.ShowDialog("Error ao Atualizar Dados" + Ex.Message); }
                    }
                    else
                    {
                        mensagem = "O número é um CPF Inválido !";
                    }

                    MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (txtNome.Text == login && txtSenha.Text == senha)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE USUARIOS SET " +
                        "CPF = @CPF, NASCIMENTO = @NASCIMENTO WHERE NOME = @NOME", Conn);

                    //Recebe CPF:
                    string valor = txtCPF.Text;

                    //Se o CPF for Valido:
                    if (ValidaBLL.IsCpf(valor))
                    {
                        mensagem = "O número é um CPF Válido !";

                        cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                        cmd.Parameters.AddWithValue("NASCIMENTO", txtDataNascimento.Text);
                        cmd.Parameters.AddWithValue("NOME", login);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            Sucess.ShowDialog("Dados Atualizados com Sucesso");
                            Application.Restart();

                            if (PERMISSAO == "ADMINISTRADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Administrador(DataGridUsuarios);
                            }
                            else if (PERMISSAO == "OPERADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Operador(DataGridUsuarios);
                            }

                            //Limpar Campos:
                            txtCPF.Text = string.Empty;
                            txtDataNascimento.Text = string.Empty;
                            //txtNovaSenha.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtNome.Text = string.Empty;

                        }
                        catch (Exception Ex) { Warning.ShowDialog("Error ao Atualizar Dados" + Ex.Message); }
                    }
                    else
                    {
                        mensagem = "O número é um CPF Inválido !";
                    }

                    MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Warning.ShowDialog("Senha ou Login Atual Incorretos");
                }
            }

            else if (rdbSenha.Checked == true)
            {
                if(PERMISSAO.Contains("ADMINISTRADOR"))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE USUARIOS SET " +
                        "SENHA = @SENHA WHERE NOME = @NOME", Conn);

                    if (txtNovaSenha.Text == "")
                    {
                        Warning.ShowDialog("O Campo Nova Senha não Pode Ser Vázio");
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("SENHA", txtNovaSenha.Text);
                        cmd.Parameters.AddWithValue("NOME", txtNome.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            Sucess.ShowDialog("Dados Atualizados com Sucesso");
                            Application.Restart();

                            if (PERMISSAO == "ADMINISTRADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Administrador(DataGridUsuarios);
                            }
                            else if (PERMISSAO == "OPERADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Operador(DataGridUsuarios);
                            }

                            //Limpar Campos:
                            //txtCPF.Text = string.Empty;
                            txtDataNascimento.Text = string.Empty;
                            txtNovaSenha.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtNome.Text = string.Empty;

                        }
                        catch (Exception Ex) { Warning.ShowDialog("Error ao Atualizar Dados" + Ex.Message); }
                    }
                }
                //Se o Login e Senha estiverem Corretos:
                if (txtNome.Text == login && txtSenha.Text == senha)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE USUARIOS SET " +
                        "SENHA = @SENHA WHERE NOME = @NOME", Conn);

                    if (txtNovaSenha.Text == "")
                    {
                        Warning.ShowDialog("O Campo Nova Senha não Pode Ser Vázio");
                    }
                        
                    else
                    {
                        cmd.Parameters.AddWithValue("SENHA", txtNovaSenha.Text);
                        cmd.Parameters.AddWithValue("NOME", login);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            Sucess.ShowDialog("Dados Atualizados com Sucesso");
                            Application.Restart();

                            if (PERMISSAO == "ADMINISTRADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Administrador(DataGridUsuarios);
                            }
                            else if (PERMISSAO == "OPERADOR")
                            {
                                UsuariosBLL bll = new UsuariosBLL();
                                bll.CarregarGrid_Operador(DataGridUsuarios);
                            }

                            //Limpar Campos:
                            //txtCPF.Text = string.Empty;
                            txtDataNascimento.Text = string.Empty;
                            txtNovaSenha.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtNome.Text = string.Empty;

                        }
                        catch (Exception Ex) { Warning.ShowDialog("Error ao Atualizar Dados" + Ex.Message); }
                    }
                }
                else
                {
                    Warning.ShowDialog("Senha ou Login Atual Incorretos");
                }
            }
        }
        #endregion

        #region Checked Change
        private void rdbDocumentos_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.Enabled = false;

            txtCPF.Enabled = true;
            txtDataNascimento.Enabled = true;
        }

        private void rdbSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Enabled = false;
            txtDataNascimento.Enabled = false;

            txtSenha.Enabled = true;
            txtNovaSenha.Enabled = true;
        }
        #endregion
    }
}