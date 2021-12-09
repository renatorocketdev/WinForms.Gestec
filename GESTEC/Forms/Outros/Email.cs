using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GESTEC.Forms
{
    public partial class EmailBunifu : MaterialForm
    {
        public EmailBunifu()
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

        string AcessouEmail;
        string AcessouSenha;

        OpenFileDialog CurriculoPronto;
        string filename = "";

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

        private void picCargos_Click(object sender, EventArgs e)
        {
            CargosV2Bunifu Cargos = new CargosV2Bunifu();
            Cargos.Show();
            this.Hide();
        }

        private void picBiblia_Click(object sender, EventArgs e)
        {
            BibliaBunifu Biblia = new BibliaBunifu();
            Biblia.Show();
            this.Hide();
        }
        #endregion

        #region Importar PDF

        public void BtnImportar_Click(object sender, EventArgs e)
        {
            /*try
            {
                CurriculoPronto = new OpenFileDialog
                {
                    Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf"
                };

                CurriculoPronto.Multiselect = true;

                if (CurriculoPronto.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in CurriculoPronto.FileNames)
                    {
                        filename = file;
                    }

                    //filename = CurriculoPronto.FileNames;
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }*/
        }
        #endregion

        #region Enviar Email
        public void BtnEnviar_Click(object sender, EventArgs e)
        {
            AcessouEmail = "setegre@maragogi.al.gov.br";
            AcessouSenha = "setegre2018";

            /*if (AcessouEmail.Contains("gmail.com"))
            {
                try
                {
                    SmtpClient DetCliente = new SmtpClient
                    {
                        Port = 587,
                        Host = "smtp.gmail.com",
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(AcessouEmail, AcessouSenha)
                    };

                    MailMessage DetEmail = new MailMessage
                    {
                        From = new MailAddress(txtEmailEnvio.Text.Trim())
                    };
                    DetEmail.To.Add(txtEmailEnvio.Text.Trim());
                    DetEmail.Subject = txtAssunto.Text.Trim();
                    DetEmail.Body = rtbDetalhesEmail.Text.Trim();

                    if (cbbImportar.Text == "Não" || cbbImportar.Text == "")
                    {
                        DetCliente.Send(DetEmail);
                        MessageBox.Show("Email Enviado");
                    }
                    else
                    {                       
                        this.openFileDialog1.Multiselect = true;

                        DialogResult dr = this.openFileDialog1.ShowDialog();
                        if (dr == System.Windows.Forms.DialogResult.OK)
                        {
                            // Read the files
                            foreach (String file in openFileDialog1.FileNames)
                            {
                                Attachment Arquivo = new Attachment(file);
                                DetEmail.Attachments.Add(Arquivo);
                            }
                        }
                    }
                    txtAssunto.Text = string.Empty;
                    txtEmailEnvio.Text = string.Empty;
                    rtbDetalhesEmail.Text = string.Empty;

                    filename = "";
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }*/

            if (AcessouEmail.Contains("maragogi.al.gov.br"))
            {
                try
                {
                    SmtpClient DetCliente = new SmtpClient
                    {
                        Port = 25,
                        Host = "mail.maragogi.al.gov.br",
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(AcessouEmail, AcessouSenha)
                    };

                    MailMessage DetEmail = new MailMessage
                    {
                        From = new MailAddress(txtEmailEnvio.Text.Trim())
                    };

                    if(txtEmailEnvio.Text == "")
                    {
                        Warning.ShowDialog("Preencha o Email a ser Enviado");
                    }

                    DetEmail.To.Add(txtEmailEnvio.Text.Trim());
                    DetEmail.Subject = txtAssunto.Text.Trim();
                    DetEmail.Body = rtbDetalhesEmail.Text.Trim();
                    
                    if (cbbImportar.Text == "Não" || cbbImportar.Text == "")
                    {
                        DetCliente.Send(DetEmail);
                        Sucess.ShowDialog("Email Enviado");
                    }
                    else
                    {
                        this.openFileDialog1.Multiselect = true;

                        DialogResult dr = this.openFileDialog1.ShowDialog();
                        if (dr == System.Windows.Forms.DialogResult.OK)
                        {
                            // Read the files
                            foreach (String file in openFileDialog1.FileNames)
                            {
                                Attachment Arquivo = new Attachment(file);
                                DetEmail.Attachments.Add(Arquivo);
                            }

                            string[] path = openFileDialog1.FileNames;

                            for (int index = 0; index < path.Length; index++)
                            {
                                MessageBox.Show(path[index]);
                            }

                            DialogResult res = MessageBox.Show("Deseja Cancelar Envio?", "SETEGRE", MessageBoxButtons.YesNo);

                            if (res == DialogResult.Yes)
                            {
                                txtAssunto.Text = string.Empty;
                                txtEmailEnvio.Text = string.Empty;
                                rtbDetalhesEmail.Text = string.Empty;
                                cbbImportar.SelectedIndex = -1;
                            }
                            else
                            {
                                DetCliente.Send(DetEmail);
                            }
                        }
                    }

                    txtAssunto.Text = string.Empty;
                    txtEmailEnvio.Text = string.Empty;
                    rtbDetalhesEmail.Text = string.Empty;

                    filename = "";
                }
                catch (Exception Ex) { Warning.ShowDialog(Ex.Message); }
            }
        }
        #endregion       
    }
}