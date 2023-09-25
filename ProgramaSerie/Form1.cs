using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Service;

namespace ProgramaSerie
{
    public partial class frmSeries : Form
    {
        private List<Serie> ListaSerie;
        public frmSeries()
        {
            InitializeComponent();
        }

        private void frmSeries_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Género");
            cboCampo.Items.Add("Año");
        }

        private void cargar()
        {
            SerieService service = new SerieService();
            try
            {
                ListaSerie = service.listar();
                dgvSeries.DataSource = ListaSerie;
                ocultarColumnas();
                cargarImagen(ListaSerie[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvSeries.Columns["ImagenUrl"].Visible = false;
            dgvSeries.Columns["Id"].Visible = false;           
        }

        private void dgvSeries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSeries.CurrentRow != null)
            {
                Serie seleccionada = (Serie)dgvSeries.CurrentRow.DataBoundItem;
                cargarImagen(seleccionada.ImagenUrl);
            }
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbSeries.Load(imagen);
            }
            catch (Exception)
            {
                pbSeries.Load("https://filetandvine.com/wp-content/uploads/2015/10/pix-vertical-placeholder.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaSerie alta = new frmAltaSerie();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Serie seleccionada; 
            
            if(dgvSeries.SelectedRows.Count > 0)
            {
                seleccionada = (Serie)dgvSeries.CurrentRow.DataBoundItem;
                frmAltaSerie modificar = new frmAltaSerie(seleccionada);
                modificar.ShowDialog();
                cargar();
            }
            else
                MessageBox.Show("Debe seleccionar un registro para proceder.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            SerieService service = new SerieService();
            Serie seleccionada;
            try
            {
                if (dgvSeries.SelectedRows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la Serie?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {

                        seleccionada = (Serie)dgvSeries.CurrentRow.DataBoundItem;

                        if (logico)
                            service.eliminarLogico(seleccionada.Id);
                        else
                            service.eliminar(seleccionada.Id);

                        cargar();
                    }                    

                }
                else
                    MessageBox.Show("Debe seleccionar un registro para proceder.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Serie> listaFiltrada;
            string filtro = txtbFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaSerie.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Genero.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaSerie;
            }

            dgvSeries.DataSource = null;
            dgvSeries.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Año")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Despues del");
                cboCriterio.Items.Add("Antes del");
                cboCriterio.Items.Add("En el");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool validarBusqueda() 
        { 
            if(cboCampo.SelectedIndex < 0 || cboCriterio.SelectedIndex <0)
            {
                MessageBox.Show("Por favor, seleccione campo y criterio antes de buscar.");
                return true;
            }

            return false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SerieService service = new SerieService();
            try
            {
                if (validarBusqueda())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtbFiltroAvanzado.Text;
                dgvSeries.DataSource = service.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboCampo.SelectedItem != null && cboCampo.SelectedItem.ToString() == "Año")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }               
        }


    }
}
