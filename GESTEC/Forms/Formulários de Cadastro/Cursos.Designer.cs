namespace GESTEC.Forms.Formulários_de_Cadastro
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBuscarCurso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridCurso = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInserir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtDescricaoCurso = new System.Windows.Forms.RichTextBox();
            this.txtValorCurso = new System.Windows.Forms.MaskedTextBox();
            this.txtDuracaoCurso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomeCurso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl3 = new MetroFramework.Controls.MetroTabControl();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.metroTabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
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
            this.panelControlBox.Size = new System.Drawing.Size(740, 36);
            this.panelControlBox.TabIndex = 22;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown_1);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove_1);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::GESTEC.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(644, 0);
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
            this.btnMaximizar.Location = new System.Drawing.Point(676, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 29;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = global::GESTEC.Properties.Resources.Shutdown;
            this.btnFechar.Location = new System.Drawing.Point(708, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 36);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 28;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCurso.Depth = 0;
            this.txtBuscarCurso.Hint = "Buscar por Curso";
            this.txtBuscarCurso.Location = new System.Drawing.Point(12, 314);
            this.txtBuscarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.PasswordChar = '\0';
            this.txtBuscarCurso.SelectedText = "";
            this.txtBuscarCurso.SelectionLength = 0;
            this.txtBuscarCurso.SelectionStart = 0;
            this.txtBuscarCurso.Size = new System.Drawing.Size(323, 23);
            this.txtBuscarCurso.TabIndex = 6;
            this.txtBuscarCurso.TabStop = false;
            this.txtBuscarCurso.UseSystemPasswordChar = false;
            this.txtBuscarCurso.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
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
            this.btnLimpar.Location = new System.Drawing.Point(635, 307);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpar.selected = false;
            this.btnLimpar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpar.TabIndex = 47;
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
            this.btnDeletar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeletar.Location = new System.Drawing.Point(537, 307);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(92, 30);
            this.btnDeletar.TabIndex = 46;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // DataGridCurso
            // 
            this.DataGridCurso.AllowUserToAddRows = false;
            this.DataGridCurso.AllowUserToDeleteRows = false;
            this.DataGridCurso.AllowUserToResizeRows = false;
            this.DataGridCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCurso.ColumnHeadersHeight = 35;
            this.DataGridCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCurso.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCurso.EnableHeadersVisualStyles = false;
            this.DataGridCurso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridCurso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridCurso.Location = new System.Drawing.Point(12, 343);
            this.DataGridCurso.Name = "DataGridCurso";
            this.DataGridCurso.ReadOnly = true;
            this.DataGridCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridCurso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCurso.Size = new System.Drawing.Size(715, 255);
            this.DataGridCurso.TabIndex = 48;
            this.DataGridCurso.TabStop = false;
            this.DataGridCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCurso_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_curso";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nome_curso";
            this.Column1.HeaderText = "Nome do Curso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "categoria_curso";
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "duracao_curso";
            this.Column4.HeaderText = "Duração do Curso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "valor_curso";
            this.Column3.HeaderText = "Valor Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "desc_curso";
            this.Column5.HeaderText = "Descrição do Curso";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.btnAtualizar.Location = new System.Drawing.Point(439, 307);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(92, 30);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            this.btnInserir.Location = new System.Drawing.Point(341, 307);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnInserir.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.selected = false;
            this.btnInserir.Size = new System.Drawing.Size(92, 30);
            this.btnInserir.TabIndex = 49;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.Textcolor = System.Drawing.Color.White;
            this.btnInserir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox11.Image = global::GESTEC.Properties.Resources.Curso;
            this.pictureBox11.Location = new System.Drawing.Point(5, 126);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(128, 128);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 42;
            this.pictureBox11.TabStop = false;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.BackColor = System.Drawing.Color.White;
            this.metroTabPage7.Controls.Add(this.txtCategoria);
            this.metroTabPage7.Controls.Add(this.groupBox1);
            this.metroTabPage7.Controls.Add(this.txtValorCurso);
            this.metroTabPage7.Controls.Add(this.txtDuracaoCurso);
            this.metroTabPage7.Controls.Add(this.txtNomeCurso);
            this.metroTabPage7.Controls.Add(this.metroLabel2);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(580, 116);
            this.metroTabPage7.TabIndex = 0;
            this.metroTabPage7.Text = "Cadastro de Curso";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Hint = "Categoria *";
            this.txtCategoria.Location = new System.Drawing.Point(3, 86);
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(196, 23);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.TabStop = false;
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtDescricaoCurso);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(237, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 71);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição do Curso";
            // 
            // rtDescricaoCurso
            // 
            this.rtDescricaoCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtDescricaoCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtDescricaoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtDescricaoCurso.Location = new System.Drawing.Point(3, 19);
            this.rtDescricaoCurso.Name = "rtDescricaoCurso";
            this.rtDescricaoCurso.Size = new System.Drawing.Size(334, 49);
            this.rtDescricaoCurso.TabIndex = 5;
            this.rtDescricaoCurso.Text = "";
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.BackColor = System.Drawing.Color.White;
            this.txtValorCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCurso.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtValorCurso.Location = new System.Drawing.Point(471, 17);
            this.txtValorCurso.Mask = "$ 0000,00";
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(106, 15);
            this.txtValorCurso.TabIndex = 2;
            // 
            // txtDuracaoCurso
            // 
            this.txtDuracaoCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracaoCurso.BackColor = System.Drawing.Color.White;
            this.txtDuracaoCurso.Depth = 0;
            this.txtDuracaoCurso.Hint = "Duração do Curso *";
            this.txtDuracaoCurso.Location = new System.Drawing.Point(3, 38);
            this.txtDuracaoCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDuracaoCurso.Name = "txtDuracaoCurso";
            this.txtDuracaoCurso.PasswordChar = '\0';
            this.txtDuracaoCurso.SelectedText = "";
            this.txtDuracaoCurso.SelectionLength = 0;
            this.txtDuracaoCurso.SelectionStart = 0;
            this.txtDuracaoCurso.Size = new System.Drawing.Size(196, 23);
            this.txtDuracaoCurso.TabIndex = 3;
            this.txtDuracaoCurso.TabStop = false;
            this.txtDuracaoCurso.UseSystemPasswordChar = false;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCurso.BackColor = System.Drawing.Color.White;
            this.txtNomeCurso.Depth = 0;
            this.txtNomeCurso.Hint = "Nome do Curso *";
            this.txtNomeCurso.Location = new System.Drawing.Point(3, 9);
            this.txtNomeCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.PasswordChar = '\0';
            this.txtNomeCurso.SelectedText = "";
            this.txtNomeCurso.SelectionLength = 0;
            this.txtNomeCurso.SelectionStart = 0;
            this.txtNomeCurso.Size = new System.Drawing.Size(366, 23);
            this.txtNomeCurso.TabIndex = 1;
            this.txtNomeCurso.TabStop = false;
            this.txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(375, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 106;
            this.metroLabel2.Text = "Valor total (*)";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroTabControl3
            // 
            this.metroTabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl3.Controls.Add(this.metroTabPage7);
            this.metroTabControl3.Location = new System.Drawing.Point(139, 126);
            this.metroTabControl3.Name = "metroTabControl3";
            this.metroTabControl3.SelectedIndex = 0;
            this.metroTabControl3.Size = new System.Drawing.Size(588, 158);
            this.metroTabControl3.TabIndex = 41;
            this.metroTabControl3.UseSelectable = true;
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
            this.pictureBoxLogo.Size = new System.Drawing.Size(740, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(477, 283);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(246, 18);
            this.bunifuCustomLabel1.TabIndex = 50;
            this.bunifuCustomLabel1.Text = "Campos contendo (*) são obrigatórios";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 610);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.DataGridCurso);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.metroTabControl3);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cursos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.TopMost = true;
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.metroTabPage7.ResumeLayout(false);
            this.metroTabPage7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCurso;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
        private MetroFramework.Controls.MetroGrid DataGridCurso;
        private Bunifu.Framework.UI.BunifuFlatButton btnInserir;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        private MetroFramework.Controls.MetroTabControl metroTabControl3;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtValorCurso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDuracaoCurso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeCurso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox rtDescricaoCurso;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}