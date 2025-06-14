﻿namespace EditorAtributos
{
    partial class frmCambioDirectorio
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            btnEjecutar = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(215, 17);
            label1.TabIndex = 0;
            label1.Text = "Direccion de carpeta con canciones";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 25);
            textBox1.TabIndex = 2;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(546, 35);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(97, 74);
            btnEjecutar.TabIndex = 3;
            btnEjecutar.Text = "Ejecutar Cambio";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(483, 35);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 4;
            label2.Text = "?";
            toolTip1.SetToolTip(label2, "Ingresa la direccion absoluta de la carpeta\r\nque se encuentre tus archivos.\r\nejem: C:\\Users\\YoUsuario\\Music");
            label2.Click += label2_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = SystemColors.Control;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(30, 127);
            labelError.Name = "labelError";
            labelError.Size = new Size(217, 17);
            labelError.TabIndex = 5;
            labelError.Text = "Debes ingresar una direccion valida";
            labelError.Visible = false;
            labelError.Click += label3_Click;
            // 
            // frmCambioDirectorio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 165);
            Controls.Add(labelError);
            Controls.Add(label2);
            Controls.Add(btnEjecutar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmCambioDirectorio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form cambio Directorio";
            FormClosing += botonCierre;
            Load += frmEmergencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnEjecutar;
        private Label label2;
        private ToolTip toolTip1;
        private Label labelError;
    }
}