using AtributosBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorAtributis
{
    public partial class frmDirectorio : Form
    {
        string? direccionArchivos;

        public frmDirectorio()
        {
            InitializeComponent();
        }

        private void frmEmergencia_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //Bucle que recorre cada archivo en el directorio
            foreach (string filePath in Directory.EnumerateFiles(direccionArchivos, "*.mp3"))
            {
                //Crear temporales de un objCancion que recolecta las propiedades espcificas
                var cancionTemp = new ArchivoCancion(filePath);

                //Agregar la cancion a la lista completa
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            direccionArchivos = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
