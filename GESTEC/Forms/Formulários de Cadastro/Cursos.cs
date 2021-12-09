using GESTEC.BLL;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms.Formulários_de_Cadastro
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            CursosBLL bll = new CursosBLL();
            bll.PreencherGrid(DataGridCurso);
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
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ControleBunifu Controle = new ControleBunifu();
            Controle.Show();
            this.Hide();
        }

        private void DataGridCurso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CursosBLL bll = new CursosBLL();
            bll.GridToText(DataGridCurso, txtNomeCurso, txtCategoria, txtDuracaoCurso, rtDescricaoCurso, txtValorCurso);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            CursosBLL bll = new CursosBLL();
            bll.PesquisarCurso(txtBuscarCurso);

            DataGridCurso.DataSource = bll.PesquisarCurso(txtBuscarCurso);
        }

        #endregion

        #region Botões Principais
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeCurso.Text == string.Empty || txtCategoria.Text == string.Empty || txtDuracaoCurso.Text == string.Empty || !txtValorCurso.MaskCompleted)
            {
                Warning.ShowDialog("Preencha os campos Corretamente");
            }
            else
            {
                CursosBLL bll = new CursosBLL();
                bll.Salvar(txtNomeCurso, txtValorCurso, txtDuracaoCurso, rtDescricaoCurso, txtCategoria);            
            }
            CarregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeCurso.Text == string.Empty || txtCategoria.Text == string.Empty || txtDuracaoCurso.Text == string.Empty || txtValorCurso.Text == string.Empty)
            {
                Warning.ShowDialog("Preencha os campos Corretamente");
            }
            else
            {
                CursosBLL bll = new CursosBLL();
                bll.Atualizar(txtNomeCurso, txtValorCurso, txtDuracaoCurso, rtDescricaoCurso, txtCategoria);
            }
            CarregarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            CursosBLL bll = new CursosBLL();
            bll.Deletar(DataGridCurso);

            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            CursosBLL bll = new CursosBLL();
            bll.Limpar(txtNomeCurso, txtValorCurso, txtDuracaoCurso, rtDescricaoCurso, txtCategoria);

            CarregarGrid();
        }

        #endregion        
    }
}