namespace AtributosUI
{
    partial class frmListaSugerenciaAutores
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
            btnAceptar = new Button();
            tbListaSugerencias = new TextBox();
            btnAyuda = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(92, 382);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 60);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tbListaSugerencias
            // 
            tbListaSugerencias.Location = new Point(24, 76);
            tbListaSugerencias.Multiline = true;
            tbListaSugerencias.Name = "tbListaSugerencias";
            tbListaSugerencias.ScrollBars = ScrollBars.Vertical;
            tbListaSugerencias.Size = new Size(250, 280);
            tbListaSugerencias.TabIndex = 1;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(235, 33);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(39, 23);
            btnAyuda.TabIndex = 2;
            btnAyuda.Text = "?";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(24, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 17);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Lista de sugerencias para autores";
            // 
            // frmListaSugerenciaAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 473);
            Controls.Add(lblTitulo);
            Controls.Add(btnAyuda);
            Controls.Add(tbListaSugerencias);
            Controls.Add(btnAceptar);
            Name = "frmListaSugerenciaAutores";
            Text = "frmListaSugerenciaAutores";
            Load += frmListaSugerenciaAutores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox tbListaSugerencias;
        private Button btnAyuda;
        private Label lblTitulo;
    }
}