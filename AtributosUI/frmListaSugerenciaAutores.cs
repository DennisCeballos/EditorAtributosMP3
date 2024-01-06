using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtributosUI
{
    public partial class frmListaSugerenciaAutores : Form
    {

        private List<string> listaArtistas;

        public frmListaSugerenciaAutores()
        {
            InitializeComponent();
            listaArtistas = Utils.LeerArchivoArtistas();
        }

        private void frmListaSugerenciaAutores_Load(object sender, EventArgs e)
        {
            //Rellenar el textBox con los artistas de la lista
            foreach (string item in listaArtistas)
            {
                tbListaSugerencias.AppendText(item);
                tbListaSugerencias.AppendText(Environment.NewLine);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<string> nuevaLista = new List<string>();
            nuevaLista.AddRange(tbListaSugerencias.Text.Split(Environment.NewLine));
            nuevaLista.RemoveAll(x => x.Equals("") || x.Equals(Environment.NewLine));

            Utils.GuardarArchivoArtistas(nuevaLista);
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada autor, separado por lineas, sera recomendado cuando ingreses autores al editar un archivo.", "Lista de sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
