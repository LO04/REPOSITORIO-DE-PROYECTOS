using BussinesLogic.BLCliente;
using BussinesLogic.BLEvento;
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
    public partial class FrmEvento : Form
    {
        IEventoService objEventoService;
        ILocalService objLocalService;
        IClienteService objClienteService;
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
        IEventoService MyEventoService
        {
            get
            {
                if (objEventoService == null)
                {
                    objEventoService = new EventoService();
                }
                return objEventoService;
            }
        }
        public FrmEvento()
        {
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            List<Local> local = MyLocalService.ListarLocales();
            cbLocal.DataSource = local;
            List<Cliente> cliente = MyClienteService.ObtenerClientes();
            cbCliente.DataSource = cliente;

            //para la buscaqueda
            List<Local> localorder = MyLocalService.ListarLocales();
            cbLocalOrder.DataSource = localorder;
            List<Cliente> clienteorder = MyClienteService.ObtenerClientes();
            cbClienteOrder.DataSource = clienteorder;

            Cargar_Evento();
        }
        private void Cargar_Evento()
        {
            List<Evento> evento = MyEventoService.ObtenerEventos();
            dgbEvento.DataSource = evento;
        }
        //////////////CREAR Y ACTUALIZAR-CREAR CAMPOS DEL FORMULARIO////////////////////////////////////7
        Evento actualizar = null;
        private void Actualizar_Crear(Evento objEvento)
        {
            objEvento.id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
            objEvento.id_local = Convert.ToInt32(cbLocal.SelectedValue);
            objEvento.nombre = txtNombre.Text;
            objEvento.objetivo = txtObjetivo.Text;
            objEvento.nro_asistentes = Convert.ToInt32(txtNroAistentes.Text);
            objEvento.fecha_evento = dtFecha.Value;
            objEvento.encargado = txtEncargado.Text;
        }
        private void limpiar_formulario()
        {
          txtNombre.Clear();
          txtObjetivo.Clear();
          txtEncargado.Clear();
          txtNroAistentes.Clear();
           
        }

        /// ////////////////////////////////////////////////////////////////
        private void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            borrarValidaciom();
            if (ValidarDatos())
            {
                Evento objEvento = new Evento();
                Actualizar_Crear(objEvento);
                MyEventoService.CrearEvento(objEvento);
                Cargar_Evento();
                MessageBox.Show("Se ha guardado el Evento", "Success");
                limpiar_formulario();
            }

        }
        private void btnActualizarEvento_Click(object sender, EventArgs e)
        {
            if (actualizar == null)
            {
                MessageBox.Show("Seleccione un evento para actualizar", "Success");
            }
            else
           if (ValidarDatos())
            {

                if (MessageBox.Show("¿Está seguro que desea actualizar la opcion seleccionada?",
                       "Warning!", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Evento objEvento = actualizar;
                    Actualizar_Crear(objEvento);
                    MyEventoService.ActualizarEvento(objEvento);
                    this.Cargar_Evento();
                    limpiar_formulario();
                }

            }
        }
        private void dgbEvento_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                actualizar =
                    (Evento)dgbEvento.Rows[e.RowIndex].DataBoundItem;

                this.cbCliente.SelectedValue = actualizar.id_cliente;
                this.cbLocal.SelectedValue = actualizar.id_local;
                this.txtNombre.Text = actualizar.nombre.ToString();
                this.txtObjetivo.Text = actualizar.objetivo.ToString();
                this.txtNroAistentes.Text = actualizar.nro_asistentes.ToString();
                this.dtFecha.Value = actualizar.fecha_evento;
                this.txtEncargado.Text = actualizar.encargado.ToString();

                if (dgbEvento.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está seguro de eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEventoService.EliminarEvento(actualizar.id_evento);
                        limpiar_formulario();
                        this.Cargar_Evento();
                    }
                }
            }
        }
        private void dgbEvento_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (txtObjetivo.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtObjetivo, "Ingresar objetivo");
            }

            if (txtEncargado.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtEncargado, "Ingresar Encargado");
            }
            if (txtNroAistentes.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtNroAistentes, "Ingresar Nro de asistentes");
            }
           

            return result;
        }
        public void borrarValidaciom()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtObjetivo, "");
            errorProvider1.SetError(txtEncargado, "");
            errorProvider1.SetError(txtNroAistentes, "");
         
        }
        private void id_(object sender, EventArgs e)
        {

        }

        private void id_cliente(object sender, EventArgs e)
        {

        }

        private void id_local(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtObjetivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtNroAistentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Evento> eventos = MyEventoService.ObtenerEventosporCliente(Convert.ToInt32(cbClienteOrder.SelectedValue));
            dgbEvento.DataSource = eventos;
        }

        private void btnBuscarLocal_Click(object sender, EventArgs e)
        {
            List<Evento> eventos = MyEventoService.ObtenerEventosporLocal(Convert.ToInt32(cbLocalOrder.SelectedValue));
            dgbEvento.DataSource = eventos;
        }

        private void btnRetirarfiltrado_Click(object sender, EventArgs e)
        {
            Cargar_Evento();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            List<Evento> eventos = MyEventoService.listarPorFecha(dtinicio.Value,dtfin.Value);
            dgbEvento.DataSource = eventos;
        }
    }
}
