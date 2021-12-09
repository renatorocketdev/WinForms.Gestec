namespace FTP24CP
{
    partial class frmUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.grpBoxUpload = new Bunifu.Framework.UI.BunifuCards();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUpload = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDownload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtArquivoNovoNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRenomear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtArquivoNomeAtual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNovoDiretorio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lbArquivos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNomePastaLista = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNovoDiretorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.grpBoxUpload.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panelControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.panelControlBox.Controls.Add(this.btnMinimizar);
            this.panelControlBox.Controls.Add(this.btnMaximizar);
            this.panelControlBox.Controls.Add(this.btnFechar);
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(871, 36);
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
            this.btnMinimizar.Location = new System.Drawing.Point(775, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 36);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 36;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
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
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
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
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // grpBoxUpload
            // 
            this.grpBoxUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxUpload.BackColor = System.Drawing.Color.White;
            this.grpBoxUpload.BorderRadius = 5;
            this.grpBoxUpload.BottomSahddow = true;
            this.grpBoxUpload.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.grpBoxUpload.Controls.Add(this.materialSingleLineTextField1);
            this.grpBoxUpload.Controls.Add(this.txtUpload);
            this.grpBoxUpload.Controls.Add(this.groupBox1);
            this.grpBoxUpload.LeftSahddow = false;
            this.grpBoxUpload.Location = new System.Drawing.Point(13, 126);
            this.grpBoxUpload.Name = "grpBoxUpload";
            this.grpBoxUpload.RightSahddow = true;
            this.grpBoxUpload.ShadowDepth = 20;
            this.grpBoxUpload.Size = new System.Drawing.Size(417, 104);
            this.grpBoxUpload.TabIndex = 27;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Título da Vaga (*)";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(-555, -251);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(495, 23);
            this.materialSingleLineTextField1.TabIndex = 62;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // txtUpload
            // 
            this.txtUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpload.BackColor = System.Drawing.Color.White;
            this.txtUpload.Depth = 0;
            this.txtUpload.Hint = "Upload";
            this.txtUpload.Location = new System.Drawing.Point(7, 12);
            this.txtUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.PasswordChar = '\0';
            this.txtUpload.SelectedText = "";
            this.txtUpload.SelectionLength = 0;
            this.txtUpload.SelectionStart = 0;
            this.txtUpload.Size = new System.Drawing.Size(397, 23);
            this.txtUpload.TabIndex = 2;
            this.txtUpload.TabStop = false;
            this.txtUpload.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Location = new System.Drawing.Point(7, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 55);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.BorderRadius = 5;
            this.btnUpload.ButtonText = "UPLOAD";
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpload.Iconimage = null;
            this.btnUpload.Iconimage_right = null;
            this.btnUpload.Iconimage_right_Selected = null;
            this.btnUpload.Iconimage_Selected = null;
            this.btnUpload.IconMarginLeft = 0;
            this.btnUpload.IconMarginRight = 0;
            this.btnUpload.IconRightVisible = true;
            this.btnUpload.IconRightZoom = 0D;
            this.btnUpload.IconVisible = true;
            this.btnUpload.IconZoom = 90D;
            this.btnUpload.IsTab = false;
            this.btnUpload.Location = new System.Drawing.Point(6, 13);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnUpload.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpload.selected = false;
            this.btnUpload.Size = new System.Drawing.Size(108, 36);
            this.btnUpload.TabIndex = 63;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.Textcolor = System.Drawing.Color.White;
            this.btnUpload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownload.BorderRadius = 5;
            this.btnDownload.ButtonText = "DOWNLOAD";
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.DisabledColor = System.Drawing.Color.Gray;
            this.btnDownload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDownload.Iconimage = null;
            this.btnDownload.Iconimage_right = null;
            this.btnDownload.Iconimage_right_Selected = null;
            this.btnDownload.Iconimage_Selected = null;
            this.btnDownload.IconMarginLeft = 0;
            this.btnDownload.IconMarginRight = 0;
            this.btnDownload.IconRightVisible = true;
            this.btnDownload.IconRightZoom = 0D;
            this.btnDownload.IconVisible = true;
            this.btnDownload.IconZoom = 90D;
            this.btnDownload.IsTab = false;
            this.btnDownload.Location = new System.Drawing.Point(147, 13);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDownload.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDownload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDownload.selected = false;
            this.btnDownload.Size = new System.Drawing.Size(114, 36);
            this.btnDownload.TabIndex = 64;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownload.Textcolor = System.Drawing.Color.White;
            this.btnDownload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
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
            this.btnDeletar.Location = new System.Drawing.Point(290, 13);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(101, 36);
            this.btnDeletar.TabIndex = 65;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards1.Controls.Add(this.txtArquivoNovoNome);
            this.bunifuCards1.Controls.Add(this.materialSingleLineTextField2);
            this.bunifuCards1.Controls.Add(this.btnRenomear);
            this.bunifuCards1.Controls.Add(this.txtArquivoNomeAtual);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(441, 126);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(418, 104);
            this.bunifuCards1.TabIndex = 66;
            // 
            // txtArquivoNovoNome
            // 
            this.txtArquivoNovoNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivoNovoNome.BackColor = System.Drawing.Color.White;
            this.txtArquivoNovoNome.Depth = 0;
            this.txtArquivoNovoNome.Hint = "Novo Nome";
            this.txtArquivoNovoNome.Location = new System.Drawing.Point(7, 67);
            this.txtArquivoNovoNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtArquivoNovoNome.Name = "txtArquivoNovoNome";
            this.txtArquivoNovoNome.PasswordChar = '\0';
            this.txtArquivoNovoNome.SelectedText = "";
            this.txtArquivoNovoNome.SelectionLength = 0;
            this.txtArquivoNovoNome.SelectionStart = 0;
            this.txtArquivoNovoNome.Size = new System.Drawing.Size(291, 23);
            this.txtArquivoNovoNome.TabIndex = 64;
            this.txtArquivoNovoNome.TabStop = false;
            this.txtArquivoNovoNome.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Título da Vaga (*)";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(-555, -251);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(495, 23);
            this.materialSingleLineTextField2.TabIndex = 62;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRenomear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenomear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRenomear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRenomear.BorderRadius = 5;
            this.btnRenomear.ButtonText = "RENOMEAR";
            this.btnRenomear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenomear.DisabledColor = System.Drawing.Color.Gray;
            this.btnRenomear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRenomear.Iconimage = null;
            this.btnRenomear.Iconimage_right = null;
            this.btnRenomear.Iconimage_right_Selected = null;
            this.btnRenomear.Iconimage_Selected = null;
            this.btnRenomear.IconMarginLeft = 0;
            this.btnRenomear.IconMarginRight = 0;
            this.btnRenomear.IconRightVisible = true;
            this.btnRenomear.IconRightZoom = 0D;
            this.btnRenomear.IconVisible = true;
            this.btnRenomear.IconZoom = 90D;
            this.btnRenomear.IsTab = false;
            this.btnRenomear.Location = new System.Drawing.Point(304, 54);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnRenomear.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnRenomear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRenomear.selected = false;
            this.btnRenomear.Size = new System.Drawing.Size(105, 36);
            this.btnRenomear.TabIndex = 63;
            this.btnRenomear.Text = "RENOMEAR";
            this.btnRenomear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRenomear.Textcolor = System.Drawing.Color.White;
            this.btnRenomear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // txtArquivoNomeAtual
            // 
            this.txtArquivoNomeAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivoNomeAtual.BackColor = System.Drawing.Color.White;
            this.txtArquivoNomeAtual.Depth = 0;
            this.txtArquivoNomeAtual.Hint = "Nome Anterior";
            this.txtArquivoNomeAtual.Location = new System.Drawing.Point(7, 12);
            this.txtArquivoNomeAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtArquivoNomeAtual.Name = "txtArquivoNomeAtual";
            this.txtArquivoNomeAtual.PasswordChar = '\0';
            this.txtArquivoNomeAtual.SelectedText = "";
            this.txtArquivoNomeAtual.SelectionLength = 0;
            this.txtArquivoNomeAtual.SelectionStart = 0;
            this.txtArquivoNomeAtual.Size = new System.Drawing.Size(291, 23);
            this.txtArquivoNomeAtual.TabIndex = 2;
            this.txtArquivoNomeAtual.TabStop = false;
            this.txtArquivoNomeAtual.UseSystemPasswordChar = false;
            // 
            // txtNovoDiretorio
            // 
            this.txtNovoDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovoDiretorio.BackColor = System.Drawing.Color.White;
            this.txtNovoDiretorio.Depth = 0;
            this.txtNovoDiretorio.Hint = "Criar um novo diretório";
            this.txtNovoDiretorio.Location = new System.Drawing.Point(6, 21);
            this.txtNovoDiretorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNovoDiretorio.Name = "txtNovoDiretorio";
            this.txtNovoDiretorio.PasswordChar = '\0';
            this.txtNovoDiretorio.SelectedText = "";
            this.txtNovoDiretorio.SelectionLength = 0;
            this.txtNovoDiretorio.SelectionStart = 0;
            this.txtNovoDiretorio.Size = new System.Drawing.Size(238, 23);
            this.txtNovoDiretorio.TabIndex = 65;
            this.txtNovoDiretorio.TabStop = false;
            this.txtNovoDiretorio.UseSystemPasswordChar = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.bunifuCards2.Controls.Add(this.lbArquivos);
            this.bunifuCards2.Controls.Add(this.groupBox2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(13, 236);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(846, 405);
            this.bunifuCards2.TabIndex = 65;
            // 
            // lbArquivos
            // 
            this.lbArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArquivos.FormattingEnabled = true;
            this.lbArquivos.Location = new System.Drawing.Point(7, 80);
            this.lbArquivos.Name = "lbArquivos";
            this.lbArquivos.Size = new System.Drawing.Size(830, 316);
            this.lbArquivos.TabIndex = 65;
            this.lbArquivos.Click += new System.EventHandler(this.lbArquivos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLista);
            this.groupBox2.Controls.Add(this.txtNomePastaLista);
            this.groupBox2.Controls.Add(this.btnNovoDiretorio);
            this.groupBox2.Controls.Add(this.txtNovoDiretorio);
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 50);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // btnLista
            // 
            this.btnLista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLista.BorderRadius = 5;
            this.btnLista.ButtonText = "LISTAR ARQUIVOS";
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.DisabledColor = System.Drawing.Color.Gray;
            this.btnLista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLista.Iconimage = null;
            this.btnLista.Iconimage_right = null;
            this.btnLista.Iconimage_right_Selected = null;
            this.btnLista.Iconimage_Selected = null;
            this.btnLista.IconMarginLeft = 0;
            this.btnLista.IconMarginRight = 0;
            this.btnLista.IconRightVisible = true;
            this.btnLista.IconRightZoom = 0D;
            this.btnLista.IconVisible = true;
            this.btnLista.IconZoom = 90D;
            this.btnLista.IsTab = false;
            this.btnLista.Location = new System.Drawing.Point(666, 10);
            this.btnLista.Name = "btnLista";
            this.btnLista.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLista.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLista.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLista.selected = false;
            this.btnLista.Size = new System.Drawing.Size(158, 36);
            this.btnLista.TabIndex = 67;
            this.btnLista.Text = "LISTAR ARQUIVOS";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLista.Textcolor = System.Drawing.Color.White;
            this.btnLista.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtNomePastaLista
            // 
            this.txtNomePastaLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePastaLista.BackColor = System.Drawing.Color.White;
            this.txtNomePastaLista.Depth = 0;
            this.txtNomePastaLista.Hint = "Nome da Pasta";
            this.txtNomePastaLista.Location = new System.Drawing.Point(421, 21);
            this.txtNomePastaLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomePastaLista.Name = "txtNomePastaLista";
            this.txtNomePastaLista.PasswordChar = '\0';
            this.txtNomePastaLista.SelectedText = "";
            this.txtNomePastaLista.SelectionLength = 0;
            this.txtNomePastaLista.SelectionStart = 0;
            this.txtNomePastaLista.Size = new System.Drawing.Size(238, 23);
            this.txtNomePastaLista.TabIndex = 66;
            this.txtNomePastaLista.TabStop = false;
            this.txtNomePastaLista.UseSystemPasswordChar = false;
            // 
            // btnNovoDiretorio
            // 
            this.btnNovoDiretorio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnNovoDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoDiretorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnNovoDiretorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoDiretorio.BorderRadius = 5;
            this.btnNovoDiretorio.ButtonText = "NOVO DIRETÓRIO";
            this.btnNovoDiretorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoDiretorio.DisabledColor = System.Drawing.Color.Gray;
            this.btnNovoDiretorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovoDiretorio.Iconimage = null;
            this.btnNovoDiretorio.Iconimage_right = null;
            this.btnNovoDiretorio.Iconimage_right_Selected = null;
            this.btnNovoDiretorio.Iconimage_Selected = null;
            this.btnNovoDiretorio.IconMarginLeft = 0;
            this.btnNovoDiretorio.IconMarginRight = 0;
            this.btnNovoDiretorio.IconRightVisible = true;
            this.btnNovoDiretorio.IconRightZoom = 0D;
            this.btnNovoDiretorio.IconVisible = true;
            this.btnNovoDiretorio.IconZoom = 90D;
            this.btnNovoDiretorio.IsTab = false;
            this.btnNovoDiretorio.Location = new System.Drawing.Point(252, 10);
            this.btnNovoDiretorio.Name = "btnNovoDiretorio";
            this.btnNovoDiretorio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnNovoDiretorio.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnNovoDiretorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNovoDiretorio.selected = false;
            this.btnNovoDiretorio.Size = new System.Drawing.Size(158, 36);
            this.btnNovoDiretorio.TabIndex = 64;
            this.btnNovoDiretorio.Text = "NOVO DIRETÓRIO";
            this.btnNovoDiretorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovoDiretorio.Textcolor = System.Drawing.Color.White;
            this.btnNovoDiretorio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoDiretorio.Click += new System.EventHandler(this.btnNovoDiretorio_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(871, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 25;
            this.pictureBoxLogo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 653);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.grpBoxUpload);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelControlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP App : Servidor - ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.grpBoxUpload.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private Bunifu.Framework.UI.BunifuCards grpBoxUpload;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUpload;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownload;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpload;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtArquivoNovoNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private Bunifu.Framework.UI.BunifuFlatButton btnRenomear;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtArquivoNomeAtual;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNovoDiretorio;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.ListBox lbArquivos;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovoDiretorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLista;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomePastaLista;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

