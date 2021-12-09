using GESTEC.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GESTEC.Forms.Formulários_de_Cadastro
{
    public partial class Alunos : Form
    {
        public static bool ValorRDB;

        public Alunos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            AlunosBLL bll = new AlunosBLL();
            bll.PreencherGrid(DataGridAluno);
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

        #region Botões Principais
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == string.Empty || txtCursando.Text == string.Empty || txtModulo.Text == string.Empty || txtStatus.Text == string.Empty)
            {
                Warning.ShowDialog("Preencha os campos Corretamente");
            }
            else
            {
                if (rdbSim.Checked == true)
                {
                    ValorRDB = true;
                }
                else if (rdbNao.Checked == true)
                {
                    ValorRDB = false;
                }

                if(txtDataMatricula.MaskCompleted == false)
                {
                    txtDataMatricula.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                AlunosBLL bll = new AlunosBLL();
                bll.Inserir(txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbSim, rdbNao);
            }
            CarregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rdbSim.Checked == true)
            {
                ValorRDB = true;
            }
            else if (rdbNao.Checked == true)
            {
                ValorRDB = false;
            }
            AlunosBLL bll = new AlunosBLL();
            bll.Atualizar(txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbNao, rdbNao);
            
            CarregarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            AlunosBLL bll = new AlunosBLL();
            bll.Deletar(DataGridAluno);
            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AlunosBLL bll = new AlunosBLL();
            bll.Limpar(txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbSim, rdbNao);
            CarregarGrid();
        }

        #endregion

        #region Eventos
        private void DataGridAluno_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Contato1;

            Contato1 = DataGridAluno.CurrentRow.Cells[8].Value.ToString();
            Contato1.Replace("(", "").Replace(")", "").Replace("-", "").Trim(); 

            AlunosBLL bll = new AlunosBLL();
            bll.GridToText(DataGridAluno, txtID, txtNomeAluno, txtCursando, txtModulo, txtStatus, txtDataMatricula, txtEmail, txtContato, rdbSim, rdbNao);
        }

        private void txtBuscarAluno_TextChanged(object sender, EventArgs e)
        {
            AlunosBLL bll = new AlunosBLL();
            bll.PesquisarAluno(txtBuscarAluno);

            DataGridAluno.DataSource = bll.PesquisarAluno(txtBuscarAluno);
        }

        private void txtBuscarCurso_TextChanged(object sender, EventArgs e)
        {
            AlunosBLL bll = new AlunosBLL();
            bll.PesquisarCurso(txtBuscarCurso);

            DataGridAluno.DataSource = bll.PesquisarAluno(txtBuscarCurso);
        }
        #endregion
    }
}