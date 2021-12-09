namespace GESTEC.Forms
{
    partial class CargosV2Bunifu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargosV2Bunifu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbSituacao = new MetroFramework.Controls.MetroComboBox();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtCPF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCargo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbCargo = new MetroFramework.Controls.MetroComboBox();
            this.cbbEmpresa = new MetroFramework.Controls.MetroComboBox();
            this.cbbNomeProf = new MetroFramework.Controls.MetroComboBox();
            this.cbbCPF = new MetroFramework.Controls.MetroComboBox();
            this.DataGridStatus = new MetroFramework.Controls.MetroGrid();
            this.Idcandidatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nm_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idprofissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBiblia = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picVagas = new System.Windows.Forms.PictureBox();
            this.picEmpresa = new System.Windows.Forms.PictureBox();
            this.picProfissionais = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel7.Controls.Add(this.cbbSituacao);
            this.panel7.Controls.Add(this.btnLimpar);
            this.panel7.Controls.Add(this.btnDeletar);
            this.panel7.Controls.Add(this.btnAtualizar);
            this.panel7.Controls.Add(this.btnSalvar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(115, 562);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(735, 51);
            this.panel7.TabIndex = 36;
            // 
            // cbbSituacao
            // 
            this.cbbSituacao.FormattingEnabled = true;
            this.cbbSituacao.ItemHeight = 23;
            this.cbbSituacao.Items.AddRange(new object[] {
            "Em Andamento",
            "Aprovado",
            "Reprovado"});
            this.cbbSituacao.Location = new System.Drawing.Point(263, 10);
            this.cbbSituacao.Name = "cbbSituacao";
            this.cbbSituacao.PromptText = "Situação";
            this.cbbSituacao.Size = new System.Drawing.Size(193, 29);
            this.cbbSituacao.TabIndex = 49;
            this.cbbSituacao.TabStop = false;
            this.cbbSituacao.UseSelectable = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.BorderRadius = 5;
            this.btnLimpar.ButtonText = "LIMPAR";
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
            this.btnLimpar.Location = new System.Drawing.Point(631, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(92, 36);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "LIMPAR";
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
            this.btnDeletar.ButtonText = "DELETAR";
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
            this.btnDeletar.Location = new System.Drawing.Point(533, 9);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(92, 36);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.ButtonText = "ATUALIZAR";
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
            this.btnAtualizar.Location = new System.Drawing.Point(108, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(92, 36);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 5;
            this.btnSalvar.ButtonText = "SALVAR";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = null;
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = true;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 90D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(10, 9);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(92, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards1.Controls.Add(this.txtCPF);
            this.bunifuCards1.Controls.Add(this.txtCargo);
            this.bunifuCards1.Controls.Add(this.txtID);
            this.bunifuCards1.Controls.Add(this.cbbCargo);
            this.bunifuCards1.Controls.Add(this.cbbEmpresa);
            this.bunifuCards1.Controls.Add(this.cbbNomeProf);
            this.bunifuCards1.Controls.Add(this.cbbCPF);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(255, 126);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(590, 128);
            this.bunifuCards1.TabIndex = 39;
            // 
            // txtCPF
            // 
            this.txtCPF.Depth = 0;
            this.txtCPF.Hint = "Pesquisar por CPF";
            this.txtCPF.Location = new System.Drawing.Point(379, 88);
            this.txtCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.Size = new System.Drawing.Size(193, 23);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.UseSystemPasswordChar = false;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Depth = 0;
            this.txtCargo.Hint = "Pesquisar por Cargo";
            this.txtCargo.Location = new System.Drawing.Point(379, 53);
            this.txtCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.SelectedText = "";
            this.txtCargo.SelectionLength = 0;
            this.txtCargo.SelectionStart = 0;
            this.txtCargo.Size = new System.Drawing.Size(193, 23);
            this.txtCargo.TabIndex = 5;
            this.txtCargo.UseSystemPasswordChar = false;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "ID";
            this.txtID.Location = new System.Drawing.Point(13, 15);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(47, 23);
            this.txtID.TabIndex = 1;
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cbbCargo
            // 
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.ItemHeight = 23;
            this.cbbCargo.Location = new System.Drawing.Point(13, 82);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.PromptText = "Cargo";
            this.cbbCargo.Size = new System.Drawing.Size(360, 29);
            this.cbbCargo.TabIndex = 6;
            this.cbbCargo.UseSelectable = true;
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.ItemHeight = 23;
            this.cbbEmpresa.Location = new System.Drawing.Point(13, 47);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.PromptText = "Empresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(360, 29);
            this.cbbEmpresa.TabIndex = 4;
            this.cbbEmpresa.UseSelectable = true;
            this.cbbEmpresa.TextChanged += new System.EventHandler(this.cbbEmpresa_TextChanged);
            // 
            // cbbNomeProf
            // 
            this.cbbNomeProf.FormattingEnabled = true;
            this.cbbNomeProf.ItemHeight = 23;
            this.cbbNomeProf.Location = new System.Drawing.Point(66, 9);
            this.cbbNomeProf.Name = "cbbNomeProf";
            this.cbbNomeProf.Size = new System.Drawing.Size(307, 29);
            this.cbbNomeProf.TabIndex = 2;
            this.cbbNomeProf.UseSelectable = true;
            // 
            // cbbCPF
            // 
            this.cbbCPF.FormattingEnabled = true;
            this.cbbCPF.ItemHeight = 23;
            this.cbbCPF.Location = new System.Drawing.Point(379, 9);
            this.cbbCPF.Name = "cbbCPF";
            this.cbbCPF.Size = new System.Drawing.Size(193, 29);
            this.cbbCPF.TabIndex = 3;
            this.cbbCPF.UseSelectable = true;
            // 
            // DataGridStatus
            // 
            this.DataGridStatus.AllowUserToAddRows = false;
            this.DataGridStatus.AllowUserToDeleteRows = false;
            this.DataGridStatus.AllowUserToResizeRows = false;
            this.DataGridStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcandidatura,
            this.Nm_empresa,
            this.Cargo,
            this.Idprofissional,
            this.Nome,
            this.Cpf,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridStatus.EnableHeadersVisualStyles = false;
            this.DataGridStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridStatus.Location = new System.Drawing.Point(121, 260);
            this.DataGridStatus.Name = "DataGridStatus";
            this.DataGridStatus.ReadOnly = true;
            this.DataGridStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridStatus.Size = new System.Drawing.Size(721, 296);
            this.DataGridStatus.TabIndex = 40;
            this.DataGridStatus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStatus_CellDoubleClick);
            // 
            // Idcandidatura
            // 
            this.Idcandidatura.DataPropertyName = "Idcandidatura";
            this.Idcandidatura.HeaderText = "ID Candidatura";
            this.Idcandidatura.Name = "Idcandidatura";
            this.Idcandidatura.ReadOnly = true;
            // 
            // Nm_empresa
            // 
            this.Nm_empresa.DataPropertyName = "Nm_empresa";
            this.Nm_empresa.HeaderText = "Nome Empresa";
            this.Nm_empresa.Name = "Nm_empresa";
            this.Nm_empresa.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargos";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Idprofissional
            // 
            this.Idprofissional.DataPropertyName = "Idprofissional";
            this.Idprofissional.HeaderText = "ID Profissional";
            this.Idprofissional.Name = "Idprofissional";
            this.Idprofissional.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.picBiblia);
            this.panel3.Controls.Add(this.picEmail);
            this.panel3.Controls.Add(this.picVagas);
            this.panel3.Controls.Add(this.picEmpresa);
            this.panel3.Controls.Add(this.picProfissionais);
            this.panel3.Controls.Add(this.picUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 493);
            this.panel3.TabIndex = 34;
            // 
            // picBiblia
            // 
            this.picBiblia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBiblia.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBiblia.Image = global::GESTEC.Properties.Resources.Bible;
            this.picBiblia.Location = new System.Drawing.Point(0, 410);
            this.picBiblia.Name = "picBiblia";
            this.picBiblia.Size = new System.Drawing.Size(115, 82);
            this.picBiblia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBiblia.TabIndex = 27;
            this.picBiblia.TabStop = false;
            this.picBiblia.Click += new System.EventHandler(this.picBiblia_Click);
            // 
            // picEmail
            // 
            this.picEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.picEmail.Image = global::GESTEC.Properties.Resources.Email;
            this.picEmail.Location = new System.Drawing.Point(0, 328);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(115, 82);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmail.TabIndex = 25;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.picEmail_Click);
            // 
            // picVagas
            // 
            this.picVagas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVagas.Dock = System.Windows.Forms.DockStyle.Top;
            this.picVagas.Image = global::GESTEC.Properties.Resources.Jobs;
            this.picVagas.Location = new System.Drawing.Point(0, 246);
            this.picVagas.Name = "picVagas";
            this.picVagas.Size = new System.Drawing.Size(115, 82);
            this.picVagas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVagas.TabIndex = 24;
            this.picVagas.TabStop = false;
            this.picVagas.Click += new System.EventHandler(this.picVagas_Click);
            // 
            // picEmpresa
            // 
            this.picEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.picEmpresa.Image = global::GESTEC.Properties.Resources.Bussines;
            this.picEmpresa.Location = new System.Drawing.Point(0, 164);
            this.picEmpresa.Name = "picEmpresa";
            this.picEmpresa.Size = new System.Drawing.Size(115, 82);
            this.picEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmpresa.TabIndex = 22;
            this.picEmpresa.TabStop = false;
            this.picEmpresa.Click += new System.EventHandler(this.picEmpresa_Click);
            // 
            // picProfissionais
            // 
            this.picProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProfissionais.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProfissionais.Image = global::GESTEC.Properties.Resources.Worker;
            this.picProfissionais.Location = new System.Drawing.Point(0, 82);
            this.picProfissionais.Name = "picProfissionais";
            this.picProfissionais.Size = new System.Drawing.Size(115, 82);
            this.picProfissionais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfissionais.TabIndex = 23;
            this.picProfissionais.TabStop = false;
            this.picProfissionais.Click += new System.EventHandler(this.picProfissionais_Click);
            // 
            // picUser
            // 
            this.picUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.picUser.Image = global::GESTEC.Properties.Resources.User1;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(115, 82);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 21;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.picUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.panelControlBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 120);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(850, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 22;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click_1);
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
            this.panelControlBox.Size = new System.Drawing.Size(850, 36);
            this.panelControlBox.TabIndex = 1;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseDown_1);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseMove_1);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::GESTEC.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(754, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 36);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 24;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::GESTEC.Properties.Resources.Maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(786, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 23;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(818, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 22;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Image = global::GESTEC.Properties.Resources.Cargo;
            this.pictureBox7.Location = new System.Drawing.Point(121, 126);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(128, 128);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            // 
            // CargosV2Bunifu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 613);
            this.Controls.Add(this.DataGridStatus);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargosV2Bunifu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate-se";
            this.panel7.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBiblia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MetroFramework.Controls.MetroComboBox cbbEmpresa;
        private MetroFramework.Controls.MetroComboBox cbbCargo;
        private MetroFramework.Controls.MetroComboBox cbbNomeProf;
        private MetroFramework.Controls.MetroComboBox cbbCPF;
        private MetroFramework.Controls.MetroComboBox cbbSituacao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MetroFramework.Controls.MetroGrid DataGridStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcandidatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nm_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idprofissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCPF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCargo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBiblia;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picVagas;
        private System.Windows.Forms.PictureBox picEmpresa;
        private System.Windows.Forms.PictureBox picProfissionais;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}