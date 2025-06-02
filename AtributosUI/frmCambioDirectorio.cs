using AtributosBE;
using AtributosUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EditorAtributos
{
    public partial class frmCambioDirectorio : Form
    {

        public frmCambioDirectorio()
        {
            InitializeComponent();
        }


        private void frmEmergencia_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.PathDirectorioCanciones;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //Si es valida la direccion ingresada
            if (Utils.RevisarDireccionPathValida(textBox1.Text))
            {
                //Cambiar la variable de entorno
                Properties.Settings.Default.PathDirectorioCanciones = textBox1.Text;
                //Properties.Settings.Default.Save(); //Para que los cambios persistan hasta depsues de cerrar la app
                this.Close();
            }
            else
            {
                labelError.Visible = true;
            }

        }
        private void botonCierre(object sender, FormClosingEventArgs e)
        {
            
            //Si es valida la direccion del directorio de canciones
            if (Utils.RevisarDireccionPathValida(Properties.Settings.Default.PathDirectorioCanciones))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                labelError.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
