using GuardarImagenBase64.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardarImagenBase64
{
    public partial class Form1 : Form
    {
        CNegocio logica;

        //Variables globales
        byte[] imagenBytes;

        public Form1()
        {
            InitializeComponent();
            logica = new CNegocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNombresImagenes.DataSource = logica.LlenaComboNombresImagenes();
            cbNombresImagenes.DisplayMember = "nom_imagen";
            cbNombresImagenes.ValueMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.ShowDialog();

            if (!string.IsNullOrWhiteSpace(dialog.SafeFileName))
            {
                txtNombreImagen.Text = dialog.SafeFileName;
                txtRutaImagen.Text = dialog.InitialDirectory;                

                //Tomando la imagen
                this.imagenBytes = logica.ObtieneImagenEnArregloBytes(dialog.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int registros = 0;
            if (this.imagenBytes != null)
            {
                try
                {
                    registros = logica.GuardarImagenArregloBytes(txtNombreImagen.Text, this.imagenBytes);

                    if (registros > 0)
                    {
                        MessageBox.Show("Se guardo correctamente la imagen en la BD", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se guardo la imagen en la BD, favor de verificarlo con el administrador del sistema", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ocurrio un error al intentar guardar la imagen en la BD.\nMensaje de error: {0}", ex.Message), "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtNombreImagen.Text = "";
                    txtRutaImagen.Text = "";
                    this.imagenBytes = null;
                } 
            }
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rutaDestino = new FolderBrowserDialog();
            rutaDestino.RootFolder = Environment.SpecialFolder.Desktop;
            rutaDestino.ShowDialog();

            if (!string.IsNullOrWhiteSpace(rutaDestino.SelectedPath))
            {
                txtRutaDescarga.Text = rutaDestino.SelectedPath;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRutaDescarga.Text))
            {
                try
                {
                    var imagen = logica.DescargaImagen(Convert.ToInt32(cbNombresImagenes.SelectedValue));
                    imagen.Save(Path.Combine(txtRutaDescarga.Text, cbNombresImagenes.Text));
                    MessageBox.Show("Se Genero la imagen correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar generar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControlImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlImagenes.SelectedIndex == 1)
	        {
		        cbNombresImagenes.DataSource = logica.LlenaComboNombresImagenes();
                cbNombresImagenes.DisplayMember = "nom_imagen";
                cbNombresImagenes.ValueMember = "id";
                this.Height = 190;
                this.Width = 475;
                this.MaximizeBox = false;
            }
            else if (this.tabControlImagenes.SelectedIndex == 2)
            {
                Image imagen = logica.DescargaImagen(Convert.ToInt32(cbNombresImagenes.SelectedValue));
                do
                {
                    if (imagen.Height > 700 || imagen.Width > 1200)
                    {
                        int alto = Convert.ToInt32(Math.Floor(imagen.Width * .50));
                        int ancho = Convert.ToInt32(Math.Floor(imagen.Width * .50));
                        imagen = logica.CambiarTamanoImagen(imagen, ancho, alto);
                    }
                } while (imagen.Height > 800 || imagen.Width > 1200);
                
                this.pictureBox1.Image = imagen;
                this.Height = pictureBox1.Image.Height;
                this.Width = pictureBox1.Image.Width;
                this.MaximizeBox = true;
            }
            else
            {
                this.Height = 190;
                this.Width = 475;
                this.MaximizeBox = false;
            }
        }  
    }
}
