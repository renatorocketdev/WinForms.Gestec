namespace GESTEC.Forms.Listas
{
    partial class ListaVagas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVagas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.dgVagas = new MetroFramework.Controls.MetroGrid();
            this.Idvaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbCNPJ = new MetroFramework.Controls.MetroComboBox();
            this.cbbNomeEmpresa = new MetroFramework.Controls.MetroComboBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.cbbEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtTitulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbMunicipio = new MetroFramework.Controls.MetroComboBox();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbStatus = new MetroFramework.Controls.MetroComboBox();
            this.rtSobre = new System.Windows.Forms.RichTextBox();
            this.txtCargo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarCargo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarEmpresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.panelControlBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 120);
            this.panel1.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(871, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
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
            this.panelControlBox.Size = new System.Drawing.Size(871, 36);
            this.panelControlBox.TabIndex = 0;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseDown);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseMove);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::GESTEC.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(775, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 36);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 36;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::GESTEC.Properties.Resources.Maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(807, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 35;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(839, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 34;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.AllowUserToResizeRows = false;
            this.dgVagas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVagas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVagas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgVagas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVagas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgVagas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVagas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVagas.ColumnHeadersHeight = 35;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idvaga,
            this.Titulo,
            this.Salario,
            this.Estado,
            this.Municipio,
            this.Bairro,
            this.Descricao,
            this.Status,
            this.Nomempresa,
            this.Cnpj,
            this.Cargo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVagas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVagas.EnableHeadersVisualStyles = false;
            this.dgVagas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgVagas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgVagas.Location = new System.Drawing.Point(12, 358);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVagas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVagas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgVagas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVagas.Size = new System.Drawing.Size(850, 389);
            this.dgVagas.TabIndex = 11;
            this.dgVagas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVagas_CellDoubleClick);
            // 
            // Idvaga
            // 
            this.Idvaga.DataPropertyName = "Idvaga";
            this.Idvaga.HeaderText = "ID Vaga";
            this.Idvaga.Name = "Idvaga";
            this.Idvaga.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Municipio
            // 
            this.Municipio.DataPropertyName = "Municipio";
            this.Municipio.HeaderText = "Município";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Nomempresa
            // 
            this.Nomempresa.DataPropertyName = "Nomempresa";
            this.Nomempresa.HeaderText = "Nome Empresa";
            this.Nomempresa.Name = "Nomempresa";
            this.Nomempresa.ReadOnly = true;
            // 
            // Cnpj
            // 
            this.Cnpj.DataPropertyName = "Cnpj";
            this.Cnpj.HeaderText = "CNPJ";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards1.Controls.Add(this.metroLabel1);
            this.bunifuCards1.Controls.Add(this.metroLabel2);
            this.bunifuCards1.Controls.Add(this.txtID);
            this.bunifuCards1.Controls.Add(this.cbbCNPJ);
            this.bunifuCards1.Controls.Add(this.cbbNomeEmpresa);
            this.bunifuCards1.Controls.Add(this.txtSalario);
            this.bunifuCards1.Controls.Add(this.cbbEstado);
            this.bunifuCards1.Controls.Add(this.txtTitulo);
            this.bunifuCards1.Controls.Add(this.cbbMunicipio);
            this.bunifuCards1.Controls.Add(this.txtBairro);
            this.bunifuCards1.Controls.Add(this.materialLabel1);
            this.bunifuCards1.Controls.Add(this.cbbStatus);
            this.bunifuCards1.Controls.Add(this.rtSobre);
            this.bunifuCards1.Controls.Add(this.txtCargo);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(8, 126);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(851, 184);
            this.bunifuCards1.TabIndex = 56;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(220, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 104;
            this.metroLabel1.Text = "Salário";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(513, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 103;
            this.metroLabel2.Text = "Sobre a Vaga";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "ID";
            this.txtID.Location = new System.Drawing.Point(8, 154);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(47, 23);
            this.txtID.TabIndex = 62;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // cbbCNPJ
            // 
            this.cbbCNPJ.FormattingEnabled = true;
            this.cbbCNPJ.ItemHeight = 23;
            this.cbbCNPJ.Location = new System.Drawing.Point(340, 148);
            this.cbbCNPJ.Name = "cbbCNPJ";
            this.cbbCNPJ.PromptText = "CNPJ";
            this.cbbCNPJ.Size = new System.Drawing.Size(167, 29);
            this.cbbCNPJ.TabIndex = 61;
            this.cbbCNPJ.UseSelectable = true;
            // 
            // cbbNomeEmpresa
            // 
            this.cbbNomeEmpresa.FormattingEnabled = true;
            this.cbbNomeEmpresa.ItemHeight = 23;
            this.cbbNomeEmpresa.Location = new System.Drawing.Point(61, 148);
            this.cbbNomeEmpresa.Name = "cbbNomeEmpresa";
            this.cbbNomeEmpresa.PromptText = "Nome";
            this.cbbNomeEmpresa.Size = new System.Drawing.Size(273, 29);
            this.cbbNomeEmpresa.TabIndex = 60;
            this.cbbNomeEmpresa.UseSelectable = true;
            this.cbbNomeEmpresa.TextChanged += new System.EventHandler(this.cbbNomeEmpresa_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.White;
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSalario.Location = new System.Drawing.Point(275, 63);
            this.txtSalario.Mask = "$ 0000,00";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(105, 15);
            this.txtSalario.TabIndex = 4;
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.ItemHeight = 23;
            this.cbbEstado.Location = new System.Drawing.Point(8, 84);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.PromptText = "Estado (*)";
            this.cbbEstado.Size = new System.Drawing.Size(246, 29);
            this.cbbEstado.TabIndex = 5;
            this.cbbEstado.UseSelectable = true;
            this.cbbEstado.TextChanged += new System.EventHandler(this.cbbEstado_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Hint = "Título da Vaga (*)";
            this.txtTitulo.Location = new System.Drawing.Point(8, 15);
            this.txtTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.Size = new System.Drawing.Size(495, 23);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TabStop = false;
            this.txtTitulo.UseSystemPasswordChar = false;
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.BackColor = System.Drawing.Color.White;
            this.cbbMunicipio.FormattingEnabled = true;
            this.cbbMunicipio.ItemHeight = 23;
            this.cbbMunicipio.Location = new System.Drawing.Point(261, 84);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.PromptText = "Municipio (*)";
            this.cbbMunicipio.Size = new System.Drawing.Size(246, 29);
            this.cbbMunicipio.TabIndex = 6;
            this.cbbMunicipio.UseSelectable = true;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.Location = new System.Drawing.Point(8, 119);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(499, 23);
            this.txtBairro.TabIndex = 7;
            this.txtBairro.TabStop = false;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(509, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 48;
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.White;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.ItemHeight = 23;
            this.cbbStatus.Items.AddRange(new object[] {
            "EM ABERTO",
            "PRORROGAÇÃO",
            "FECHADA"});
            this.cbbStatus.Location = new System.Drawing.Point(386, 49);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.PromptText = "Status (*)";
            this.cbbStatus.Size = new System.Drawing.Size(121, 29);
            this.cbbStatus.TabIndex = 8;
            this.cbbStatus.UseSelectable = true;
            // 
            // rtSobre
            // 
            this.rtSobre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtSobre.Location = new System.Drawing.Point(513, 41);
            this.rtSobre.Name = "rtSobre";
            this.rtSobre.Size = new System.Drawing.Size(335, 136);
            this.rtSobre.TabIndex = 9;
            this.rtSobre.Text = "";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.White;
            this.txtCargo.Depth = 0;
            this.txtCargo.Hint = "Cargo (*)";
            this.txtCargo.Location = new System.Drawing.Point(8, 55);
            this.txtCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.SelectedText = "";
            this.txtCargo.SelectionLength = 0;
            this.txtCargo.SelectionStart = 0;
            this.txtCargo.Size = new System.Drawing.Size(205, 23);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.TabStop = false;
            this.txtCargo.UseSystemPasswordChar = false;
            // 
            // txtBuscarCargo
            // 
            this.txtBuscarCargo.Depth = 0;
            this.txtBuscarCargo.Hint = "Buscar por Cargo";
            this.txtBuscarCargo.Location = new System.Drawing.Point(257, 329);
            this.txtBuscarCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCargo.Name = "txtBuscarCargo";
            this.txtBuscarCargo.PasswordChar = '\0';
            this.txtBuscarCargo.SelectedText = "";
            this.txtBuscarCargo.SelectionLength = 0;
            this.txtBuscarCargo.SelectionStart = 0;
            this.txtBuscarCargo.Size = new System.Drawing.Size(301, 23);
            this.txtBuscarCargo.TabIndex = 58;
            this.txtBuscarCargo.TabStop = false;
            this.txtBuscarCargo.UseSystemPasswordChar = false;
            this.txtBuscarCargo.TextChanged += new System.EventHandler(this.txtBuscarCargo_TextChanged);
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.Depth = 0;
            this.txtBuscarEmpresa.Hint = "Buscar por Nome Empresa";
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(8, 329);
            this.txtBuscarEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.PasswordChar = '\0';
            this.txtBuscarEmpresa.SelectedText = "";
            this.txtBuscarEmpresa.SelectionLength = 0;
            this.txtBuscarEmpresa.SelectionStart = 0;
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(243, 23);
            this.txtBuscarEmpresa.TabIndex = 57;
            this.txtBuscarEmpresa.TabStop = false;
            this.txtBuscarEmpresa.UseSystemPasswordChar = false;
            this.txtBuscarEmpresa.TextChanged += new System.EventHandler(this.txtBuscarEmpresa_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.BorderRadius = 5;
            this.btnLimpar.ButtonText = "Limpar";
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnLimpar.Location = new System.Drawing.Point(766, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpar.TabIndex = 61;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Textcolor = System.Drawing.Color.White;
            this.btnLimpar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.BorderRadius = 5;
            this.btnDeletar.ButtonText = "Deletar";
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnDeletar.Location = new System.Drawing.Point(668, 322);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(92, 30);
            this.btnDeletar.TabIndex = 60;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.ButtonText = "Atualizar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnAtualizar.Location = new System.Drawing.Point(570, 322);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(92, 30);
            this.btnAtualizar.TabIndex = 59;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ListaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 770);
            this.Controls.Add(this.txtBuscarCargo);
            this.Controls.Add(this.txtBuscarEmpresa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dgVagas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vagas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MetroFramework.Controls.MetroGrid dgVagas;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private MetroFramework.Controls.MetroComboBox cbbEstado;
        private MetroFramework.Controls.MetroComboBox cbbMunicipio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox rtSobre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCargo;
        private MetroFramework.Controls.MetroComboBox cbbStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCargo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpresa;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        private MetroFramework.Controls.MetroComboBox cbbNomeEmpresa;
        private MetroFramework.Controls.MetroComboBox cbbCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idvaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}