using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ConvertIMG
{
    class Imagen
    {
        private string nombre;
        private string rutaSalida = @"C:\ConvertIMG\";
        private Image imagen;

        public Imagen(string ruta, string nombre)
        {
            this.nombre = nombre;
            imagen = Image.FromFile(@ruta);
        }

        public void Convetir(string nuevoFormato)
        {
            Directory.CreateDirectory(rutaSalida);

            switch (nuevoFormato)
            {
                case "jpg":
                    imagen.Save(rutaSalida + nombre + "." + nuevoFormato, ImageFormat.Jpeg);
                    break;
                case "png":
                    imagen.Save(rutaSalida+nombre+"."+nuevoFormato, ImageFormat.Png);
                    break;
                case "gif":
                    imagen.Save(rutaSalida + nombre + "." + nuevoFormato, ImageFormat.Gif);
                    break;
                case "bmp":
                    imagen.Save(rutaSalida + nombre + "." + nuevoFormato, ImageFormat.Bmp);
                    break;
            }
            


        }

    }
}
