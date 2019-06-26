using BussinesLogic.BLCliente;
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
    public partial class FrmCliente : Form
    {
        IClienteService objClienteService;
        IClienteService MyClienteService
        {
            get
            {
                if (objClienteService == null)
                {
                    objClienteService = new ClienteService();
                }
                return objClienteService;
            }
        }
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.cargar_cliente();
        }
        private void cargar_cliente()
        {
            List<Cliente> cliente = MyClienteService.ObtenerClientes();
            dgbCliente.DataSource = cliente;
        }
        //////////////CREAR Y ACTUALIZAR-CREAR CAMPOS DEL FORMULARIO////////////////////////////////////7
        Cliente actualizar=null;
        private void Actualizar_Crear(Cliente objCliente)
        {
            objCliente.nombre = txtNombre.Text;
            objCliente.apellido = txtApellido.Text;
            objCliente.DNI = Convert.ToInt32(txtDNI.Text);
            objCliente.celular = Convert.ToInt32(txtCelular.Text);
            objCliente.direccion = txtDireccion.Text;
        }
        private void limpiar_formulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
        }

        /// ////////////////////////////////////////////////////////////////

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            borrarValidaciom();
            if (ValidarDatos())
            {
                Cliente objCliente = new Cliente();
                Actualizar_Crear(objCliente);

                MyClienteService.CrearCliente(objCliente);
                this.cargar_cliente();
                MessageBox.Show("El cliente ha sido registrado", "Success");
                limpiar_formulario();
            }
            
        }
        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (actualizar == null)
            {
                MessageBox.Show("Seleccione un cliente para actualizar", "Success");
            }
            else
           if (ValidarDatos())
            {
               
                if (MessageBox.Show("¿Está seguro que desea actualizar la opcion seleccionada?",
                       "Warning!", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Cliente objCliente = actualizar;
                    Actualizar_Crear(objCliente);
                    MyClienteService.ActualizarCliente(objCliente);
                    this.cargar_cliente();
                    limpiar_formulario();
                }
                
            }
        }
        private void dgbCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                actualizar =
                    (Cliente)dgbCliente.Rows[e.RowIndex].DataBoundItem;

                this.txtNombre.Text = actualizar.nombre.ToString();
                this.txtApellido.Text = actualizar.apellido.ToString();
                this.txtDNI.Text = actualizar.DNI.ToString();
                this.txtCelular.Text = actualizar.celular.ToString();
                this.txtDireccion.Text = actualizar.direccion.ToString();

                if (dgbCliente.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyClienteService.EliminarCliente(actualizar.id_cliente);
                        limpiar_formulario();
                        this.cargar_cliente();
                    }
                }
            }
        }
        private void dgbPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////VALIDACIONES

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
         
            if(txtNombre.Text=="")
            {
                result = false;
                errorProviderCliente.SetError(txtNombre, "Ingresar Nombre");
            }
            if (txtApellido.Text == "")
            {
                result = false;
                errorProviderCliente.SetError(txtApellido, "Ingresar Apellido");
            }
          
            if (txtDNI.Text=="")
            {
                result = false;
                errorProviderCliente.SetError(txtDNI, "Ingresar DNI");
            }
            if (txtCelular.Text == "")
            {
                result = false;
                errorProviderCliente.SetError(txtCelular, "Ingresar Celular");
            }
            if (txtDireccion.Text == "")
            {
                result = false;
                errorProviderCliente.SetError(txtDireccion, "Ingresar Direccion");
            }

            return result;
        }
        public void borrarValidaciom()
        {
            errorProviderCliente.SetError(txtNombre, "");
            errorProviderCliente.SetError(txtApellido, "");
            errorProviderCliente.SetError(txtDNI, "");
            errorProviderCliente.SetError(txtCelular, "");
            errorProviderCliente.SetError(txtDireccion, "");
        }
    
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
 
        

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void btnAscendenteNombre_Click(object sender, EventArgs e)
        {
            List<Cliente> cliente = MyClienteService.NombreAscendente();
            dgbCliente.DataSource = cliente;
        }

        private void btnNombreDescending_Click(object sender, EventArgs e)
        {
            List<Cliente> cliente = MyClienteService.NombreDescendente();
            dgbCliente.DataSource = cliente;
        }

       
    }
}
