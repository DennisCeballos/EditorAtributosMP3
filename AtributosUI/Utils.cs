using AtributosBE;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AtributosUI
{
    public static class Utils
    {

        //Guarda todos los datos de la cancion en
        public static void CambiarPropiedadesArchivo(ArchivoCancion objCancion)
        {
            try
            {
                var archivoProperties = ShellFile.FromFilePath(objCancion.Direccion);

                archivoProperties.Properties.System.Title.Value            = objCancion.Titulo;
                archivoProperties.Properties.System.Music.Artist.Value     = objCancion.Artista;
                archivoProperties.Properties.System.Music.AlbumTitle.Value = objCancion.Album;


            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        //Guarda la lista de strings en el archivo binario de los artistas
        public static void GuardarArchivoArtistas(List<string> listaArtistas)
        {
            //path del archivo
            string archivoBinario = EditorAtributos.Properties.Settings.Default.ArchivoBinarioArtistas;

            //Crear un BinaryFormatter para escribir en binario
            BinaryFormatter formatter = new BinaryFormatter(); //Lol esto me ayudo chatGPT

            //Se guardan los datos de la lista de artistas en un archivo binario
            using (FileStream stream = new FileStream(archivoBinario, FileMode.Create))
            {
                formatter.Serialize(stream, listaArtistas);
            }

            //
            //Lineas Debug
            //
            /*
            Debug.WriteLine("------\nSe esta guardando al binario:");
            foreach (var item in listaArtistas)
            {
                Debug.WriteLine(item.ToString());
            }
            Debug.WriteLine("------\n");
            */
        }


        //Lee la lista de strings que hay en el archivo binario de los artistas
        public static List<string> LeerArchivoArtistas()
        {
            //path del archivo
            string archivoBinario = EditorAtributos.Properties.Settings.Default.ArchivoBinarioArtistas;

            BinaryFormatter formatter = new BinaryFormatter(); //Lol esto me ayudo chatGPT
            List<string> listaDatos = new List<string>();

            if (File.Exists(archivoBinario))
            {
                //CURIOSO: usar la palabra using asegura que se abre y cierre el archivo correctamente (fuente: El mismo ChatGPT XD)
                using (FileStream stream = new FileStream(archivoBinario, FileMode.Open))
                {
                    if (stream.Length > 0)
                    {
                        listaDatos = (List<string>)formatter.Deserialize(stream);
                    }
                }
            }


            //
            //Lineas Debug
            //
            
            Debug.WriteLine("------\nSe esta leyendo del binario:");
            foreach (var item in listaDatos)
            {
                Debug.WriteLine(item.ToString());
            }
            Debug.WriteLine("------\n");
            
            return listaDatos;
        }

    }
}
