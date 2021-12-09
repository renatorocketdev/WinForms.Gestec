namespace GESTEC.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbbPermissaoLogin = new MetroFramework.Controls.MetroComboBox();
            this.txtSenhaEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCardAdm = new Bunifu.Framework.UI.BunifuCards();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSenhaAdm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomeAdm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCardsRegistro = new Bunifu.Framework.UI.BunifuCards();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNascimentoUser = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFUser = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbbPermissao = new MetroFramework.Controls.MetroComboBox();
            this.btnRegistrarUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSenhaUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCardAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuCardsRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 36);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown_1);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove_1);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(398, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 34;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 120);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 36);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(430, 84);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards1.Controls.Add(this.cbbPermissaoLogin);
            this.bunifuCards1.Controls.Add(this.txtSenhaEmail);
            this.bunifuCards1.Controls.Add(this.txtEmail);
            this.bunifuCards1.Controls.Add(this.btnLogin);
            this.bunifuCards1.Controls.Add(this.btnRegistrar);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 126);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(406, 157);
            this.bunifuCards1.TabIndex = 9;
            // 
            // cbbPermissaoLogin
            // 
            this.cbbPermissaoLogin.BackColor = System.Drawing.Color.White;
            this.cbbPermissaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPermissaoLogin.FormattingEnabled = true;
            this.cbbPermissaoLogin.ItemHeight = 23;
            this.cbbPermissaoLogin.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OPERADOR"});
            this.cbbPermissaoLogin.Location = new System.Drawing.Point(244, 71);
            this.cbbPermissaoLogin.Name = "cbbPermissaoLogin";
            this.cbbPermissaoLogin.PromptText = "Permissões";
            this.cbbPermissaoLogin.Size = new System.Drawing.Size(147, 29);
            this.cbbPermissaoLogin.TabIndex = 3;
            this.cbbPermissaoLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbbPermissaoLogin.UseSelectable = true;
            this.cbbPermissaoLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbPermissaoLogin_KeyPress);
            // 
            // txtSenhaEmail
            // 
            this.txtSenhaEmail.Depth = 0;
            this.txtSenhaEmail.Hint = "Senha";
            this.txtSenhaEmail.Location = new System.Drawing.Point(147, 42);
            this.txtSenhaEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaEmail.Name = "txtSenhaEmail";
            this.txtSenhaEmail.PasswordChar = '•';
            this.txtSenhaEmail.SelectedText = "";
            this.txtSenhaEmail.SelectionLength = 0;
            this.txtSenhaEmail.SelectionStart = 0;
            this.txtSenhaEmail.Size = new System.Drawing.Size(244, 23);
            this.txtSenhaEmail.TabIndex = 2;
            this.txtSenhaEmail.TabStop = false;
            this.txtSenhaEmail.UseSystemPasswordChar = false;
            this.txtSenhaEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaEmail_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(147, 13);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(244, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnLogin.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Logar";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLogin.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(308, 110);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TabStop = false;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnRegistrar.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRegistrar.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(147, 110);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 29);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCardAdm
            // 
            this.bunifuCardAdm.BackColor = System.Drawing.Color.White;
            this.bunifuCardAdm.BorderRadius = 5;
            this.bunifuCardAdm.BottomSahddow = false;
            this.bunifuCardAdm.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCardAdm.Controls.Add(this.metroLabel1);
            this.bunifuCardAdm.Controls.Add(this.pictureBox2);
            this.bunifuCardAdm.Controls.Add(this.btnConfirmar);
            this.bunifuCardAdm.Controls.Add(this.txtSenhaAdm);
            this.bunifuCardAdm.Controls.Add(this.txtNomeAdm);
            this.bunifuCardAdm.Controls.Add(this.materialLabel1);
            this.bunifuCardAdm.LeftSahddow = false;
            this.bunifuCardAdm.Location = new System.Drawing.Point(12, 298);
            this.bunifuCardAdm.Name = "bunifuCardAdm";
            this.bunifuCardAdm.RightSahddow = true;
            this.bunifuCardAdm.ShadowDepth = 20;
            this.bunifuCardAdm.Size = new System.Drawing.Size(406, 140);
            this.bunifuCardAdm.TabIndex = 10;
            this.bunifuCardAdm.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(65, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(302, 57);
            this.metroLabel1.TabIndex = 87;
            this.metroLabel1.Text = "Para realizar o cadastro de um novo usuário é \r\nnecessário o Nome e a Senha do Ad" +
    "ministrador.\r\n";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::GESTEC.Properties.Resources.Warning;
            this.pictureBox2.Image = global::GESTEC.Properties.Resources.ICONWarning;
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ActiveBorderThickness = 1;
            this.btnConfirmar.ActiveCornerRadius = 20;
            this.btnConfirmar.ActiveFillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnConfirmar.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.ButtonText = "Confirmar";
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnConfirmar.IdleBorderThickness = 1;
            this.btnConfirmar.IdleCornerRadius = 20;
            this.btnConfirmar.IdleFillColor = System.Drawing.Color.White;
            this.btnConfirmar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnConfirmar.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(308, 102);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(83, 29);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Depth = 0;
            this.txtSenhaAdm.Hint = "Senha";
            this.txtSenhaAdm.Location = new System.Drawing.Point(207, 71);
            this.txtSenhaAdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '•';
            this.txtSenhaAdm.SelectedText = "";
            this.txtSenhaAdm.SelectionLength = 0;
            this.txtSenhaAdm.SelectionStart = 0;
            this.txtSenhaAdm.Size = new System.Drawing.Size(184, 23);
            this.txtSenhaAdm.TabIndex = 2;
            this.txtSenhaAdm.TabStop = false;
            this.txtSenhaAdm.UseSystemPasswordChar = false;
            // 
            // txtNomeAdm
            // 
            this.txtNomeAdm.Depth = 0;
            this.txtNomeAdm.Hint = "Nome";
            this.txtNomeAdm.Location = new System.Drawing.Point(12, 71);
            this.txtNomeAdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeAdm.Name = "txtNomeAdm";
            this.txtNomeAdm.PasswordChar = '•';
            this.txtNomeAdm.SelectedText = "";
            this.txtNomeAdm.SelectionLength = 0;
            this.txtNomeAdm.SelectionStart = 0;
            this.txtNomeAdm.Size = new System.Drawing.Size(188, 23);
            this.txtNomeAdm.TabIndex = 1;
            this.txtNomeAdm.TabStop = false;
            this.txtNomeAdm.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(65, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuCardsRegistro
            // 
            this.bunifuCardsRegistro.BackColor = System.Drawing.Color.White;
            this.bunifuCardsRegistro.BorderRadius = 5;
            this.bunifuCardsRegistro.BottomSahddow = true;
            this.bunifuCardsRegistro.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCardsRegistro.Controls.Add(this.metroLabel3);
            this.bunifuCardsRegistro.Controls.Add(this.metroLabel2);
            this.bunifuCardsRegistro.Controls.Add(this.txtNascimentoUser);
            this.bunifuCardsRegistro.Controls.Add(this.txtCPFUser);
            this.bunifuCardsRegistro.Controls.Add(this.txtNomeUser);
            this.bunifuCardsRegistro.Controls.Add(this.cbbPermissao);
            this.bunifuCardsRegistro.Controls.Add(this.btnRegistrarUser);
            this.bunifuCardsRegistro.Controls.Add(this.txtSenhaUser);
            this.bunifuCardsRegistro.LeftSahddow = false;
            this.bunifuCardsRegistro.Location = new System.Drawing.Point(12, 454);
            this.bunifuCardsRegistro.Name = "bunifuCardsRegistro";
            this.bunifuCardsRegistro.RightSahddow = true;
            this.bunifuCardsRegistro.ShadowDepth = 20;
            this.bunifuCardsRegistro.Size = new System.Drawing.Size(406, 140);
            this.bunifuCardsRegistro.TabIndex = 90;
            this.bunifuCardsRegistro.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel3.Location = new System.Drawing.Point(207, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 97;
            this.metroLabel3.Text = "Nascimento (*)";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(10, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 96;
            this.metroLabel2.Text = "Número do CPF (*)";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtNascimentoUser
            // 
            this.txtNascimentoUser.BackColor = System.Drawing.Color.White;
            this.txtNascimentoUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNascimentoUser.Enabled = false;
            this.txtNascimentoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimentoUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNascimentoUser.Location = new System.Drawing.Point(207, 83);
            this.txtNascimentoUser.Mask = "00/00/0000";
            this.txtNascimentoUser.Name = "txtNascimentoUser";
            this.txtNascimentoUser.Size = new System.Drawing.Size(99, 15);
            this.txtNascimentoUser.TabIndex = 93;
            // 
            // txtCPFUser
            // 
            this.txtCPFUser.BackColor = System.Drawing.Color.White;
            this.txtCPFUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPFUser.Enabled = false;
            this.txtCPFUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCPFUser.Location = new System.Drawing.Point(10, 83);
            this.txtCPFUser.Mask = "000,000,000-00";
            this.txtCPFUser.Name = "txtCPFUser";
            this.txtCPFUser.Size = new System.Drawing.Size(131, 15);
            this.txtCPFUser.TabIndex = 92;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Depth = 0;
            this.txtNomeUser.Enabled = false;
            this.txtNomeUser.Hint = "Nome";
            this.txtNomeUser.Location = new System.Drawing.Point(13, 17);
            this.txtNomeUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.PasswordChar = '\0';
            this.txtNomeUser.SelectedText = "";
            this.txtNomeUser.SelectionLength = 0;
            this.txtNomeUser.SelectionStart = 0;
            this.txtNomeUser.Size = new System.Drawing.Size(188, 23);
            this.txtNomeUser.TabIndex = 90;
            this.txtNomeUser.TabStop = false;
            this.txtNomeUser.UseSystemPasswordChar = false;
            // 
            // cbbPermissao
            // 
            this.cbbPermissao.BackColor = System.Drawing.Color.White;
            this.cbbPermissao.Enabled = false;
            this.cbbPermissao.FormattingEnabled = true;
            this.cbbPermissao.ItemHeight = 23;
            this.cbbPermissao.Items.AddRange(new object[] {
            "OPERADOR"});
            this.cbbPermissao.Location = new System.Drawing.Point(10, 104);
            this.cbbPermissao.Name = "cbbPermissao";
            this.cbbPermissao.PromptText = "Permissões";
            this.cbbPermissao.Size = new System.Drawing.Size(131, 29);
            this.cbbPermissao.TabIndex = 94;
            this.cbbPermissao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbbPermissao.UseSelectable = true;
            // 
            // btnRegistrarUser
            // 
            this.btnRegistrarUser.ActiveBorderThickness = 1;
            this.btnRegistrarUser.ActiveCornerRadius = 20;
            this.btnRegistrarUser.ActiveFillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarUser.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.btnRegistrarUser.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarUser.BackColor = System.Drawing.Color.White;
            this.btnRegistrarUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarUser.BackgroundImage")));
            this.btnRegistrarUser.ButtonText = "Registrar";
            this.btnRegistrarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUser.Enabled = false;
            this.btnRegistrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRegistrarUser.IdleBorderThickness = 1;
            this.btnRegistrarUser.IdleCornerRadius = 20;
            this.btnRegistrarUser.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrarUser.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRegistrarUser.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarUser.Location = new System.Drawing.Point(308, 102);
            this.btnRegistrarUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrarUser.Name = "btnRegistrarUser";
            this.btnRegistrarUser.Size = new System.Drawing.Size(83, 29);
            this.btnRegistrarUser.TabIndex = 95;
            this.btnRegistrarUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarUser.Click += new System.EventHandler(this.btnRegistrarUser_Click_1);
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Depth = 0;
            this.txtSenhaUser.Enabled = false;
            this.txtSenhaUser.Hint = "Senha";
            this.txtSenhaUser.Location = new System.Drawing.Point(207, 17);
            this.txtSenhaUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '•';
            this.txtSenhaUser.SelectedText = "";
            this.txtSenhaUser.SelectionLength = 0;
            this.txtSenhaUser.SelectionStart = 0;
            this.txtSenhaUser.Size = new System.Drawing.Size(184, 23);
            this.txtSenhaUser.TabIndex = 91;
            this.txtSenhaUser.TabStop = false;
            this.txtSenhaUser.UseSystemPasswordChar = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.bunifuCardsRegistro);
            this.Controls.Add(this.bunifuCardAdm);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 600);
            this.MinimumSize = new System.Drawing.Size(430, 300);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCardAdm.ResumeLayout(false);
            this.bunifuCardAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuCardsRegistro.ResumeLayout(false);
            this.bunifuCardsRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnFechar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCardAdm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaAdm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeAdm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroComboBox cbbPermissaoLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCardsRegistro;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox txtNascimentoUser;
        private System.Windows.Forms.MaskedTextBox txtCPFUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeUser;
        private MetroFramework.Controls.MetroComboBox cbbPermissao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaUser;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}