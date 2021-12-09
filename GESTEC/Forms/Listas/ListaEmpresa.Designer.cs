namespace GESTEC.Forms.Listas
{
    partial class ListaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEmpresa));
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
            this.DataGridEmpresa = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomefantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSC_EST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscricaomunicipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Município = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtContato1 = new System.Windows.Forms.MaskedTextBox();
            this.txtContato2 = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtObservacao2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtInscEstadual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObservacao1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbMunicipio = new MetroFramework.Controls.MetroComboBox();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtRua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtInscMunicipal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRazaoSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomeFantasia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscarNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarCNPJ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpresa)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(870, 120);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(870, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 21;
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
            this.panelControlBox.Size = new System.Drawing.Size(870, 36);
            this.panelControlBox.TabIndex = 0;
            this.panelControlBox.DoubleClick += new System.EventHandler(this.BtnMaximizar_Click);
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::GESTEC.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(774, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 36);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 27;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::GESTEC.Properties.Resources.Maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(806, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 26;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(838, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 25;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // DataGridEmpresa
            // 
            this.DataGridEmpresa.AllowUserToAddRows = false;
            this.DataGridEmpresa.AllowUserToDeleteRows = false;
            this.DataGridEmpresa.AllowUserToResizeRows = false;
            this.DataGridEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEmpresa.ColumnHeadersHeight = 35;
            this.DataGridEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Nomefantasia,
            this.Cnpj,
            this.INSC_EST,
            this.Inscricaomunicipal,
            this.Estado,
            this.Município,
            this.Bairro,
            this.Rua,
            this.Numero,
            this.Contato1,
            this.Contato2,
            this.Observacao1,
            this.Observacao2,
            this.Email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEmpresa.EnableHeadersVisualStyles = false;
            this.DataGridEmpresa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridEmpresa.Location = new System.Drawing.Point(11, 386);
            this.DataGridEmpresa.Name = "DataGridEmpresa";
            this.DataGridEmpresa.ReadOnly = true;
            this.DataGridEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEmpresa.Size = new System.Drawing.Size(847, 372);
            this.DataGridEmpresa.TabIndex = 23;
            this.DataGridEmpresa.TabStop = false;
            this.DataGridEmpresa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmpresa_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "razaosocial";
            this.Column1.HeaderText = "Razão Social";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Nomefantasia
            // 
            this.Nomefantasia.DataPropertyName = "nomefantasia";
            this.Nomefantasia.HeaderText = "Nome Fantasia";
            this.Nomefantasia.Name = "Nomefantasia";
            this.Nomefantasia.ReadOnly = true;
            // 
            // Cnpj
            // 
            this.Cnpj.DataPropertyName = "cnpj";
            this.Cnpj.HeaderText = "CNPJ";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // INSC_EST
            // 
            this.INSC_EST.DataPropertyName = "insc_est";
            this.INSC_EST.HeaderText = "Inscrição Estadual";
            this.INSC_EST.Name = "INSC_EST";
            this.INSC_EST.ReadOnly = true;
            // 
            // Inscricaomunicipal
            // 
            this.Inscricaomunicipal.DataPropertyName = "Inscricaomunicipal";
            this.Inscricaomunicipal.HeaderText = "Inscrição Municipal";
            this.Inscricaomunicipal.Name = "Inscricaomunicipal";
            this.Inscricaomunicipal.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Município
            // 
            this.Município.DataPropertyName = "Municipio";
            this.Município.HeaderText = "Municipio";
            this.Município.Name = "Município";
            this.Município.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "Rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Contato1
            // 
            this.Contato1.DataPropertyName = "Contato1";
            this.Contato1.HeaderText = "Contato 1";
            this.Contato1.Name = "Contato1";
            this.Contato1.ReadOnly = true;
            // 
            // Contato2
            // 
            this.Contato2.DataPropertyName = "Contato2";
            this.Contato2.HeaderText = "Contato 2";
            this.Contato2.Name = "Contato2";
            this.Contato2.ReadOnly = true;
            // 
            // Observacao1
            // 
            this.Observacao1.DataPropertyName = "Observacao1";
            this.Observacao1.HeaderText = "Observação 1";
            this.Observacao1.Name = "Observacao1";
            this.Observacao1.ReadOnly = true;
            // 
            // Observacao2
            // 
            this.Observacao2.DataPropertyName = "Observacao2";
            this.Observacao2.HeaderText = "Observação 2";
            this.Observacao2.Name = "Observacao2";
            this.Observacao2.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Controls.Add(this.metroLabel2);
            this.bunifuCards1.Controls.Add(this.btnPesquisar);
            this.bunifuCards1.Controls.Add(this.txtObservacao2);
            this.bunifuCards1.Controls.Add(this.txtInscEstadual);
            this.bunifuCards1.Controls.Add(this.txtObservacao1);
            this.bunifuCards1.Controls.Add(this.txtEmail);
            this.bunifuCards1.Controls.Add(this.txtBairro);
            this.bunifuCards1.Controls.Add(this.cbbMunicipio);
            this.bunifuCards1.Controls.Add(this.txtNumero);
            this.bunifuCards1.Controls.Add(this.cbbEstado);
            this.bunifuCards1.Controls.Add(this.txtRua);
            this.bunifuCards1.Controls.Add(this.txtInscMunicipal);
            this.bunifuCards1.Controls.Add(this.txtRazaoSocial);
            this.bunifuCards1.Controls.Add(this.txtNomeFantasia);
            this.bunifuCards1.Controls.Add(this.txtCNPJ);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(11, 126);
            this.bunifuCards1.MaximumSize = new System.Drawing.Size(1920, 1000);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(847, 212);
            this.bunifuCards1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtContato1);
            this.groupBox1.Controls.Add(this.txtContato2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.materialCheckBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 86);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(6, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 108;
            this.metroLabel1.Text = "Contato 1 (*)";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtContato1
            // 
            this.txtContato1.BackColor = System.Drawing.Color.White;
            this.txtContato1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtContato1.Location = new System.Drawing.Point(99, 42);
            this.txtContato1.Mask = "(99) 00000-0000";
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.Size = new System.Drawing.Size(102, 15);
            this.txtContato1.TabIndex = 19;
            // 
            // txtContato2
            // 
            this.txtContato2.BackColor = System.Drawing.Color.White;
            this.txtContato2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtContato2.Location = new System.Drawing.Point(83, 68);
            this.txtContato2.Mask = "(99) 00000-0000";
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.Size = new System.Drawing.Size(102, 15);
            this.txtContato2.TabIndex = 20;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel3.Location = new System.Drawing.Point(6, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 109;
            this.metroLabel3.Text = "Contato 2";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(6, 9);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox1.TabIndex = 121;
            this.materialCheckBox1.Text = "Telefone Fixo?";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(8, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(132, 19);
            this.metroLabel2.TabIndex = 101;
            this.metroLabel2.Text = "Número do CNPJ (*)";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::GESTEC.Properties.Resources.Search2;
            this.btnPesquisar.Location = new System.Drawing.Point(278, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtObservacao2
            // 
            this.txtObservacao2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao2.Depth = 0;
            this.txtObservacao2.Hint = "Observação #2";
            this.txtObservacao2.Location = new System.Drawing.Point(231, 182);
            this.txtObservacao2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservacao2.Name = "txtObservacao2";
            this.txtObservacao2.PasswordChar = '\0';
            this.txtObservacao2.SelectedText = "";
            this.txtObservacao2.SelectionLength = 0;
            this.txtObservacao2.SelectionStart = 0;
            this.txtObservacao2.Size = new System.Drawing.Size(275, 23);
            this.txtObservacao2.TabIndex = 14;
            this.txtObservacao2.TabStop = false;
            this.txtObservacao2.UseSystemPasswordChar = false;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscEstadual.Depth = 0;
            this.txtInscEstadual.Hint = "Inscrição Estadual (*)";
            this.txtInscEstadual.Location = new System.Drawing.Point(259, 30);
            this.txtInscEstadual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.PasswordChar = '\0';
            this.txtInscEstadual.SelectedText = "";
            this.txtInscEstadual.SelectionLength = 0;
            this.txtInscEstadual.SelectionStart = 0;
            this.txtInscEstadual.Size = new System.Drawing.Size(271, 23);
            this.txtInscEstadual.TabIndex = 2;
            this.txtInscEstadual.TabStop = false;
            this.txtInscEstadual.UseSystemPasswordChar = false;
            // 
            // txtObservacao1
            // 
            this.txtObservacao1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao1.Depth = 0;
            this.txtObservacao1.Hint = "Observação #1";
            this.txtObservacao1.Location = new System.Drawing.Point(231, 155);
            this.txtObservacao1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservacao1.Name = "txtObservacao1";
            this.txtObservacao1.PasswordChar = '\0';
            this.txtObservacao1.SelectedText = "";
            this.txtObservacao1.SelectionLength = 0;
            this.txtObservacao1.SelectionStart = 0;
            this.txtObservacao1.Size = new System.Drawing.Size(275, 23);
            this.txtObservacao1.TabIndex = 12;
            this.txtObservacao1.TabStop = false;
            this.txtObservacao1.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(328, 90);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(513, 23);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.Location = new System.Drawing.Point(536, 30);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(305, 23);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.TabStop = false;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbMunicipio.BackColor = System.Drawing.Color.White;
            this.cbbMunicipio.FormattingEnabled = true;
            this.cbbMunicipio.ItemHeight = 23;
            this.cbbMunicipio.Location = new System.Drawing.Point(595, 174);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.PromptText = "Municipio (*)";
            this.cbbMunicipio.Size = new System.Drawing.Size(246, 29);
            this.cbbMunicipio.TabIndex = 18;
            this.cbbMunicipio.UseSelectable = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "Número";
            this.txtNumero.Location = new System.Drawing.Point(758, 59);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(83, 23);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TabStop = false;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // cbbEstado
            // 
            this.cbbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.ItemHeight = 23;
            this.cbbEstado.Location = new System.Drawing.Point(595, 139);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.PromptText = "Estado (*)";
            this.cbbEstado.Size = new System.Drawing.Size(246, 29);
            this.cbbEstado.TabIndex = 17;
            this.cbbEstado.UseSelectable = true;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.Depth = 0;
            this.txtRua.Hint = "Rua";
            this.txtRua.Location = new System.Drawing.Point(536, 59);
            this.txtRua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRua.Name = "txtRua";
            this.txtRua.PasswordChar = '\0';
            this.txtRua.SelectedText = "";
            this.txtRua.SelectionLength = 0;
            this.txtRua.SelectionStart = 0;
            this.txtRua.Size = new System.Drawing.Size(213, 23);
            this.txtRua.TabIndex = 6;
            this.txtRua.TabStop = false;
            this.txtRua.UseSystemPasswordChar = false;
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInscMunicipal.Depth = 0;
            this.txtInscMunicipal.Hint = "Inscrição Municipal (*)";
            this.txtInscMunicipal.Location = new System.Drawing.Point(259, 59);
            this.txtInscMunicipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.PasswordChar = '\0';
            this.txtInscMunicipal.SelectedText = "";
            this.txtInscMunicipal.SelectionLength = 0;
            this.txtInscMunicipal.SelectionStart = 0;
            this.txtInscMunicipal.Size = new System.Drawing.Size(271, 23);
            this.txtInscMunicipal.TabIndex = 5;
            this.txtInscMunicipal.TabStop = false;
            this.txtInscMunicipal.UseSystemPasswordChar = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Depth = 0;
            this.txtRazaoSocial.Hint = "Razão Social";
            this.txtRazaoSocial.Location = new System.Drawing.Point(8, 30);
            this.txtRazaoSocial.MaximumSize = new System.Drawing.Size(400, 23);
            this.txtRazaoSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.PasswordChar = '\0';
            this.txtRazaoSocial.SelectedText = "";
            this.txtRazaoSocial.SelectionLength = 0;
            this.txtRazaoSocial.SelectionStart = 0;
            this.txtRazaoSocial.Size = new System.Drawing.Size(235, 23);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.TabStop = false;
            this.txtRazaoSocial.UseSystemPasswordChar = false;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Depth = 0;
            this.txtNomeFantasia.Hint = "Nome Fantasia";
            this.txtNomeFantasia.Location = new System.Drawing.Point(8, 59);
            this.txtNomeFantasia.MaximumSize = new System.Drawing.Size(400, 23);
            this.txtNomeFantasia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.PasswordChar = '\0';
            this.txtNomeFantasia.SelectedText = "";
            this.txtNomeFantasia.SelectionLength = 0;
            this.txtNomeFantasia.SelectionStart = 0;
            this.txtNomeFantasia.Size = new System.Drawing.Size(235, 23);
            this.txtNomeFantasia.TabIndex = 4;
            this.txtNomeFantasia.TabStop = false;
            this.txtNomeFantasia.UseSystemPasswordChar = false;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.White;
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCNPJ.Location = new System.Drawing.Point(146, 98);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(126, 15);
            this.txtCNPJ.TabIndex = 8;
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
            this.btnLimpar.Location = new System.Drawing.Point(766, 347);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Textcolor = System.Drawing.Color.White;
            this.btnLimpar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(668, 347);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(92, 30);
            this.btnDeletar.TabIndex = 21;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
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
            this.btnAtualizar.Location = new System.Drawing.Point(570, 347);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(92, 30);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNome.Depth = 0;
            this.txtBuscarNome.Hint = "Buscar por Nome";
            this.txtBuscarNome.Location = new System.Drawing.Point(270, 354);
            this.txtBuscarNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.PasswordChar = '\0';
            this.txtBuscarNome.SelectedText = "";
            this.txtBuscarNome.SelectionLength = 0;
            this.txtBuscarNome.SelectionStart = 0;
            this.txtBuscarNome.Size = new System.Drawing.Size(294, 23);
            this.txtBuscarNome.TabIndex = 21;
            this.txtBuscarNome.TabStop = false;
            this.txtBuscarNome.UseSystemPasswordChar = false;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // txtBuscarCNPJ
            // 
            this.txtBuscarCNPJ.Depth = 0;
            this.txtBuscarCNPJ.Hint = "Buscar por CNPJ";
            this.txtBuscarCNPJ.Location = new System.Drawing.Point(11, 354);
            this.txtBuscarCNPJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCNPJ.Name = "txtBuscarCNPJ";
            this.txtBuscarCNPJ.PasswordChar = '\0';
            this.txtBuscarCNPJ.SelectedText = "";
            this.txtBuscarCNPJ.SelectionLength = 0;
            this.txtBuscarCNPJ.SelectionStart = 0;
            this.txtBuscarCNPJ.Size = new System.Drawing.Size(253, 23);
            this.txtBuscarCNPJ.TabIndex = 20;
            this.txtBuscarCNPJ.TabStop = false;
            this.txtBuscarCNPJ.UseSystemPasswordChar = false;
            this.txtBuscarCNPJ.TextChanged += new System.EventHandler(this.txtBuscarCNPJ_TextChanged);
            // 
            // ListaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 770);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.txtBuscarCNPJ);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.DataGridEmpresa);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(870, 770);
            this.Name = "ListaEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Empresas";
            this.Load += new System.EventHandler(this.ListaEmpresa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpresa)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private MetroFramework.Controls.MetroGrid DataGridEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInscMunicipal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeFantasia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRazaoSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRua;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservacao2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservacao1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCNPJ;
        private MetroFramework.Controls.MetroComboBox cbbEstado;
        private MetroFramework.Controls.MetroComboBox cbbMunicipio;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInscEstadual;
        private System.Windows.Forms.Button btnPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox txtContato1;
        private System.Windows.Forms.MaskedTextBox txtContato2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomefantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSC_EST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscricaomunicipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Município;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}