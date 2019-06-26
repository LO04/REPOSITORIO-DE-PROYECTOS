using BussinesLogic.BLEvento;
using BussinesLogic.BLEvento_Servicio;
using BussinesLogic.BLServicio;
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
    public partial class FrmEvento_Servicio : Form
    {
        IEvento_ServicioService objEvento_ServicioService;
        IServicioService objServicioService;
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
        IServicioService MyServicioService
        {
            get
            {
                if (objServicioService == null)
                {
                    objServicioService = new ServicioService();
                }
                return objServicioService;
            }
        }
        IEvento_ServicioService MyEvento_ServicioService
        {
            get
            {
                if (objEvento_ServicioService == null)
                {
                    objEvento_ServicioService = new Evento_ServicioService();
                }
                return objEvento_ServicioService;
            }
        }
        public FrmEvento_Servicio()
        {
            InitializeComponent();
        }

        private void FrmEvento_Servicio_Load(object sender, EventArgs e)
        {
            List<Evento> evento = MyEventoService.ObtenerEventos();
            cbEvento.DataSource = evento;
            List<Servicio> Servicio = MyServicioService.ObtenerServicios();
            cbServicio.DataSource = Servicio;

            List<Evento> eventob = MyEventoService.ObtenerEventos();
            cbEventobuscar.DataSource = eventob;
            List<Servicio> Serviciob = MyServicioService.ObtenerServicios();
            cbServicioBuscar.DataSource = Serviciob;

            cargar_evento_Servicio();
        }
        private void cargar_evento_Servicio()
        {
            List<Evento_Servicio> evento_Servicio = MyEvento_ServicioService.ObtenerEvento_Servicios();
            dgbEvento_Servicio.DataSource = evento_Servicio;
        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {
            Evento_Servicio objEvento_Servicio = new Evento_Servicio();

            objEvento_Servicio.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
            objEvento_Servicio.id_servicio = Convert.ToInt32(cbServicio.SelectedValue);

            MyEvento_ServicioService.CrearEvento_Servicio(objEvento_Servicio);
            cargar_evento_Servicio();
            MessageBox.Show("El Servicio ha sido guardado!", "Success");
        }

        private void dgbEvento_Servicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgbEvento_Servicio_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Evento_Servicio objEve_Acti =
                    (Evento_Servicio)dgbEvento_Servicio.Rows[e.RowIndex].DataBoundItem;

                this.cbEvento.SelectedValue = objEve_Acti.id_evento;
                this.cbServicio.SelectedValue = objEve_Acti.id_servicio;

                if (dgbEvento_Servicio.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está Seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEvento_ServicioService.EliminarEvento_Servicios(objEve_Acti.id_evento_servicio);
                        this.cargar_evento_Servicio();
                    }
                }
            }
        }

        private void btnbuscarServicio_Click(object sender, EventArgs e)
        {
            List<Evento_Servicio> eventos_ServicioB = MyEvento_ServicioService.ListarPorServicio(Convert.ToInt32(cbServicioBuscar.SelectedValue));
            dgbEvento_Servicio.DataSource = eventos_ServicioB;
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            List<Evento_Servicio> eventos_ServicioB = MyEvento_ServicioService.ListarPorEvento(Convert.ToInt32(cbEventobuscar.SelectedValue));
            dgbEvento_Servicio.DataSource = eventos_ServicioB;
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            cargar_evento_Servicio();
        }
    }
}
