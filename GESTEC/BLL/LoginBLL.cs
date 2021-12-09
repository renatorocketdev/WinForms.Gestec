using GESTEC.Forms;
using MetroFramework.Controls;
using Npgsql;
using System;
using System.Data;

namespace GESTEC.BLL
{
    class LoginBLL
    {
        //Instancias:
        public static string SalvaEmail;
        public static string SalvaSenha;
        public static string ValorPermissao;

        //Método Logar:
        public void Login(MaterialSkin.Controls.MaterialSingleLineTextField txtEmail,
            MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaEmail,
            MetroComboBox cbbPermissaoLogin)
        {
            //Atribui:
            SalvaEmail = txtEmail.Text;
            SalvaSenha = txtSenhaEmail.Text;

            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                NpgsqlDataAdapter Da = new NpgsqlDataAdapter("SELECT COUNT (*) FROM USUARIOS WHERE NOME = '" + txtEmail.Text + "' AND SENHA = '" + txtSenhaEmail.Text + "' AND PERMISSAO = '" + cbbPermissaoLogin.Text + "'", Conn);
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                if (Dt.Rows[0][0].ToString() == "1")
                {
                    //Atribui variavel:
                    if (cbbPermissaoLogin.Text == "OPERADOR")
                    {
                        ValorPermissao = "OPERADOR";
                    }
                    else
                    {
                        ValorPermissao = "ADMINISTRADOR";
                    }
                    Forms.Login.ActiveForm.Hide();
                    SplashScreen splash = new SplashScreen();
                    splash.Show();
                }
                else
                {
                    Warning.ShowDialog("Os dados inseridos estão Incorretos!Tente Novamente");
                    //MessageBox.Show("Os dados inseridos estão Incorretos! Tente Novamente", "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                Warning.ShowDialog(Ex.Message);
                //MessageBox.Show(Ex.Message, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}