namespace AtributosUI
{
    partial class frmEditorPropiedades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBIcono = new PictureBox();
            btnCancelar = new Button();
            btnSalir = new Button();
            btnAceptar = new Button();
            lblFileName = new Label();
            lblPropiedades = new Label();
            lblTitle = new Label();
            tbTitle = new TextBox();
            tbArtist = new TextBox();
            lblArtista = new Label();
            tbAlbum = new TextBox();
            lblAlbum = new Label();
            lblAdvertencia = new Label();
            listBoxDebug = new ListBox();
            lblAutores = new Label();
            btnAumentar = new Button();
            ((System.ComponentModel.ISupportInitialize)picBIcono).BeginInit();
            SuspendLayout();
            // 
            // picBIcono
            // 
            picBIcono.BackgroundImage = EditorAtributos.Properties.Resources.imagenDemp3;
            picBIcono.BackgroundImageLayout = ImageLayout.Center;
            picBIcono.Location = new Point(35, 36);
            picBIcono.Name = "picBIcono";
            picBIcono.Size = new Size(170, 230);
            picBIcono.SizeMode = PictureBoxSizeMode.CenterImage;
            picBIcono.TabIndex = 0;
            picBIcono.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(43, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(249, 297);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir Cola";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(451, 297);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 50);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar/Seguir";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblFileName
            // 
            lblFileName.BackColor = SystemColors.ButtonShadow;
            lblFileName.BorderStyle = BorderStyle.Fixed3D;
            lblFileName.ForeColor = SystemColors.ActiveCaptionText;
            lblFileName.Location = new Point(235, 36);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(332, 30);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Nombre Archivo.extension";
            lblFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.Location = new Point(235, 82);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(82, 17);
            lblPropiedades.TabIndex = 5;
            lblPropiedades.Text = "Propiedades";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(274, 117);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 17);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Titulo:";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            lblTitle.Click += label1_Click;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(345, 109);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(222, 25);
            tbTitle.TabIndex = 0;
            tbTitle.TextChanged += tbTitle_TextChanged;
            // 
            // tbArtist
            // 
            tbArtist.Location = new Point(345, 159);
            tbArtist.Name = "tbArtist";
            tbArtist.Size = new Size(222, 25);
            tbArtist.TabIndex = 1;
            tbArtist.TextChanged += tbArtist_TextChanged;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.Location = new Point(269, 167);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(48, 17);
            lblArtista.TabIndex = 8;
            lblArtista.Text = "Artista:";
            lblArtista.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbAlbum
            // 
            tbAlbum.Location = new Point(345, 205);
            tbAlbum.Name = "tbAlbum";
            tbAlbum.Size = new Size(222, 25);
            tbAlbum.TabIndex = 2;
            tbAlbum.TextChanged += tbAlbum_TextChanged;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(269, 213);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(48, 17);
            lblAlbum.TabIndex = 10;
            lblAlbum.Text = "Album:";
            lblAlbum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.ForeColor = Color.Red;
            lblAdvertencia.Location = new Point(440, 277);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(161, 17);
            lblAdvertencia.TabIndex = 14;
            lblAdvertencia.Text = "Se guardaran los cambios";
            lblAdvertencia.Visible = false;
            // 
            // listBoxDebug
            // 
            listBoxDebug.FormattingEnabled = true;
            listBoxDebug.ItemHeight = 17;
            listBoxDebug.Location = new Point(655, 86);
            listBoxDebug.Name = "listBoxDebug";
            listBoxDebug.Size = new Size(202, 208);
            listBoxDebug.TabIndex = 15;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.Location = new Point(655, 66);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(210, 17);
            lblAutores.TabIndex = 16;
            lblAutores.Text = "Autores anteriormente agregados:";
            // 
            // btnAumentar
            // 
            btnAumentar.Location = new Point(885, 3);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(15, 375);
            btnAumentar.TabIndex = 17;
            btnAumentar.Text = "<";
            btnAumentar.UseVisualStyleBackColor = true;
            btnAumentar.Click += btnAumentar_Click;
            // 
            // frmEditorPropiedades
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 381);
            Controls.Add(btnAumentar);
            Controls.Add(lblAutores);
            Controls.Add(listBoxDebug);
            Controls.Add(lblAdvertencia);
            Controls.Add(tbAlbum);
            Controls.Add(lblAlbum);
            Controls.Add(tbArtist);
            Controls.Add(lblArtista);
            Controls.Add(tbTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblPropiedades);
            Controls.Add(lblFileName);
            Controls.Add(btnAceptar);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(picBIcono);
            KeyPreview = true;
            Name = "frmEditorPropiedades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Propiedades";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBIcono;
        private Button btnCancelar;
        private Button btnSalir;
        private Button btnAceptar;
        private Label lblFileName;
        private Label lblPropiedades;
        private Label lblTitle;
        private TextBox tbTitle;
        private TextBox tbArtist;
        private Label lblArtista;
        private TextBox tbAlbum;
        private Label lblAlbum;
        private Label lblAdvertencia;
        private ListBox listBoxDebug;
        private Label lblAutores;
        private Button btnAumentar;
    }
}