using BussinesLogic.BLLocal;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FrmLocal : Form
    {
        ILocalService objLocalService;
        ILocalService MyLocalService
        {
            get
            {
                if (objLocalService == null)
                {
                    objLocalService = new LocalService();
                }
                return objLocalService;
            }
        }
        public FrmLocal()
        {
            InitializeComponent();
        }

        private void FrmLocal_Load(object sender, EventArgs e)
        {
            cargar_local();
        }
        private void cargar_local()
        {
            List<Local> local = MyLocalService.ListarLocales();
            dgbLocal.DataSource = local;
        }
        //////////////CREAR Y ACTUALIZAR-CREAR CAMPOS DEL FORMULARIO////////////////////////////////////7
        Local actualizar = null;
        private void Actualizar_Crear(Local objLocal)
        {
            objLocal.nombre = txtNombre.Text;
            objLocal.direccion = txtDireccion.Text;
            objLocal.capacidad = Convert.ToInt32(txtCapacidad.Text);
        }
        private void limpiar_formulario()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCapacidad.Clear();   
        }

        /// ////////////////////////////////////////////////////////////////
        private void btnRegistrarLocal_Click(object sender, EventArgs e)
        {
            Local objLocal = new Local();
            Actualizar_Crear(objLocal);
            MyLocalService.RegistrarLocal(objLocal);
            this.cargar_local();
            MessageBox.Show("El Local ha sido registrado", "Success");
            limpiar_formulario();

        }
        private void btnActualizarLocal_Click(object sender, EventArgs e)
        {
            if (actualizar == null)
            {
                MessageBox.Show("Seleccione un local para actualizar", "Success");
            }
            else
           if (ValidarDatos())
            {

                if (MessageBox.Show("¿Está seguro que desea actualizar la opcion seleccionada?",
                       "Warning!", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Local objLocal = actualizar;
                    Actualizar_Crear(objLocal);
                    MyLocalService.ActualizarLocal(objLocal);
                    this.cargar_local();
                    limpiar_formulario();
                }

            }
        }
        private void dgbLocal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                actualizar =
                    (Local)dgbLocal.Rows[e.RowIndex].DataBoundItem;

                this.txtNombre.Text = actualizar.nombre.ToString();
                this.txtDireccion.Text = actualizar.direccion.ToString();
                this.txtCapacidad.Text = actualizar.capacidad.ToString();

                if (dgbLocal.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyLocalService.EliminarLocal(actualizar.id_local);
                        this.cargar_local();
                    }
                }
            }
        }
        private void dgbLocal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void validacion_numeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void validacion_letras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public bool ValidarDatos()
        {
            bool result = true;

            if (txtNombre.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtNombre, "Ingresar Nombre");
            }
            if (txtDireccion.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtDireccion, "Ingresar Direccion");
            }

            if (txtCapacidad.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtCapacidad, "Ingresar capacidad");
            }
           

            return result;
        }
        public void borrarValidaciom()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtCapacidad, "");
        
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void btnAscendenteNombre_Click(object sender, EventArgs e)
        {
            List<Local> local = MyLocalService.NombreAscendente();
            dgbLocal.DataSource = local;
        }

        private void btnNombreDescending_Click(object sender, EventArgs e)
        {
            List<Local> local = MyLocalService.NombreDescendente();
            dgbLocal.DataSource = local;
        }

       
    }
}
