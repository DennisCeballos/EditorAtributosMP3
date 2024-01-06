using AtributosBE;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Input;

namespace AtributosUI
{
    public partial class frmEditorPropiedades : Form
    {

        private string pathArchivo = @"C:\Users\daceb\Music\4K YouTube to MP3\505.mp3"; //Este esta aqui solo por razones de debug

        private readonly ArchivoCancion datosCancion;

        private AutoCompleteStringCollection lstSugerenciasAutor;

        public string lastBotonApretadoCierre = BOTON_DEFAULT;
        public static string BOTON_DEFAULT = "SalidaDefecto";
        public static string BOTON_CANCELAR = "btnCancelar";
        public static string BOTON_SALIR = "btnSalirCola";
        public static string BOTON_ACEPTAR = "btnAceptar/Seguir";

        public frmEditorPropiedades(string pathArchivo)
        {
            InitializeComponent();


            datosCancion = new ArchivoCancion(pathArchivo);

            lstSugerenciasAutor = new AutoCompleteStringCollection();
            lstSugerenciasAutor.AddRange(Utils.LeerArchivoArtistas().ToArray());
            listBoxDebug.Items.AddRange(Utils.LeerArchivoArtistas().ToArray()); //Por razones de DEBUG

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Rellenar los campos del form
            lblFileName.Text = datosCancion.Nombre;
            tbTitle.Text = datosCancion.Titulo;
            tbArtist.Text = string.Join(";", datosCancion.Artista);
            tbAlbum.Text = datosCancion.Album;

            //Desaparecer la advertencia
            lblAdvertencia.Visible = false;

            //Configuraciones del autocompletado de artistas
            tbArtist.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbArtist.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbArtist.AutoCompleteCustomSource = lstSugerenciasAutor;
        }


        private void label1_Click(object sender, EventArgs e) { }


        //Eventos que se ha cambiado algun dato
        private void tbTitle_TextChanged(object sender, EventArgs e) { eventCambioDatos(); }
        private void tbArtist_TextChanged(object sender, EventArgs e) { eventCambioDatos(); }
        private void tbAlbum_TextChanged(object sender, EventArgs e) { eventCambioDatos(); }
        public void eventCambioDatos()
        {
            lblAdvertencia.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!lblAdvertencia.Visible) { lastBotonApretadoCierre = BOTON_CANCELAR; this.Close(); return; } //Solo si hubo un cambio se ejecuta el codigo de guardado
            try
            {
                //Cambiar los datos del archivo
                datosCancion.cambiarDatos(tbTitle.Text, tbArtist.Text.Split(";"), tbAlbum.Text);
                lastBotonApretadoCierre = BOTON_ACEPTAR;

                //Guardar los datos de los artistas que se sugieren
                //Primero hay que agregar al nuevo artista si no esta en la lista
                string[] nuevoArtista = tbArtist.Text.Split(";");
                foreach (var item in nuevoArtista)
                {
                    if (!lstSugerenciasAutor.Contains(item) && item != "")
                    {
                        lstSugerenciasAutor.Add(item);
                    }
                }

                //Clase Utils que se encarga de guardar en el archivo Binario
                Utils.GuardarArchivoArtistas(lstSugerenciasAutor.Cast<string>().ToList());
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al cambiar el valor\n" + ex.ToString(), "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            lastBotonApretadoCierre = BOTON_SALIR;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            lastBotonApretadoCierre = BOTON_CANCELAR;
            this.Close();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {

            switch (this.Width)
            {
                case 915:
                    this.Size = new Size(680, this.Height);
                    btnAumentar.Text = ">";
                    break;

                case 680:
                    this.Size = new Size(915, this.Height);
                    btnAumentar.Text = "<";
                    break;

                default:
                    Debug.WriteLine("---------------\n>Hay un problema con el tamaño del form>\n---------------");
                    break;
            }

            btnAumentar.Location = new Point(this.Width - 30, btnAumentar.Location.Y);
        }
    }
}