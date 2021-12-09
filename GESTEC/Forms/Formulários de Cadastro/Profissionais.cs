using FTP24CP;
using GESTEC.BLL;
using GESTEC.Forms.Listas;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class ProfissionaisBunifu : MaterialForm
    {
        string ftpIPServidor;
        string ftpUsuarioID;
        string ftpSenha;

        public static string NomeProfissional;

        public ProfissionaisBunifu()
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

            ftpIPServidor = "143.208.8.46";
            ftpUsuarioID = "thercio";
            ftpSenha = "Sl2018";

            cbbMunicipio.Enabled = false;

            txtCPF.Text = "";
            txtCPF.Mask = "000,000,000-00";
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

        private void PicEmail_Click(object sender, EventArgs e)
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

        #region Botões Principais

        #region Salvar

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "" || !txtCPF.MaskCompleted || !txtPIS.MaskCompleted || cbbEstado.Text == "" || cbbMunicipio.Text == "" ||
               txtBairro.Text == "" || cbbEscolaridade.Text == "" || !txtContato1.MaskCompleted || !txtDataNascimento.MaskCompleted)
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
                    NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                    Conn.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(1) FROM PROFISSIONAIS WHERE CPF = '" + txtCPF.Text + "'", Conn);

                    int UserExist = Convert.ToInt32(cmd.ExecuteScalar());

                    if (UserExist > 0)
                    {
                        Warning.ShowDialog("Este CPF Já Existe no Banco de Dados");
                    }
                    else
                    {
                        if (txtCurso1.Text != string.Empty && txtCurso3.Text != string.Empty && txtCurso2.Text == string.Empty)
                        {
                            Warning.ShowDialog("A Ordem dos Cursos devem ser Preenchidas Corretamente.");
                        }
                        else
                        {
                            if (txtCurso1.Text != string.Empty && txtCurso3.Text != string.Empty && txtCurso2.Text == string.Empty)
                            {
                                Warning.ShowDialog("A Ordem das Empresas devem ser Preenchidas Corretamente.");
                            }
                            else
                            {
                                string valor = txtCPF.Text;

                                if (ValidaBLL.IsCpf(valor))
                                {
                                    mensagem = "O número é um CPF Válido!";

                                    ProfissionaisBLL bll = new ProfissionaisBLL();
                                    bll.Salvar(txtNomeCompleto, txtDataNascimento,
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
                                else
                                {
                                    mensagem = "O número é um CPF Inválido !";
                                }

                                MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Lista
        private void BtnLista_Click(object sender, EventArgs e)
        {
            ListaProfissionais Profissionais = new ListaProfissionais();
            Profissionais.ShowDialog();
        }

        #endregion

        #region Arquivos
        private void btnArquivos_Click(object sender, EventArgs e)
        {
            frmUpload arquivos = new frmUpload();
            arquivos.ShowDialog();
        }
        #endregion

        #region Upload
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "")
            {
                Warning.ShowDialog("O Nome Deve ser Preenchido!!");
            }
            else
            {
                CriarDiretorio(txtNomeCompleto.Text);

                this.openFileDialog1.Multiselect = true;

                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    // Read the files
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        Upload(file);
                    }
                }

                Sucess.ShowDialog("Upload Feito Com Sucesso!!");
            }
        }
        #endregion

        #endregion

        #region Ao Carregar
        private void ProfissionaisBunifu_Load(object sender, EventArgs e)
        {
            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);

            //Foca Tab:
            metroTabPagePessoal.Focus();
        }
        #endregion

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

        #region Eventos
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

        private void cbbCNH_TextChanged(object sender, EventArgs e)
        {
            if (cbbCNH.Text == "Sim")
            {
                cbbCatCnh.Enabled = true;
            }
            else
            {
                cbbCatCnh.Text = "";
                cbbCatCnh.Enabled = false;
            }
        }

       

        private void CriarDiretorio(string _nomeDiretorio)
        {
            _nomeDiretorio = txtNomeCompleto.Text.Trim();

            FtpWebRequest requisicaoFTP;
            try
            {
                // _nomeDiretorio = nome do diretorio a ser criado
                requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + _nomeDiretorio));
                requisicaoFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                requisicaoFTP.UseBinary = true;
                requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message);
            }
        }

        private void Upload(string _nomeArquivo)
        {
            FileInfo _arquivoInfo = new FileInfo(_nomeArquivo);
            string uri = "ftp://" + ftpIPServidor + "/GESTEC/" + txtCPF.Text.Replace(".", "").Replace("-", "").Trim() + "/" + _arquivoInfo.Name;
            FtpWebRequest requisicaoFTP;

            // Cria um objeto FtpWebRequest a partir da Uri fornecida
            requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtCPF.Text.Replace(".", "").Replace("-", "").Trim() + "/" + _arquivoInfo.Name));

            // Fornece as credenciais de WebPermission
            requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);

            // Por padrão KeepAlive é true, 
            requisicaoFTP.KeepAlive = false;

            // Especifica o comando a ser executado
            requisicaoFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Especifica o tipo de dados a ser transferido
            requisicaoFTP.UseBinary = true;

            // Notifica o servidor seobre o tamanho do arquivo a enviar
            requisicaoFTP.ContentLength = _arquivoInfo.Length;

            // Define o tamanho do buffer para 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int _tamanhoConteudo;

            // Abre um stream (System.IO.FileStream) para o arquivo a ser enviado
            FileStream fs = _arquivoInfo.OpenRead();

            try
            {
                // Stream  para o qual o arquivo a ser enviado será escrito
                Stream strm = requisicaoFTP.GetRequestStream();

                // Lê a partir do arquivo stream, 2k por vez
                _tamanhoConteudo = fs.Read(buff, 0, buffLength);

                // ate o conteudo do stream terminar
                while (_tamanhoConteudo != 0)
                {
                    // Escreve o conteudo a partir do arquivo para o stream FTP 
                    strm.Write(buff, 0, _tamanhoConteudo);
                    _tamanhoConteudo = fs.Read(buff, 0, buffLength);
                }

                // Fecha o stream a requisição
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message + "Erro de Upload");
            }
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
        #endregion
    }
}