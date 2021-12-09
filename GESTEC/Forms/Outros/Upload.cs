using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using GESTEC;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FTP24CP
{
    public partial class frmUpload : MaterialForm
    {
        string ftpIPServidor;
        string ftpUsuarioID;
        string ftpSenha;
        public static string NomeProfissional;

        public frmUpload()
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

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            //aqui você deve colocar os dados do servidor ftp e suas credenciais
            ftpIPServidor = "143.208.8.46";
            ftpUsuarioID = "thercio";
            ftpSenha = "Sl2018";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    Upload(file);
                }
            }

            Sucess.ShowDialog("Upload Feito Com Sucesso!!");

            string[] nomeArquivos = GetListaArquivos();
            lbArquivos.Items.Clear();
            foreach (string _nomeArquivo in nomeArquivos)
            {
                lbArquivos.Items.Add(_nomeArquivo);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();
            if (txtUpload.Text.Trim().Length > 0)
            {
                if (fldDlg.ShowDialog() == DialogResult.OK)
                {
                    Download(fldDlg.SelectedPath, txtUpload.Text.Trim());
                }
            }
            else
            {
                Warning.ShowDialog("Informe o Nome do Arquivo para Download");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldDlg = new OpenFileDialog();
            if (txtUpload.Text.Trim().Length > 0)
            {
                DeletarFTP(txtUpload.Text.Trim());

                string[] nomeArquivos = GetListaArquivos();
                lbArquivos.Items.Clear();
                foreach (string _nomeArquivo in nomeArquivos)
                {
                    lbArquivos.Items.Add(_nomeArquivo);
                }
            }
            else
            {
                Warning.ShowDialog("Informe o nome do arquivo para deletar");
            }
        }

        private void lbArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbArquivos.SelectedIndex > 0)
            {
                if (lbArquivos.SelectedIndex == 1)
                {
                    txtNomePastaLista.Text = "";

                    string[] nomeArquivos = GetListaArquivos();
                    lbArquivos.Items.Clear();
                    foreach (string _nomeArquivo in nomeArquivos)
                    {
                        lbArquivos.Items.Add(_nomeArquivo);
                    }
                }
                else
                {
                    if (lbArquivos.Text.Contains(".jpeg") || lbArquivos.Text.Contains(".jpg"))
                    {
                        int i = lbArquivos.SelectedIndex;
                        string Valor = lbArquivos.Items[i].ToString();

                        txtArquivoNomeAtual.Text = Valor;
                        txtUpload.Text = Valor;

                    }
                    else if (lbArquivos.Text.Contains(".pdf"))
                    {
                        int i = lbArquivos.SelectedIndex;
                        string Valor = lbArquivos.Items[i].ToString();

                        txtArquivoNomeAtual.Text = Valor;
                        txtUpload.Text = Valor;
                    }
                    else
                    {
                        int i = lbArquivos.SelectedIndex;
                        string Valor = lbArquivos.Items[i].ToString();

                        txtNomePastaLista.Text = Valor;

                        string[] nomeArquivos = GetListaArquivos();
                        lbArquivos.Items.Clear();
                        foreach (string _nomeArquivo in nomeArquivos)
                        {
                            lbArquivos.Items.Add(_nomeArquivo);
                        }
                    }
                }
            }
            else
            {
                Warning.ShowDialog("Pasta Invalida");
            }
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            if (txtArquivoNomeAtual.Text.Contains(".jpeg") || txtArquivoNomeAtual.Text.Contains(".jpg"))
            {
                if (txtArquivoNovoNome.Text == "")
                {
                    Warning.ShowDialog("O Novo Nome do Arquvo não Pode Ser em Branco");
                }
                else
                {
                    if (txtArquivoNomeAtual.Text.Contains(".jpeg"))
                    {
                        string nome = txtArquivoNovoNome.Text + ".jpeg";
                        Rename(txtArquivoNomeAtual.Text.Trim(), nome.Trim());

                        txtArquivoNomeAtual.Text = String.Empty;
                        txtArquivoNovoNome.Text = String.Empty;
                        txtUpload.Text = String.Empty;

                        string[] nomeArquivos = GetListaArquivos();
                        lbArquivos.Items.Clear();
                        foreach (string _nomeArquivo in nomeArquivos)
                        {
                            lbArquivos.Items.Add(_nomeArquivo);
                        }
                    }

                    if (txtArquivoNomeAtual.Text.Contains(".jpg"))
                    {
                        string nome = txtArquivoNovoNome.Text + ".jpg";
                        Rename(txtArquivoNomeAtual.Text.Trim(), nome.Trim());

                        txtArquivoNomeAtual.Text = String.Empty;
                        txtArquivoNovoNome.Text = String.Empty;
                        txtUpload.Text = String.Empty;

                        string[] nomeArquivos = GetListaArquivos();
                        lbArquivos.Items.Clear();
                        foreach (string _nomeArquivo in nomeArquivos)
                        {
                            lbArquivos.Items.Add(_nomeArquivo);
                        }
                    }

                }
            }
            else if (txtArquivoNomeAtual.Text.Contains(".pdf"))
            {
                if (txtArquivoNovoNome.Text == "")
                {
                    Warning.ShowDialog("O Novo Nome do Arquvo não Pode Ser em Branco");
                }
                else
                {
                    string nome = txtArquivoNovoNome.Text + ".pdf";
                    Rename(txtArquivoNomeAtual.Text.Trim(), nome.Trim());

                    txtArquivoNomeAtual.Text = String.Empty;
                    txtArquivoNovoNome.Text = String.Empty;
                    txtUpload.Text = String.Empty;

                    string[] nomeArquivos = GetListaArquivos();
                    lbArquivos.Items.Clear();
                    foreach (string _nomeArquivo in nomeArquivos)
                    {
                        lbArquivos.Items.Add(_nomeArquivo);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo Invalido");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            string[] nomeArquivos = GetListaArquivos();
            lbArquivos.Items.Clear();
            foreach (string _nomeArquivo in nomeArquivos)
            {
                lbArquivos.Items.Add(_nomeArquivo);
            }
        }

        private void btnNovoDiretorio_Click(object sender, EventArgs e)
        {
            CriarDiretorio(txtNovoDiretorio.Text.Trim());

            string[] nomeArquivos = GetListaArquivos();
            lbArquivos.Items.Clear();
            foreach (string _nomeArquivo in nomeArquivos)
            {
                lbArquivos.Items.Add(_nomeArquivo);
            }
        }
        #endregion

        #region Metodos
        private void Upload(string _nomeArquivo)
        {
            if (txtNomePastaLista.Text == "")
            {
                FileInfo _arquivoInfo = new FileInfo(_nomeArquivo);
                string uri = "ftp://" + ftpIPServidor + "/GESTEC/" + _arquivoInfo.Name;
                FtpWebRequest requisicaoFTP;

                // Cria um objeto FtpWebRequest a partir da Uri fornecida
                requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + _arquivoInfo.Name));

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
                    Warning.ShowDialog(ex.Message + " Erro no Upload");
                }
            }
            else
            {
                FileInfo _arquivoInfo = new FileInfo(_nomeArquivo);
                string uri = "ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _arquivoInfo.Name;
                FtpWebRequest requisicaoFTP;

                // Cria um objeto FtpWebRequest a partir da Uri fornecida
                requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _arquivoInfo.Name));

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
                    Warning.ShowDialog(ex.Message + " Erro no Upload");
                }
            }
        }

        private void Download(string _caminhoArquivo, string _nomeArquivo)
        {
            FtpWebRequest requisicaoFTP;
            try
            {
                if (txtNomePastaLista.Text == "")
                {
                    FileStream outputStream = new FileStream(_caminhoArquivo + "\\" + _nomeArquivo, FileMode.Create);

                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + _nomeArquivo));
                    requisicaoFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();
                    long cl = response.ContentLength;
                    int bufferSize = 2048;
                    int lerContador;
                    byte[] buffer = new byte[bufferSize];

                    lerContador = ftpStream.Read(buffer, 0, bufferSize);
                    while (lerContador > 0)
                    {
                        outputStream.Write(buffer, 0, lerContador);
                        lerContador = ftpStream.Read(buffer, 0, bufferSize);
                    }

                    ftpStream.Close();
                    outputStream.Close();
                    response.Close();

                    Sucess.ShowDialog("Download Feito Com Sucesso!!");
                }
                else
                {
                    FileStream outputStream = new FileStream(_caminhoArquivo + "\\" + _nomeArquivo, FileMode.Create);

                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _nomeArquivo));
                    requisicaoFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();
                    long cl = response.ContentLength;
                    int bufferSize = 2048;
                    int lerContador;
                    byte[] buffer = new byte[bufferSize];

                    lerContador = ftpStream.Read(buffer, 0, bufferSize);
                    while (lerContador > 0)
                    {
                        outputStream.Write(buffer, 0, lerContador);
                        lerContador = ftpStream.Read(buffer, 0, bufferSize);
                    }

                    ftpStream.Close();
                    outputStream.Close();
                    response.Close();

                    Sucess.ShowDialog("Download Feito Com Sucesso!!");
                }
            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message);
            }
        }

        public void DeletarFTP(string _nomeArquivo)
        {
            try
            {
                if (txtNomePastaLista.Text == "")
                {
                    string uri = "ftp://" + ftpIPServidor + "/GESTEC/" + _nomeArquivo;
                    FtpWebRequest requisicaoFTP;
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + _nomeArquivo));

                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    requisicaoFTP.KeepAlive = false;
                    requisicaoFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                    string resultado = String.Empty;
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    long size = response.ContentLength;
                    Stream datastream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(datastream);
                    resultado = sr.ReadToEnd();

                    Sucess.ShowDialog("Arquivo Deletado Com Sucesso!!");

                    sr.Close();
                    datastream.Close();
                    response.Close();


                }
                else
                {
                    string uri = "ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _nomeArquivo;
                    FtpWebRequest requisicaoFTP;
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _nomeArquivo));

                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    requisicaoFTP.KeepAlive = false;
                    requisicaoFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                    string resultado = String.Empty;
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    long size = response.ContentLength;
                    Stream datastream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(datastream);
                    resultado = sr.ReadToEnd();

                    Sucess.ShowDialog("Arquivo Deletado Com Sucesso!!");

                    sr.Close();
                    datastream.Close();
                    response.Close();
                }

            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message + " Erro no Download");
            }
        }

        private void Rename(string _nomeAtualArquivo, string _novoNomeArquivo)
        {
            FtpWebRequest requisicaoFTP;
            try
            {
                if (txtNomePastaLista.Text == "")
                {
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + _nomeAtualArquivo));
                    requisicaoFTP.Method = WebRequestMethods.Ftp.Rename;
                    requisicaoFTP.RenameTo = _novoNomeArquivo;
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();

                    ftpStream.Close();
                    response.Close();

                    Sucess.ShowDialog("Arquivo Renomeado com Sucesso");

                }
                else
                {
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _nomeAtualArquivo));
                    requisicaoFTP.Method = WebRequestMethods.Ftp.Rename;
                    requisicaoFTP.RenameTo = _novoNomeArquivo;
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();

                    ftpStream.Close();
                    response.Close();

                    Sucess.ShowDialog("Arquivo Renomeado com Sucesso");
                }

            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message);
            }
        }

        private void CriarDiretorio(string _nomeDiretorio)
        {
            NomeProfissional = GESTEC.Forms.ProfissionaisBunifu.NomeProfissional;
            _nomeDiretorio = NomeProfissional;
            FtpWebRequest requisicaoFTP;
            try
            {
                if (txtNomePastaLista.Text == "")
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

                    Sucess.ShowDialog("Diretório Criado Com Sucesso!!");
                }
                else
                {
                    // _nomeDiretorio = nome do diretorio a ser criado
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/" + _nomeDiretorio));
                    requisicaoFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                    Stream ftpStream = response.GetResponseStream();

                    ftpStream.Close();
                    response.Close();

                    Sucess.ShowDialog("Diretório Criado Com Sucesso!!");
                }
            }
            catch (Exception ex)
            {
                Warning.ShowDialog(ex.Message);
            }
        }

        public string[] GetListaArquivos()
        {
            string[] downloadArquivos;
            StringBuilder resultado = new StringBuilder();
            FtpWebRequest requisicaoFTP;
            try
            {
                if (txtNomePastaLista.Text == "")
                {
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/"));
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    requisicaoFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                    WebResponse response = requisicaoFTP.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    //MessageBox.Show(reader.ReadToEnd());
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        resultado.Append(line);
                        resultado.Append("\n");
                        line = reader.ReadLine();
                    }
                    resultado.Remove(resultado.ToString().LastIndexOf('\n'), 1);
                    reader.Close();
                    response.Close();
                    //MessageBox.Show(response.StatusDescription);
                    return resultado.ToString().Split('\n');
                }
                else
                {
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpIPServidor + "/GESTEC/" + txtNomePastaLista.Text + "/"));
                    requisicaoFTP.UseBinary = true;
                    requisicaoFTP.Credentials = new NetworkCredential(ftpUsuarioID, ftpSenha);
                    requisicaoFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                    WebResponse response = requisicaoFTP.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    //MessageBox.Show(reader.ReadToEnd());
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        resultado.Append(line);
                        resultado.Append("\n");
                        line = reader.ReadLine();
                    }
                    resultado.Remove(resultado.ToString().LastIndexOf('\n'), 1);
                    reader.Close();
                    response.Close();
                    //MessageBox.Show(response.StatusDescription);
                    return resultado.ToString().Split('\n');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                downloadArquivos = null;
                return downloadArquivos;
            }
        }
        #endregion
    }
}