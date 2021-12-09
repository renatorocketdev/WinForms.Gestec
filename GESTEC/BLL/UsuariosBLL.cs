using GESTEC.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using MaterialSkin.Controls;

namespace GESTEC.BLL
{
    class UsuariosBLL
    {
        private static int IDRegistro;

        //Método Transforma Campo:
        public void TransformaCampoMascaras(//Parametros
                                 Bunifu.Framework.UI.BunifuMaterialTextbox txtCPF,
                                 //Bunifu.Framework.UI.BunifuMaterialTextbox txtCNPJ,
                                 Bunifu.Framework.UI.BunifuMaterialTextbox txtDataNascimento)
        {
            //Máscara:
            string CPF_Format = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
            string CNPJ_Format = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
            string DATA_Format = Convert.ToUInt64(txtDataNascimento.Text).ToString(@"00\/00\/0000");

            txtCPF.Text = CPF_Format;
            //txtCNPJ.Text = CNPJ_Format;
            txtDataNascimento.Text = DATA_Format;
        }

        string AcessouEmail;
        string AcessouSenha;

        public void Teste()
        {

        }

        #region GRID Operador
        public void CarregarGrid_Operador(MetroGrid DataGridUsuarios)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM USUARIOS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<UsuariosDTO.Usuarios> Lista = new List<UsuariosDTO.Usuarios>();

                while (Dr.Read())
                {
                    Lista.Add(new UsuariosDTO.Usuarios
                    {
                        Id = Convert.ToInt32(Dr["ID_USUARIO"]),
                        Email = Dr["NOME"].ToString(),
                        //Senha = Dr["SENHA"].ToString(),
                        Cpf = Dr["CPF"].ToString(),
                        Nascimento = Dr["NASCIMENTO"].ToString(),
                        Permissao = Dr["PERMISSAO"].ToString()
                    });
                }
                DataGridUsuarios.DataSource = Lista;
            }
            catch (Exception Ex)
            {
               Warning.ShowDialog(Ex.Message);
            }
        }
        #endregion

        #region GRID Administrador
        public void CarregarGrid_Administrador(MetroGrid DataGridUsuarios)
        {
            try
            {
                NpgsqlConnection Conn = new NpgsqlConnection("Host=143.208.8.46; Port=5432; Database=thercio_GESTEC2; Username=thercio; Password=Sl2018");
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM USUARIOS", Conn);
                NpgsqlDataReader Dr = cmd.ExecuteReader();
                List<UsuariosDTO.Usuarios> Lista = new List<UsuariosDTO.Usuarios>();

                while (Dr.Read())
                {
                    Lista.Add(new UsuariosDTO.Usuarios
                    {
                        Id = Convert.ToInt32(Dr["ID_USUARIO"]),
                        Email = Dr["NOME"].ToString(),
                        Senha = Dr["SENHA"].ToString(),
                        Cpf = Dr["CPF"].ToString(),
                        Nascimento = Dr["NASCIMENTO"].ToString(),
                        Permissao = Dr["PERMISSAO"].ToString()
                    });
                }
                DataGridUsuarios.DataSource = Lista;
            }
            catch (Exception Ex)
            {
                Warning.ShowDialog(Ex.Message);
            }
        }
        #endregion

        #region Atualizar
        public void Atualizar(MaterialSingleLineTextField txtSenha)
        {
           
        }
        #endregion

        #region Passar Valores do Grid para os TextBox
            public void GridTotxt_ADM(MetroGrid DataGridUsuarios, 
                                MaterialSingleLineTextField txtNome,
                                MaterialSingleLineTextField txtSenha, 
                                MaskedTextBox txtDataNascimento, 
                                MaskedTextBox txtCPF,
                                MetroComboBox cbbPermissao)
        {  
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(DataGridUsuarios.CurrentRow.Cells[0].Value);
            txtNome.Text = DataGridUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = DataGridUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = DataGridUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtDataNascimento.Text = DataGridUsuarios.CurrentRow.Cells[4].Value.ToString();
            cbbPermissao.Text = DataGridUsuarios.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion

        #region Passar Valores do Grid para os TextBox OPERADOR
        public void GridTotxt_Operador(MetroGrid DataGridUsuarios,
                                MaterialSingleLineTextField txtNome,
                                MaskedTextBox txtDataNascimento,
                                MaskedTextBox txtCPF,
                                MetroComboBox cbbPermissao)
        {
            IDRegistro = 0;
            IDRegistro = Convert.ToInt32(DataGridUsuarios.CurrentRow.Cells[0].Value);
            txtNome.Text = DataGridUsuarios.CurrentRow.Cells[1].Value.ToString();
            //txtSenha.Text = DataGridUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = DataGridUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtDataNascimento.Text = DataGridUsuarios.CurrentRow.Cells[4].Value.ToString();
            cbbPermissao.Text = DataGridUsuarios.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion
    }
}