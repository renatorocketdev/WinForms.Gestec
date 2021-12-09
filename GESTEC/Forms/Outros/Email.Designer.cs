namespace GESTEC.Forms
{
    partial class EmailBunifu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailBunifu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txtAssunto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtEmailEnvio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbImportar = new MetroFramework.Controls.MetroComboBox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBiblia = new System.Windows.Forms.PictureBox();
            this.picCargos = new System.Windows.Forms.PictureBox();
            this.picVagas = new System.Windows.Forms.PictureBox();
            this.picEmpresa = new System.Windows.Forms.PictureBox();
            this.picProfissionais = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDetalhesEmail = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(850, 120);
            this.panel1.TabIndex = 6;
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
            this.pictureBoxLogo.TabIndex = 21;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
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
            this.panelControlBox.TabIndex = 0;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
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
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
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
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
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
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssunto.Depth = 0;
            this.txtAssunto.Hint = "Assunto";
            this.txtAssunto.Location = new System.Drawing.Point(3, 60);
            this.txtAssunto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.PasswordChar = '\0';
            this.txtAssunto.SelectedText = "";
            this.txtAssunto.SelectionLength = 0;
            this.txtAssunto.SelectionStart = 0;
            this.txtAssunto.Size = new System.Drawing.Size(566, 23);
            this.txtAssunto.TabIndex = 2;
            this.txtAssunto.TabStop = false;
            this.txtAssunto.UseSystemPasswordChar = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(255, 126);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(580, 128);
            this.metroTabControl1.TabIndex = 42;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.txtAssunto);
            this.metroTabPage1.Controls.Add(this.txtEmailEnvio);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(572, 86);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Enviar E-mail";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtEmailEnvio
            // 
            this.txtEmailEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailEnvio.BackColor = System.Drawing.Color.White;
            this.txtEmailEnvio.Depth = 0;
            this.txtEmailEnvio.Hint = "Para";
            this.txtEmailEnvio.Location = new System.Drawing.Point(3, 15);
            this.txtEmailEnvio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEnvio.Name = "txtEmailEnvio";
            this.txtEmailEnvio.PasswordChar = '\0';
            this.txtEmailEnvio.SelectedText = "";
            this.txtEmailEnvio.SelectionLength = 0;
            this.txtEmailEnvio.SelectionStart = 0;
            this.txtEmailEnvio.Size = new System.Drawing.Size(566, 23);
            this.txtEmailEnvio.TabIndex = 1;
            this.txtEmailEnvio.TabStop = false;
            this.txtEmailEnvio.UseSystemPasswordChar = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel7.Controls.Add(this.cbbImportar);
            this.panel7.Controls.Add(this.btnEnviar);
            this.panel7.Location = new System.Drawing.Point(0, 562);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(850, 51);
            this.panel7.TabIndex = 43;
            // 
            // cbbImportar
            // 
            this.cbbImportar.BackColor = System.Drawing.Color.White;
            this.cbbImportar.FormattingEnabled = true;
            this.cbbImportar.ItemHeight = 23;
            this.cbbImportar.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbbImportar.Location = new System.Drawing.Point(626, 16);
            this.cbbImportar.Name = "cbbImportar";
            this.cbbImportar.PromptText = "Importar Arquivos";
            this.cbbImportar.Size = new System.Drawing.Size(205, 29);
            this.cbbImportar.TabIndex = 10000;
            this.cbbImportar.TabStop = false;
            this.cbbImportar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbbImportar.UseCustomBackColor = true;
            this.cbbImportar.UseSelectable = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.BorderRadius = 5;
            this.btnEnviar.ButtonText = "IMPORTAR E ENVIAR";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnviar.Iconimage = null;
            this.btnEnviar.Iconimage_right = null;
            this.btnEnviar.Iconimage_right_Selected = null;
            this.btnEnviar.Iconimage_Selected = null;
            this.btnEnviar.IconMarginLeft = 0;
            this.btnEnviar.IconMarginRight = 0;
            this.btnEnviar.IconRightVisible = true;
            this.btnEnviar.IconRightZoom = 0D;
            this.btnEnviar.IconVisible = true;
            this.btnEnviar.IconZoom = 90D;
            this.btnEnviar.IsTab = false;
            this.btnEnviar.Location = new System.Drawing.Point(125, 9);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnEnviar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnviar.selected = false;
            this.btnEnviar.Size = new System.Drawing.Size(173, 36);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Text = "IMPORTAR E ENVIAR";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Textcolor = System.Drawing.Color.White;
            this.btnEnviar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.picBiblia);
            this.panel3.Controls.Add(this.picCargos);
            this.panel3.Controls.Add(this.picVagas);
            this.panel3.Controls.Add(this.picEmpresa);
            this.panel3.Controls.Add(this.picProfissionais);
            this.panel3.Controls.Add(this.picUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 493);
            this.panel3.TabIndex = 7;
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
            this.picBiblia.TabIndex = 32;
            this.picBiblia.TabStop = false;
            this.picBiblia.Click += new System.EventHandler(this.picBiblia_Click);
            // 
            // picCargos
            // 
            this.picCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCargos.Image = global::GESTEC.Properties.Resources.Post;
            this.picCargos.Location = new System.Drawing.Point(0, 328);
            this.picCargos.Name = "picCargos";
            this.picCargos.Size = new System.Drawing.Size(115, 82);
            this.picCargos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCargos.TabIndex = 31;
            this.picCargos.TabStop = false;
            this.picCargos.Click += new System.EventHandler(this.picCargos_Click);
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
            this.picVagas.TabIndex = 30;
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
            this.picEmpresa.TabIndex = 28;
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
            this.picProfissionais.TabIndex = 29;
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
            this.picUser.TabIndex = 27;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.picUser_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Image = global::GESTEC.Properties.Resources.Email1;
            this.pictureBox7.Location = new System.Drawing.Point(121, 126);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(128, 128);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbDetalhesEmail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(121, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 296);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensagem";
            // 
            // rtbDetalhesEmail
            // 
            this.rtbDetalhesEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDetalhesEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDetalhesEmail.Location = new System.Drawing.Point(6, 21);
            this.rtbDetalhesEmail.Name = "rtbDetalhesEmail";
            this.rtbDetalhesEmail.Size = new System.Drawing.Size(701, 269);
            this.rtbDetalhesEmail.TabIndex = 33;
            this.rtbDetalhesEmail.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";
            // 
            // EmailBunifu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 613);
            this.Name = "EmailBunifu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBiblia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAssunto;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnviar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBiblia;
        private System.Windows.Forms.PictureBox picCargos;
        private System.Windows.Forms.PictureBox picVagas;
        private System.Windows.Forms.PictureBox picEmpresa;
        private System.Windows.Forms.PictureBox picProfissionais;
        private System.Windows.Forms.PictureBox picUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEnvio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDetalhesEmail;
        private MetroFramework.Controls.MetroComboBox cbbImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}