using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ejercicio_Rentas
{
    public partial class Ppeliculas : Form
    {
        private NPeliculas nPeliculas;
        public Ppeliculas()
        {
            InitializeComponent();
            nPeliculas = new NPeliculas();
            CargarDatos();
        }

        void CargarDatos()
        {
            dgpeliculas.DataSource = nPeliculas.PeliculasTodas();
        }
        // fin de etapa 1
        void LimpiarDatos()
        {
            txtpeliculaid.Text = "";
            txtnombre.Text = "";
            txtgenero.Text = "";
            txtautores.Text = "";
            txtexistencia.Text = "";
            txtprecio.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        // de etapa 2

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgpeliculas.DataSource = nPeliculas.PeliculasActivas();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }

        }
        //fin de etapa3
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var PeliculaID = txtpeliculaid.Text.ToString();
            var Nombre = txtnombre.Text.ToString();
            var Genero = txtgenero.Text.ToString();
            var Autores = txtautores.Text.ToString();
            var Existencia = txtexistencia.Text.ToString();
            var PrecioRenta = txtprecio.Text.ToString();
            if (string.IsNullOrEmpty(PeliculaID) || string.IsNullOrWhiteSpace(PeliculaID))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrWhiteSpace(Nombre))
            {
                errorProvider1.SetError(txtnombre, "Debe ingresar el Nombre");
                return;
            }
            if (string.IsNullOrEmpty(Genero) || string.IsNullOrWhiteSpace(Genero))
            {
                errorProvider1.SetError(txtgenero, "Debe ingresar el Genero");
                return;
            }
            if (string.IsNullOrEmpty(Autores) || string.IsNullOrWhiteSpace(Autores))
            {
                errorProvider1.SetError(txtautores, "Debe ingresar el autor");
                return;
            }

            if (string.IsNullOrEmpty(Existencia) || string.IsNullOrWhiteSpace(Existencia))
            {
                errorProvider1.SetError(txtexistencia, "Debe ingresar la cantidad existente");
                return;
            }

            if (string.IsNullOrEmpty(PrecioRenta) || string.IsNullOrWhiteSpace(PrecioRenta))
            {
                errorProvider1.SetError(txtprecio, "Debe ingresar el precio");
                return;
            }

            if (agregar)
            {
                nPeliculas.AgregarPelicula(new Mpeliculas()
                {
                    Nombre = Nombre,
                    Genero = Genero,
                    Autores = Autores,
                    Existencia = int.Parse(Existencia),
                    PrecioRenta = Decimal.Parse(PrecioRenta),
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nPeliculas.EditarPelicula(new Mpeliculas()
                {
                    PeliculaID = int.Parse(PeliculaID),
                    Nombre = Nombre,
                    Genero = Genero,
                    Autores = Autores,
                    Existencia = int.Parse(Existencia),
                    PrecioRenta = Decimal.Parse(PrecioRenta),
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
        }
        //fin etapa 4

        private void btnEliminar_Click(object sender, EventArgs e)
            {
                var peliculaid = txtpeliculaid.Text.ToString();
                if (string.IsNullOrEmpty(peliculaid) || string.IsNullOrWhiteSpace(peliculaid))
                {
                    return;
                }
                nPeliculas.EliminarPelicula(int.Parse(peliculaid));
                CargarDatos();
                LimpiarDatos();
            }
        private void dgpeliculas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgpeliculas.Rows.Count)
            {
                DataGridViewRow row = dgpeliculas.Rows[e.RowIndex];
                txtpeliculaid.Text = row.Cells["PeliculaID"].Value.ToString();
                txtnombre.Text = row.Cells["Nombre"].Value.ToString();
                txtgenero.Text = row.Cells["Genero"].Value.ToString();
                txtautores.Text = row.Cells["Autores"].Value.ToString();
                txtexistencia.Text = row.Cells["Existencia"].Value.ToString();
                txtprecio.Text = row.Cells["PrecioRenta"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgpeliculas.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

      
    }

      

       
    }

