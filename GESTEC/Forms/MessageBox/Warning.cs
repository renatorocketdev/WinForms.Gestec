using System;
using System.Windows.Forms;

namespace GESTEC
{
    public partial class Warning : Form
    {
        public Warning(string _message)
        {
            InitializeComponent();
            lblMessage.Text = _message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Ao Carregar
        private void Warning_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition.ShowAsyc(this);
            pictureBoxIcon.Visible = true;
        }
        #endregion

        #region Animações
        private void bunifuFormFadeTransition_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            pictureBoxIcon.Enabled = true;
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            pictureBoxIcon.Enabled = false;
            icon_delay.Stop();
            btnOk.Visible = true;
        }
        #endregion

        #region Show Dialog
        public static void ShowDialog(string message)
        {
            Warning ms = new Warning(message);
            ms.ShowDialog();
        }        
    }
    #endregion
}