namespace AtributosUI
{
    partial class frmAdminArchivos
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
            dgvSongData = new DataGridView();
            fPath = new DataGridViewTextBoxColumn();
            fName = new DataGridViewTextBoxColumn();
            fTittle = new DataGridViewTextBoxColumn();
            fArtist = new DataGridViewTextBoxColumn();
            fAlbum = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnColar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTituloForm = new Label();
            menuStrip1 = new MenuStrip();
            configurarToolStripMenuItem = new ToolStripMenuItem();
            sugerenciaDeAutoresToolStripMenuItem = new ToolStripMenuItem();
            direccionDeArchivosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvSongData).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSongData
            // 
            dgvSongData.AllowUserToAddRows = false;
            dgvSongData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongData.Columns.AddRange(new DataGridViewColumn[] { fPath, fName, fTittle, fArtist, fAlbum });
            dgvSongData.Location = new Point(50, 99);
            dgvSongData.Name = "dgvSongData";
            dgvSongData.ReadOnly = true;
            dgvSongData.RowTemplate.Height = 27;
            dgvSongData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSongData.Size = new Size(900, 331);
            dgvSongData.TabIndex = 0;
            dgvSongData.CellContentDoubleClick += dgvSongData_CellContentDoubleClick;
            // 
            // fPath
            // 
            fPath.HeaderText = "Direccion Archivo";
            fPath.Name = "fPath";
            fPath.ReadOnly = true;
            fPath.Width = 400;
            // 
            // fName
            // 
            fName.HeaderText = "Nombre";
            fName.Name = "fName";
            fName.ReadOnly = true;
            fName.Width = 127;
            // 
            // fTittle
            // 
            fTittle.HeaderText = "Titulo";
            fTittle.Name = "fTittle";
            fTittle.ReadOnly = true;
            fTittle.Width = 130;
            // 
            // fArtist
            // 
            fArtist.HeaderText = "Artista";
            fArtist.Name = "fArtist";
            fArtist.ReadOnly = true;
            // 
            // fAlbum
            // 
            fAlbum.HeaderText = "Album";
            fAlbum.Name = "fAlbum";
            fAlbum.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(671, 467);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 45);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            btnEditar.MouseEnter += btnEditar_MouseEnter;
            // 
            // btnColar
            // 
            btnColar.Location = new Point(832, 467);
            btnColar.Name = "btnColar";
            btnColar.Size = new Size(120, 45);
            btnColar.TabIndex = 2;
            btnColar.Text = "Iniciar Cola";
            btnColar.UseVisualStyleBackColor = true;
            btnColar.Click += btnColar_Click;
            btnColar.MouseEnter += btnColar_MouseEnter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 534);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1016, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(183, 21);
            toolStripStatusLabel1.Text = "ComentariosImportantes";
            toolStripStatusLabel1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTituloForm.Location = new Point(50, 47);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(279, 37);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Editor de Propiedades";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configurarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1016, 25);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // configurarToolStripMenuItem
            // 
            configurarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sugerenciaDeAutoresToolStripMenuItem, direccionDeArchivosToolStripMenuItem });
            configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            configurarToolStripMenuItem.Size = new Size(82, 21);
            configurarToolStripMenuItem.Text = "Configurar";
            configurarToolStripMenuItem.Click += configurarToolStripMenuItem_Click;
            // 
            // sugerenciaDeAutoresToolStripMenuItem
            // 
            sugerenciaDeAutoresToolStripMenuItem.Name = "sugerenciaDeAutoresToolStripMenuItem";
            sugerenciaDeAutoresToolStripMenuItem.Size = new Size(255, 22);
            sugerenciaDeAutoresToolStripMenuItem.Text = "Sugerencia de Autores";
            sugerenciaDeAutoresToolStripMenuItem.Click += sugerenciaDeAutoresToolStripMenuItem_Click;
            // 
            // direccionDeArchivosToolStripMenuItem
            // 
            direccionDeArchivosToolStripMenuItem.Name = "direccionDeArchivosToolStripMenuItem";
            direccionDeArchivosToolStripMenuItem.Size = new Size(255, 22);
            direccionDeArchivosToolStripMenuItem.Text = "Cambiar Direccion de Archivos";
            direccionDeArchivosToolStripMenuItem.Click += direccionDeArchivosToolStripMenuItem_Click;
            // 
            // frmAdminArchivos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 560);
            Controls.Add(lblTituloForm);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(btnColar);
            Controls.Add(btnEditar);
            Controls.Add(dgvSongData);
            MainMenuStrip = menuStrip1;
            Name = "frmAdminArchivos";
            Text = "Form EditorAtributosMP3";
            Load += frmAdminArchivos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSongData).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSongData;
        private Button btnEditar;
        private Button btnColar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label lblTituloForm;
        private DataGridViewTextBoxColumn fPath;
        private DataGridViewTextBoxColumn fName;
        private DataGridViewTextBoxColumn fTittle;
        private DataGridViewTextBoxColumn fArtist;
        private DataGridViewTextBoxColumn fAlbum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configurarToolStripMenuItem;
        private ToolStripMenuItem sugerenciaDeAutoresToolStripMenuItem;
        private ToolStripMenuItem direccionDeArchivosToolStripMenuItem;
    }
}