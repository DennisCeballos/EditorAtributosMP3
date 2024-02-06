using AtributosBE;
using EditorAtributos;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;


namespace AtributosUI
{
    public partial class frmAdminArchivos : Form
    {

        /*
         * DIRECCIONES DE PRUEBA YO
         * D:\Musica Publica\COMPILADOGLOBAL\LIMPIo
         * C:\Users\daceb\Music\4K YouTube to MP3
         * */

        private readonly List<ArchivoCancion> lstCanciones;
        private readonly string direccionArchivos;
        
        private Queue<string> colaArchivosEditar;

        public frmAdminArchivos()
        {
            InitializeComponent();

            lstCanciones = new List<ArchivoCancion>();
            colaArchivosEditar = new Queue<string>();

            //Definir el directorio de archivos a partir de los "Settings" del programa
            direccionArchivos = EditorAtributos.Properties.Settings.Default.PathDirectorioCanciones;
        }

        private void frmAdminArchivos_Load(object sender, EventArgs e)
        {

            RellenarDatosTabla();

            dgvSongData.ColumnCount = 5;
            dgvSongData.Columns[0].Name = "Path";
            dgvSongData.Columns[1].Name = "NombreArchivo";
            dgvSongData.Columns[2].Name = "Titulo";
            dgvSongData.Columns[3].Name = "Artista";
            dgvSongData.Columns[4].Name = "Album";

        }

        private void ObtenerDataCanciones()
        {
            //Obtener datos del directorio y guardarlos en una lista
            lstCanciones.Clear();

            //Bucle que recorre cada archivo en el directorio
            foreach (string filePath in Directory.EnumerateFiles(direccionArchivos, "*.mp3"))
            {
                //Crear temporales de un objCancion que recolecta las propiedades espcificas
                var cancionTemp = new ArchivoCancion(filePath);

                //Agregar la cancion a la lista completa
                lstCanciones.Add(cancionTemp);
            }

        }


        //Rellenar la tabla con los elementos de la lista
        private void RellenarDatosTabla()
        {
            ObtenerDataCanciones(); //Actualizar la lista con los datos del directorio
            dgvSongData.Rows.Clear();

            //Para cada elemento de la lista se agrega a la tabla
            foreach (ArchivoCancion item in lstCanciones)
            {
                string[] filaDatos = { item.Direccion,
                                       item.Nombre,
                                       item.Titulo,
                                       string.Join("; ", item.Artista),
                                       item.Album};
                dgvSongData.Rows.Add(filaDatos);
            }
        }

        private void CambiarFilaTabla(int indexEditado)
        {
            string pathEditado = dgvSongData.Rows[indexEditado].Cells[0].Value.ToString();
            mostrarFeedback("Se esta poniendo como pathEditado a " + pathEditado);

            ArchivoCancion cancionEditada = lstCanciones[lstCanciones.FindIndex(x => x.Direccion.Equals(pathEditado))];
            cancionEditada.RefrescarDatos();

            dgvSongData.Rows.RemoveAt(indexEditado); //Elimina la cancion en ese lugar
            dgvSongData.Rows.Insert(indexEditado, new string[] { cancionEditada.Direccion,
                                                                 cancionEditada.Nombre,
                                                                 cancionEditada.Titulo,
                                                                 string.Join("; ", cancionEditada.Artista),
                                                                 cancionEditada.Album}); //Agrega los nuevos datos de la cancion en la posicion eliminada
        }

        private void dgvSongData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BucleEditarArchivos();
            //MessageBox.Show(dgvSongData.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSongData.SelectedRows.Count == 1)
            {
                BucleEditarArchivos();
            }
            else
            {
                mostrarFeedbackError("Para este boton solo puedes seleccionar una cancion para editar");
                return;
            }

        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            BucleEditarArchivos();
        }

        private void BucleEditarArchivos()
        {
            //Se crea una lista que se recorrera para editar todos los archivos
            Queue<int> indicesEditados = new Queue<int>();
            foreach (DataGridViewRow row in dgvSongData.SelectedRows)
            {
                colaArchivosEditar.Enqueue(row.Cells[0].Value.ToString());
                indicesEditados.Enqueue(row.Index);
            }

            colaArchivosEditar.Reverse(); //Por default la seleccion del componente dataGridView es en el orden inverso

            frmEditorPropiedades formPropiedadesActual;
            int indiceEditadoActual;

            //Crear un bucle con la cola de archivos seleccionados
            while (colaArchivosEditar.Count > 0)
            {
                formPropiedadesActual = new frmEditorPropiedades(colaArchivosEditar.Dequeue());
                indiceEditadoActual = indicesEditados.Dequeue();
                formPropiedadesActual.ShowDialog(this);
                formPropiedadesActual.Dispose();
                if (formPropiedadesActual.lastBotonApretadoCierre == frmEditorPropiedades.BOTON_ACEPTAR) //Si hubo un cambio hay que cambiar la fila en la tabla main
                {
                    CambiarFilaTabla(indiceEditadoActual);
                }

                //Si se apreto el boton de salir en el form, que se vacie la cola de archivos
                if (formPropiedadesActual.lastBotonApretadoCierre == frmEditorPropiedades.BOTON_SALIR)
                {
                    colaArchivosEditar.Clear();
                    indicesEditados.Clear();
                }
            }
        }


        //Ambas funciones cambian el texto de la parte inferior del form, que sirven como feedback del proceso
        private void mostrarFeedback(string msg)
        {
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Text = msg;
        }
        private void mostrarFeedbackError(string msg)
        {
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Text = msg;
        }
        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            mostrarFeedback("Edita la cancion seleccionada actualmente en la tabla");
        }

        private void btnColar_MouseEnter(object sender, EventArgs e)
        {
            mostrarFeedback("Crea una seccuencia para editar todas las canciones que esten seleccionadas actualmente en la tabla");
        }

        private void sugerenciaDeAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSugerenciaAutores = new frmListaSugerenciaAutores();
            frmSugerenciaAutores.ShowDialog();
            frmSugerenciaAutores.Dispose();
        }

        private void direccionDeArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar el directorio actual
            string actual = EditorAtributos.Properties.Settings.Default.PathDirectorioCanciones;

            var frmCambiarDireccionArchivos = new frmCambioDirectorio();
            frmCambiarDireccionArchivos.ShowDialog();

            //Si es diferente, implica que se cambio el directorio
            if (actual != EditorAtributos.Properties.Settings.Default.PathDirectorioCanciones)
            {
                Application.Restart();
                Environment.Exit(0); //Con esto se especifica que fue un "clean shutdown"
            }

        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
