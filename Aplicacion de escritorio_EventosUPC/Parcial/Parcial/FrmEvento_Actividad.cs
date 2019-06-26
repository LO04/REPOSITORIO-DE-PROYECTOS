using BussinesLogic.BLActividad;
using BussinesLogic.BLEvento;
using BussinesLogic.BLEvento_Actividad;
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
    public partial class FrmEvento_Actividad : Form
    {
        IEvento_ActividadService objEvento_ActividadService;
        IActividadService objActividadService;
        IEventoService objEventoService;
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
        IActividadService MyActividadService
        {
            get
            {
                if (objActividadService == null)
                {
                    objActividadService = new ActividadService();
                }
                return objActividadService;
            }
        }
        IEvento_ActividadService MyEvento_ActividadService
        {
            get
            {
                if (objEvento_ActividadService == null)
                {
                    objEvento_ActividadService = new Evento_ActividadService();
                }
                return objEvento_ActividadService;
            }
        }
        public FrmEvento_Actividad()
        {
            InitializeComponent();
        }

        private void dpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmEvento_Actividad_Load(object sender, EventArgs e)
        {
            dtHoraInicio.Format = DateTimePickerFormat.Custom;
            dtHoraInicio.CustomFormat = "dd/MM/yyyy h:mm tt";
            dtHoraFin.Format = DateTimePickerFormat.Custom;
            dtHoraFin.CustomFormat = "dd/MM/yyyy h:mm tt";
            List<Evento> evento = MyEventoService.ObtenerEventos();
            cbEvento.DataSource = evento;
            List<Actividad> actividad = MyActividadService.ObtenerActividades();
            cbActividad.DataSource = actividad;

            List<Evento> eventob = MyEventoService.ObtenerEventos();
            cbEventobuscar.DataSource = eventob;
            List<Actividad> actividadb = MyActividadService.ObtenerActividades();
            cbActividadBuscar.DataSource = actividadb;

            cargar_evento();
        }
        //////////////CREAR Y ACTUALIZAR-CREAR CAMPOS DEL FORMULARIO////////////////////////////////////7
        private void Actualizar_Crear(Evento_Actividad  objEvento_Actividad)
        {
            objEvento_Actividad.hora_inicio = dtHoraInicio.Value;
            objEvento_Actividad.hora_fin = dtHoraFin.Value;
            objEvento_Actividad.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
            objEvento_Actividad.id_actividad = Convert.ToInt32(cbActividad.SelectedValue);
        }
        private void limpiar_formulario()
        {
           
        }

        /// ////////////////////////////////////////////////////////////////
        private void cargar_evento()
        {
            List<Evento_Actividad> evento_actividad = MyEvento_ActividadService.ObtenerEvento_Actividades();
            dgbEvento_Acividad.DataSource = evento_actividad;
        }
        private void btnRegistrarActividad_Click_1(object sender, EventArgs e)
        {
            Evento_Actividad objEvento_Actividad = new Evento_Actividad();

            objEvento_Actividad.hora_inicio = dtHoraInicio.Value;
            objEvento_Actividad.hora_fin = dtHoraFin.Value;
            objEvento_Actividad.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
            objEvento_Actividad.id_actividad = Convert.ToInt32(cbActividad.SelectedValue);

            MyEvento_ActividadService.CrearEvento_Actividad(objEvento_Actividad);
            cargar_evento();
            MessageBox.Show("El evento ha sido agregado!", "Success");
            limpiar_formulario();
        }
        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
           
        }
        private void btnActualizarActividad_Click(object sender, EventArgs e)
        {
           
        }
        private void dgbEvento_Acividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtHoraInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgbEvento_Acividad_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgbEvento_Acividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Evento_Actividad objEve_Acti =
                    (Evento_Actividad)dgbEvento_Acividad.Rows[e.RowIndex].DataBoundItem;

                this.cbEvento.SelectedValue = objEve_Acti.id_evento;
                this.cbActividad.SelectedValue = objEve_Acti.id_actividad;
                this.dtHoraInicio.Value = objEve_Acti.hora_inicio;
                this.dtHoraFin.Value = objEve_Acti.hora_fin;

                if (dgbEvento_Acividad.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está Seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEvento_ActividadService.EliminarEvento_Actividades(objEve_Acti.id_evento_actividad);
                        limpiar_formulario();
                        this.cargar_evento();
                    }
                }
            }
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            List<Evento_Actividad> eventos_actividad = MyEvento_ActividadService.listarPorEvento(Convert.ToInt32(cbEventobuscar.SelectedValue));
            dgbEvento_Acividad.DataSource = eventos_actividad;
        }

        private void btnbuscarActividad_Click(object sender, EventArgs e)
        {
          
            List<Evento_Actividad> eventos_actividadB = MyEvento_ActividadService.listarPorActividad(Convert.ToInt32(cbActividadBuscar.SelectedValue));
            dgbEvento_Acividad.DataSource = eventos_actividadB;
            
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            cargar_evento();
        }

        private void dgbEvento_Acividad_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
