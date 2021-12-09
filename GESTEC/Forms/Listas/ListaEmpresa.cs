using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms.Listas
{
    public partial class ListaEmpresa : MaterialForm
    {
        public ListaEmpresa()
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

            CarregarGrid();

            txtCNPJ.Text = "";
            txtCNPJ.Mask = "00,000,000/0000-00";
        }

        #region Panel Superior 
        int TogMove;
        int mValY;
        int mValX;

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            mValY = e.Y;
            mValX = e.X;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
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

        #region Botões Principais
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            EmpresaBLL bll = new EmpresaBLL();
            bll.DeletarEmpresa(DataGridEmpresa);

            bll.LimparCampos(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
            cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2,
            txtObservacao1, txtObservacao2, txtEmail, materialCheckBox1);

            bll.EncherGrid(DataGridEmpresa);
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtInscEstadual.Text == "" || txtInscMunicipal.Text == "" ||
                txtNomeFantasia.Text == "" || cbbEstado.Text == "" || cbbMunicipio.Text == "" ||
                txtContato1.Text == "")
            {
                Warning.ShowDialog("Preencha os Campos Obrigatórios!! (*)");
            }
            else
            {
                EmpresaBLL bll = new EmpresaBLL();
                bll.AtualizarEmpresa(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                    cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2, txtObservacao1,
                    txtObservacao2, txtEmail);
                bll.EncherGrid(DataGridEmpresa);

                bll.LimparCampos(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2,
                txtObservacao1, txtObservacao2, txtEmail, materialCheckBox1);
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            EmpresaBLL bll = new EmpresaBLL();
            bll.LimparCampos(txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2,
                txtObservacao1, txtObservacao2, txtEmail, materialCheckBox1);
        }
        #endregion

        #region GRID
        public void CarregarGrid()
        {
            EmpresaBLL bll = new EmpresaBLL();
            bll.EncherGrid(DataGridEmpresa);
        }

        private void GridEmpresa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Contato1;

            Contato1 = DataGridEmpresa.CurrentRow.Cells[11].Value.ToString();
            Contato1.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

            if (Contato1.Length == 14)
            {
                materialCheckBox1.Checked = true;
            }
            else if (Contato1.Length == 15)
            {
                materialCheckBox1.Checked = false;
            }

            EmpresaBLL bll = new EmpresaBLL();
            bll.GridToTxt(DataGridEmpresa, txtCNPJ, txtInscEstadual, txtInscMunicipal, txtRazaoSocial, txtNomeFantasia,
                cbbEstado, cbbMunicipio, txtBairro, txtRua, txtNumero, txtContato1, txtContato2, txtObservacao1,
                txtObservacao2, txtEmail);
        }
        #endregion

        #region Ao Carregar
        private void ListaEmpresa_Load(object sender, EventArgs e)
        {
            BLL.ComboBox bll = new BLL.ComboBox();
            bll.Estados(cbbEstado);
        }
        #endregion

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.ComboBox bll = new BLL.ComboBox();
            bll.VerificaEstado(cbbEstado, cbbMunicipio);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
        }

        #region  Pesquisa

        #region CNPJ
        private void txtBuscarCNPJ_TextChanged(object sender, EventArgs e)
        {
            EmpresaBLL BLL = new EmpresaBLL();
            BLL.PesquisarCNPJEmpresa(txtBuscarCNPJ);

            DataGridEmpresa.DataSource = BLL.PesquisarCNPJEmpresa(txtBuscarCNPJ);
        }
        #endregion

        #region Nome
        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            EmpresaBLL BLL = new EmpresaBLL();
            BLL.PesquisarNomeEmpresa(txtBuscarNome);

            DataGridEmpresa.DataSource = BLL.PesquisarNomeEmpresa(txtBuscarNome);
        }
        #endregion

        #endregion

        #region Valida CNPJ
        string mensagem = "";

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string valor = txtCNPJ.Text;
            if (ValidaBLL.IsCnpj(valor))
            {
                mensagem = "O número é um CNPJ Válido !";
            }
            else
            {
                mensagem = "O número é um CNPJ Inválido !";
            }

            MessageBox.Show(mensagem, "Setegre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

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