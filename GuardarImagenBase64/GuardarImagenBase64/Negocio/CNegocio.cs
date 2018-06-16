using GuardarImagenBase64.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardarImagenBase64.Negocio
{
    class CNegocio
    {
        CConexionPg postgres;

        public CNegocio()
        {
            postgres = new CConexionPg();
        }

        /// <summary>
        /// Convierte una imagen en arreglo de bytes
        /// </summary>
        /// <param name="path">Ruta de la imagen</param>
        /// <returns>La imagen convertida en arreglo de bytes</returns>
        public byte[] ObtieneImagenEnArregloBytes(string path)
        {
            Image imagen = Image.FromFile(path);
            using (var ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.GetBuffer();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreImagen"></param>
        /// <param name="extension"></param>
        /// <param name="imagenEnBytes"></param>
        /// <returns></returns>
        public int GuardarImagenArregloBytes(string nombreImagen, byte[] imagenEnBytes)
        {
            return postgres.GuardaImagenBytesPosgres(nombreImagen, imagenEnBytes);
        }

        public DataTable LlenaComboNombresImagenes()
        {
            return postgres.Consulta("SELECT id,nom_imagen FROM ctl_imagenesBytes");
        }

        public Image DescargaImagen(int id)
        {
            var imagenEnBytes = postgres.ConsultaEscalarArregloBytes(string.Format("SELECT arr_bytes FROM ctl_imagenesBytes WHERE id = {0}",id));
            MemoryStream ms = new MemoryStream(imagenEnBytes);
            Image devolverImagen = Image.FromStream(ms);
            return devolverImagen;
        }

        public Image CambiarTamanoImagen(Image pImagen, int pAncho, int pAlto)
	    {
	        //creamos un bitmap con el nuevo tamaño
	        Bitmap vBitmap = new Bitmap(pAncho, pAlto);
	        //creamos un graphics tomando como base el nuevo Bitmap
	        using (Graphics vGraphics = Graphics.FromImage((Image)vBitmap))
	        {
	            //especificamos el tipo de transformación, se escoge esta para no perder calidad.
	            vGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
	            //Se dibuja la nueva imagen
	            vGraphics.DrawImage(pImagen, 0, 0, pAncho, pAlto);
	        }
	        //retornamos la nueva imagen
	        return (Image)vBitmap;
	    }
    }
}
