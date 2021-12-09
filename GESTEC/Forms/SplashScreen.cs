using GESTEC.Forms;
using System;

namespace GESTEC
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        
        #region Load
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        #endregion

        #region Animações
        private void timer1_Tick(object sender, EventArgs e)
        {
            while (metroProgressBar1.Value < 100)
            {
                metroProgressBar1.Value ++;
            }
            timer1.Stop();

            ControleBunifu controle = new ControleBunifu();
            controle.Show();
            this.Hide();          
        }
        #endregion

    }
}
