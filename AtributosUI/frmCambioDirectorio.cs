using AtributosBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorAtributis
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

            //Si el checbox es diferente de vacio
            if (textBox1.Text != "")
            {
                //Cambiar la variable de entorno
                Properties.Settings.Default.PathDirectorioCanciones = textBox1.Text;
                Properties.Settings.Default.Save(); //Para que los cambios persistan hasta depsues de cerrar la app
            }
            this.Close();

            /*
            //Bucle que recorre cada archivo en el directorio
            foreach (string filePath in Directory.EnumerateFiles(direccionArchivos, "*.mp3"))
            {
                //Crear temporales de un objCancion que recolecta las propiedades espcificas
                var cancionTemp = new ArchivoCancion(filePath);

                //Agregar la cancion a la lista completa
            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
