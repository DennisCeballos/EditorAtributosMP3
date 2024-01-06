namespace EditorAtributis
{
    partial class frmDirectorio
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
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            btnEjecutar = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 0;
            label1.Text = "Direccion de la carpeta";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 154);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(624, 23);
            progressBar1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(564, 35);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(90, 74);
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
            label2.Click += label2_Click;
            // 
            // frmEmergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 231);
            Controls.Add(label2);
            Controls.Add(btnEjecutar);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "frmEmergencia";
            Text = "Form de EMERGENCIA";
            Load += frmEmergencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button btnEjecutar;
        private Label label2;
        private ToolTip toolTip1;
    }
}