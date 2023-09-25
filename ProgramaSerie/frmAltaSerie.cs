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
using dominio;
using Service;
using System.Configuration;

namespace ProgramaSerie
{
    public partial class frmAltaSerie : Form
    {   
        private Serie Serie = null;
        private OpenFileDialog archivo = null;
        public frmAltaSerie()
        {
            InitializeComponent();
        }
        public frmAltaSerie(Serie serie)
        {
            InitializeComponent();
            this.Serie = serie;
            Text = "Modificar Serie";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            SerieService service = new SerieService();
            //ServiceTemporada serviceTemporada = new ServiceTemporada();
            try
            {
                if (txtbNombre.Text != "")
                {   
                    if (Serie == null)
                        Serie = new Serie();

                    Serie.Nombre = txtbNombre.Text;
                    Serie.Descripcion = txtbDescripcion.Text;
                    Serie.FechaDeEstreno = dtpEstreno.Value;
                    Serie.Genero = (Genero)cboGenero.SelectedItem;
                    Serie.ImagenUrl = txtbUrlImagen.Text;

                    //Temporada temporada = new Temporada();

                    //temporada.Nombre = txtbTemporadas.Text;
                    //temporada.Capitulos = int.Parse(txtbCapitulosTotales.Text);

                    if(Serie.Id != 0)
                    {
                        service.modificar(Serie);
                        MessageBox.Show("Serie modificada exitosamente.");
                    }
                    else
                    {
                        service.agregar(Serie);
                        MessageBox.Show("Serie agregada exitosamente.");
                    }

                    if (archivo != null && !(txtbUrlImagen.Text.ToUpper().Contains("HTTP")))
                    {
                        string rutaOrigen = archivo.FileName; // Ruta del archivo de origen
                        string carpetaDestino = ConfigurationManager.AppSettings["ImagesFolder"]; // Carpeta de destino
                        string nombreArchivoOriginal = Path.GetFileName(rutaOrigen); // Nombre del archivo original
                        string extension = Path.GetExtension(nombreArchivoOriginal);

                        // Construir un nuevo nombre de archivo basado en ciertos parámetros
                        string nuevoNombreArchivo = $"Archivo_{DateTime.Now:yyyyMMddHHmmss}{extension}";

                        // Combinar la carpeta de destino con el nuevo nombre de archivo
                        string rutaDestino = Path.Combine(carpetaDestino, nuevoNombreArchivo);

                        // Copiar el archivo con el nuevo nombre
                        File.Copy(rutaOrigen, rutaDestino);
                    }
                    //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ImagesFolder"] + archivo.SafeFileName);

                    Close();
                }
                else
                    MessageBox.Show("Ingrese un Nombre, por favor.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmAltaSerie_Load(object sender, EventArgs e)
        {
            ServiceGenero serviceGenero = new ServiceGenero();
            try
            {
                cboGenero.DataSource = serviceGenero.listar();
                cboGenero.ValueMember = "Id";
                cboGenero.DisplayMember = "Nombre";
                
                if(Serie != null)
                {
                    txtbNombre.Text = Serie.Nombre;
                    txtbDescripcion.Text = Serie.Descripcion;
                    dtpEstreno.Value = Serie.FechaDeEstreno;
                    cboGenero.SelectedValue = Serie.Genero.Id;
                    //txtbTemporadas.Text = Serie.Temporada.Nombre;
                    //txtbCapitulosTotales.Text = Serie.Temporada.Capitulos.ToString();
                    txtbUrlImagen.Text = Serie.ImagenUrl;
                    cargarImagen(Serie.ImagenUrl);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbSerie.Load(imagen);
            }
            catch (Exception)
            {
                pcbSerie.Load("https://filetandvine.com/wp-content/uploads/2015/10/pix-vertical-placeholder.jpg");
            }
        }

        private void txtbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbUrlImagen.Text);
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                
            }
        }

        private void txtbTemporadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtbCapitulosTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
