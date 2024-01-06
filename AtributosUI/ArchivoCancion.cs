using AtributosUI;
using Microsoft.WindowsAPICodePack.Shell;
using System.Diagnostics;

namespace AtributosBE
{
    public class ArchivoCancion
    {
        public string? Direccion { get; set; }
        public string? Nombre { get; set; }
        public string? Titulo { get; set; }
        public string[]? Artista { get; set; }
        public string? Album { get; set; }

        public ArchivoCancion() { }

        public ArchivoCancion(string direccion)
        {
            Direccion = direccion;
            RefrescarDatos();
        }

        public ArchivoCancion(string direccion, string nombre, string titulo, string[] artista, string album)
        {
            Direccion = direccion;
            Nombre    = nombre;
            Titulo    = titulo;
            Artista   = artista;
            Album     = album;
        }

        public ArchivoCancion(ArchivoCancion _nueva)
        {
            Direccion = _nueva.Direccion;
            Nombre    = _nueva.Nombre;
            Titulo    = _nueva.Titulo;
            Artista   = _nueva.Artista;
            Album     = _nueva.Album;
        }

        //Reemplaza los datos actuales del objeto con las propiedades del archivo en su direccion
        public void RefrescarDatos()
        {
            var archivoProperties = ShellFile.FromFilePath(Direccion);
            Nombre = archivoProperties.Properties.System.FileName.Value;
            Titulo = archivoProperties.Properties.System.Title.Value;
            try
            {
                Artista = archivoProperties.Properties.System.Music.Artist.Value.ToArray();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                Artista = new string[] { "" };
            }
            Album = archivoProperties.Properties.System.Music.AlbumTitle.Value;
        }

        public string DataDebug()
        {
            string msg = "Objeto ArchivoCancion con datos:" + "\n" +
                         "Direccion  >" + Direccion         + "\n" +
                         "Nombre     >" + Nombre            + "\n" +
                         "Titulo     >" + Titulo            + "\n" +
                         "Artista(s) >" + string.Join("; ", Artista) + "\n" +
                         "Album      >" + Album             + "\n" ;
            return msg;       
        }

        //Funcion para cambiar los datos del archivo actual
        public void cambiarDatos(string _titulo, string[] _artista, string _album)
        {
            ArchivoCancion cancionRepuesto = new ArchivoCancion(this);
            try
            {
                var archivoProperties = ShellFile.FromFilePath(Direccion);

                archivoProperties.Properties.System.Title.Value            = _titulo;
                archivoProperties.Properties.System.Music.Artist.Value     = _artista;
                archivoProperties.Properties.System.Music.AlbumTitle.Value = _album;

                //Devolver todos los datos a la normalidad
                Direccion = cancionRepuesto.Direccion;
                Nombre    = cancionRepuesto.Nombre;
                Titulo    = cancionRepuesto.Titulo;
                Artista   = cancionRepuesto.Artista;
                Album     = cancionRepuesto.Album;

            }
            catch (Exception ex)
            {
                
                throw ex;
                
            }
        }
    }
}