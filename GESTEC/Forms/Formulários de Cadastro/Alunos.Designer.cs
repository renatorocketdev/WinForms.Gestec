namespace GESTEC.Forms.Formulários_de_Cadastro
{
    partial class Alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alunos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.metroTabControl3 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDataMatricula = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtContato = new System.Windows.Forms.MaskedTextBox();
            this.txtCursando = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStatus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNao = new MetroFramework.Controls.MetroRadioButton();
            this.rdbSim = new MetroFramework.Controls.MetroRadioButton();
            this.txtModulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomeAluno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnInserir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscarAluno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridAluno = new MetroFramework.Controls.MetroGrid();
            this.txtBuscarCurso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuloAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concluiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.metroTabControl3.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.panelControlBox.Controls.Add(this.btnMinimizar);
            this.panelControlBox.Controls.Add(this.btnMaximizar);
            this.panelControlBox.Controls.Add(this.btnFechar);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(794, 36);
            this.panelControlBox.TabIndex = 24;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown_1);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove_1);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::GESTEC.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(698, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 36);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 30;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::GESTEC.Properties.Resources.Maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(730, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 29;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(762, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 28;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // metroTabControl3
            // 
            this.metroTabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl3.Controls.Add(this.metroTabPage7);
            this.metroTabControl3.Location = new System.Drawing.Point(139, 126);
            this.metroTabControl3.Name = "metroTabControl3";
            this.metroTabControl3.SelectedIndex = 0;
            this.metroTabControl3.Size = new System.Drawing.Size(643, 164);
            this.metroTabControl3.TabIndex = 44;
            this.metroTabControl3.UseSelectable = true;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.BackColor = System.Drawing.Color.White;
            this.metroTabPage7.Controls.Add(this.txtID);
            this.metroTabPage7.Controls.Add(this.metroLabel2);
            this.metroTabPage7.Controls.Add(this.txtDataMatricula);
            this.metroTabPage7.Controls.Add(this.txtEmail);
            this.metroTabPage7.Controls.Add(this.metroLabel1);
            this.metroTabPage7.Controls.Add(this.txtContato);
            this.metroTabPage7.Controls.Add(this.txtCursando);
            this.metroTabPage7.Controls.Add(this.txtStatus);
            this.metroTabPage7.Controls.Add(this.groupBox1);
            this.metroTabPage7.Controls.Add(this.txtModulo);
            this.metroTabPage7.Controls.Add(this.txtNomeAluno);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(635, 122);
            this.metroTabPage7.TabIndex = 0;
            this.metroTabPage7.Text = "Cadastro de Alunos";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Depth = 0;
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Hint = "ID";
            this.txtID.Location = new System.Drawing.Point(3, 9);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(77, 23);
            this.txtID.TabIndex = 118;
            this.txtID.TabStop = false;
            this.txtID.Text = "0";
            this.txtID.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(438, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 117;
            this.metroLabel2.Text = "Data de Matrícula";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtDataMatricula
            // 
            this.txtDataMatricula.BackColor = System.Drawing.Color.White;
            this.txtDataMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMatricula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDataMatricula.Location = new System.Drawing.Point(562, 46);
            this.txtDataMatricula.Mask = "00/00/0000";
            this.txtDataMatricula.Name = "txtDataMatricula";
            this.txtDataMatricula.Size = new System.Drawing.Size(70, 15);
            this.txtDataMatricula.TabIndex = 116;
            this.txtDataMatricula.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "E-Mail";
            this.txtEmail.Location = new System.Drawing.Point(3, 86);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(228, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(237, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 115;
            this.metroLabel1.Text = "Contato (*)";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.Color.White;
            this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtContato.Location = new System.Drawing.Point(323, 94);
            this.txtContato.Mask = "(99) 00000-0000";
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(102, 15);
            this.txtContato.TabIndex = 6;
            // 
            // txtCursando
            // 
            this.txtCursando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCursando.BackColor = System.Drawing.Color.White;
            this.txtCursando.Depth = 0;
            this.txtCursando.Hint = "Cursando *";
            this.txtCursando.Location = new System.Drawing.Point(438, 9);
            this.txtCursando.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCursando.Name = "txtCursando";
            this.txtCursando.PasswordChar = '\0';
            this.txtCursando.SelectedText = "";
            this.txtCursando.SelectionLength = 0;
            this.txtCursando.SelectionStart = 0;
            this.txtCursando.Size = new System.Drawing.Size(194, 23);
            this.txtCursando.TabIndex = 2;
            this.txtCursando.TabStop = false;
            this.txtCursando.UseSystemPasswordChar = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.Depth = 0;
            this.txtStatus.Hint = "Status do Curso *";
            this.txtStatus.Location = new System.Drawing.Point(182, 38);
            this.txtStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.Size = new System.Drawing.Size(163, 23);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TabStop = false;
            this.txtStatus.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbNao);
            this.groupBox1.Controls.Add(this.rdbSim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(438, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 48);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possui Certificado";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.BackColor = System.Drawing.Color.White;
            this.rdbNao.Checked = true;
            this.rdbNao.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbNao.ForeColor = System.Drawing.Color.DimGray;
            this.rdbNao.Location = new System.Drawing.Point(124, 19);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(50, 19);
            this.rdbNao.TabIndex = 8;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseCustomForeColor = true;
            this.rdbNao.UseSelectable = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.BackColor = System.Drawing.Color.White;
            this.rdbSim.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbSim.ForeColor = System.Drawing.Color.DimGray;
            this.rdbSim.Location = new System.Drawing.Point(6, 19);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(47, 19);
            this.rdbSim.TabIndex = 7;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseCustomForeColor = true;
            this.rdbSim.UseSelectable = true;
            // 
            // txtModulo
            // 
            this.txtModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModulo.BackColor = System.Drawing.Color.White;
            this.txtModulo.Depth = 0;
            this.txtModulo.Hint = "Módulo Atual *";
            this.txtModulo.Location = new System.Drawing.Point(3, 38);
            this.txtModulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.PasswordChar = '\0';
            this.txtModulo.SelectedText = "";
            this.txtModulo.SelectionLength = 0;
            this.txtModulo.SelectionStart = 0;
            this.txtModulo.Size = new System.Drawing.Size(173, 23);
            this.txtModulo.TabIndex = 3;
            this.txtModulo.TabStop = false;
            this.txtModulo.UseSystemPasswordChar = false;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAluno.BackColor = System.Drawing.Color.White;
            this.txtNomeAluno.Depth = 0;
            this.txtNomeAluno.Hint = "Nome do Aluno *";
            this.txtNomeAluno.Location = new System.Drawing.Point(86, 9);
            this.txtNomeAluno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.PasswordChar = '\0';
            this.txtNomeAluno.SelectedText = "";
            this.txtNomeAluno.SelectionLength = 0;
            this.txtNomeAluno.SelectionStart = 0;
            this.txtNomeAluno.Size = new System.Drawing.Size(346, 23);
            this.txtNomeAluno.TabIndex = 1;
            this.txtNomeAluno.TabStop = false;
            this.txtNomeAluno.UseSystemPasswordChar = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserir.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.BorderRadius = 5;
            this.btnInserir.ButtonText = "Inserir";
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.DisabledColor = System.Drawing.Color.Gray;
            this.btnInserir.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnInserir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInserir.Iconimage = null;
            this.btnInserir.Iconimage_right = null;
            this.btnInserir.Iconimage_right_Selected = null;
            this.btnInserir.Iconimage_Selected = null;
            this.btnInserir.IconMarginLeft = 0;
            this.btnInserir.IconMarginRight = 0;
            this.btnInserir.IconRightVisible = true;
            this.btnInserir.IconRightZoom = 0D;
            this.btnInserir.IconVisible = true;
            this.btnInserir.IconZoom = 90D;
            this.btnInserir.IsTab = false;
            this.btnInserir.Location = new System.Drawing.Point(396, 296);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnInserir.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.selected = false;
            this.btnInserir.Size = new System.Drawing.Size(92, 30);
            this.btnInserir.TabIndex = 55;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.Textcolor = System.Drawing.Color.White;
            this.btnInserir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarAluno.Depth = 0;
            this.txtBuscarAluno.Hint = "Buscar por Aluno";
            this.txtBuscarAluno.Location = new System.Drawing.Point(12, 303);
            this.txtBuscarAluno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.PasswordChar = '\0';
            this.txtBuscarAluno.SelectedText = "";
            this.txtBuscarAluno.SelectionLength = 0;
            this.txtBuscarAluno.SelectionStart = 0;
            this.txtBuscarAluno.Size = new System.Drawing.Size(223, 23);
            this.txtBuscarAluno.TabIndex = 51;
            this.txtBuscarAluno.TabStop = false;
            this.txtBuscarAluno.UseSystemPasswordChar = false;
            this.txtBuscarAluno.TextChanged += new System.EventHandler(this.txtBuscarAluno_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.BorderRadius = 5;
            this.btnLimpar.ButtonText = "Limpar";
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnLimpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpar.Iconimage = null;
            this.btnLimpar.Iconimage_right = null;
            this.btnLimpar.Iconimage_right_Selected = null;
            this.btnLimpar.Iconimage_Selected = null;
            this.btnLimpar.IconMarginLeft = 0;
            this.btnLimpar.IconMarginRight = 0;
            this.btnLimpar.IconRightVisible = true;
            this.btnLimpar.IconRightZoom = 0D;
            this.btnLimpar.IconVisible = true;
            this.btnLimpar.IconZoom = 90D;
            this.btnLimpar.IsTab = false;
            this.btnLimpar.Location = new System.Drawing.Point(690, 296);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Textcolor = System.Drawing.Color.White;
            this.btnLimpar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.BorderRadius = 5;
            this.btnDeletar.ButtonText = "Deletar";
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnDeletar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletar.Iconimage = null;
            this.btnDeletar.Iconimage_right = null;
            this.btnDeletar.Iconimage_right_Selected = null;
            this.btnDeletar.Iconimage_Selected = null;
            this.btnDeletar.IconMarginLeft = 0;
            this.btnDeletar.IconMarginRight = 0;
            this.btnDeletar.IconRightVisible = true;
            this.btnDeletar.IconRightZoom = 0D;
            this.btnDeletar.IconVisible = true;
            this.btnDeletar.IconZoom = 90D;
            this.btnDeletar.IsTab = false;
            this.btnDeletar.Location = new System.Drawing.Point(592, 296);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(92, 30);
            this.btnDeletar.TabIndex = 52;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.ButtonText = "Atualizar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtualizar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnAtualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Iconimage = null;
            this.btnAtualizar.Iconimage_right = null;
            this.btnAtualizar.Iconimage_right_Selected = null;
            this.btnAtualizar.Iconimage_Selected = null;
            this.btnAtualizar.IconMarginLeft = 0;
            this.btnAtualizar.IconMarginRight = 0;
            this.btnAtualizar.IconRightVisible = true;
            this.btnAtualizar.IconRightZoom = 0D;
            this.btnAtualizar.IconVisible = true;
            this.btnAtualizar.IconZoom = 90D;
            this.btnAtualizar.IsTab = false;
            this.btnAtualizar.Location = new System.Drawing.Point(494, 296);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(92, 30);
            this.btnAtualizar.TabIndex = 50;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // DataGridAluno
            // 
            this.DataGridAluno.AllowUserToAddRows = false;
            this.DataGridAluno.AllowUserToDeleteRows = false;
            this.DataGridAluno.AllowUserToResizeRows = false;
            this.DataGridAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridAluno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridAluno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridAluno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAluno.ColumnHeadersHeight = 35;
            this.DataGridAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Curso,
            this.ModuloAtual,
            this.Status,
            this.DataMatricula,
            this.Email,
            this.Contato,
            this.Concluiu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAluno.EnableHeadersVisualStyles = false;
            this.DataGridAluno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridAluno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridAluno.Location = new System.Drawing.Point(12, 332);
            this.DataGridAluno.Name = "DataGridAluno";
            this.DataGridAluno.ReadOnly = true;
            this.DataGridAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAluno.Size = new System.Drawing.Size(770, 266);
            this.DataGridAluno.TabIndex = 54;
            this.DataGridAluno.TabStop = false;
            this.DataGridAluno.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAluno_CellContentDoubleClick);
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCurso.Depth = 0;
            this.txtBuscarCurso.Hint = "Buscar por Curso";
            this.txtBuscarCurso.Location = new System.Drawing.Point(241, 303);
            this.txtBuscarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.PasswordChar = '\0';
            this.txtBuscarCurso.SelectedText = "";
            this.txtBuscarCurso.SelectionLength = 0;
            this.txtBuscarCurso.SelectionStart = 0;
            this.txtBuscarCurso.Size = new System.Drawing.Size(149, 23);
            this.txtBuscarCurso.TabIndex = 56;
            this.txtBuscarCurso.TabStop = false;
            this.txtBuscarCurso.UseSystemPasswordChar = false;
            this.txtBuscarCurso.TextChanged += new System.EventHandler(this.txtBuscarCurso_TextChanged);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox11.Image = global::GESTEC.Properties.Resources.Alunos;
            this.pictureBox11.Location = new System.Drawing.Point(5, 126);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(128, 128);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 43;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(794, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 25;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_aluno";
            this.ID.FillWeight = 91.04633F;
            this.ID.HeaderText = "Número de Matrícula";
            this.ID.MinimumWidth = 100;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 126;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nome.DataPropertyName = "nome_aluno";
            this.Nome.FillWeight = 365.482F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 150;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "curso_aluno";
            this.Curso.DividerWidth = 1;
            this.Curso.FillWeight = 63.35306F;
            this.Curso.HeaderText = "Cursando";
            this.Curso.MinimumWidth = 90;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 90;
            // 
            // ModuloAtual
            // 
            this.ModuloAtual.DataPropertyName = "modulo_atual";
            this.ModuloAtual.FillWeight = 63.35306F;
            this.ModuloAtual.HeaderText = "Módulo Atual";
            this.ModuloAtual.Name = "ModuloAtual";
            this.ModuloAtual.ReadOnly = true;
            this.ModuloAtual.Width = 93;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status_curso";
            this.Status.FillWeight = 63.35306F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // DataMatricula
            // 
            this.DataMatricula.DataPropertyName = "data_matricula";
            this.DataMatricula.FillWeight = 63.35306F;
            this.DataMatricula.HeaderText = "Data de Matrícula";
            this.DataMatricula.Name = "DataMatricula";
            this.DataMatricula.ReadOnly = true;
            this.DataMatricula.Width = 111;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email_aluno";
            this.Email.FillWeight = 63.35306F;
            this.Email.HeaderText = "E-Mail";
            this.Email.MinimumWidth = 150;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 150;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "contato_aluno";
            this.Contato.FillWeight = 63.35306F;
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 72;
            // 
            // Concluiu
            // 
            this.Concluiu.DataPropertyName = "concluiu_curso";
            this.Concluiu.FillWeight = 63.35306F;
            this.Concluiu.HeaderText = "Possui Certificado";
            this.Concluiu.Name = "Concluiu";
            this.Concluiu.ReadOnly = true;
            this.Concluiu.Width = 112;
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 610);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.DataGridAluno);
            this.Controls.Add(this.metroTabControl3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alunos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.TopMost = true;
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.metroTabControl3.ResumeLayout(false);
            this.metroTabPage7.ResumeLayout(false);
            this.metroTabPage7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox pictureBox11;
        private MetroFramework.Controls.MetroTabControl metroTabControl3;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCursando;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeAluno;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox txtContato;
        private MetroFramework.Controls.MetroRadioButton rdbNao;
        private MetroFramework.Controls.MetroRadioButton rdbSim;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnInserir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarAluno;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        private MetroFramework.Controls.MetroGrid DataGridAluno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCurso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox txtDataMatricula;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuloAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concluiu;
    }
}