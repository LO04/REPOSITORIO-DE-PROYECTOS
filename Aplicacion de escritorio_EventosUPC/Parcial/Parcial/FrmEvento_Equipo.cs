using BussinesLogic.BLEquipo;
using BussinesLogic.BLEvento;
using BussinesLogic.BLEvento_Equipo;
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
    public partial class FrmEvento_Equipo : Form
    {
        IEvento_EquipoService objEvento_EquipoService;
        IEquipoService objequipoService;
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
        IEquipoService MyEquipoService
        {
            get
            {
                if (objequipoService == null)
                {
                    objequipoService = new EquipoService();
                }
                return objequipoService;
            }
        }
        IEvento_EquipoService MyEvento_EquipoService
        {
            get
            {
                if (objEvento_EquipoService == null)
                {
                    objEvento_EquipoService = new Evento_EquipoService();
                }
                return objEvento_EquipoService;
            }
        }
        public FrmEvento_Equipo()
        {
            InitializeComponent();
        }

        private void FrmEvento_Equipo_Load(object sender, EventArgs e)
        {

            List<Evento> evento = MyEventoService.ObtenerEventos();
            cbEvento.DataSource = evento;
            List<Equipo> equipo = MyEquipoService.ObtenerEquipos();
            cbEquipo.DataSource = equipo;

            List<Evento> eventob = MyEventoService.ObtenerEventos();
            cbEventobuscar.DataSource = eventob;
            List<Equipo> equipob = MyEquipoService.ObtenerEquipos();
            cbEquipoBuscar.DataSource = equipob;

            cargar_evento_equipo();
        }
        private void cargar_evento_equipo()
        {
            List<Evento_Equipo> evento_equipo = MyEvento_EquipoService.ObtenerEvento_Equipos();
            dgbEvento_Equipo.DataSource = evento_equipo;
        }

        private void dgbEvento_Equipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void dgbEvento_Equipo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Evento_Equipo objEve_Acti =
                    (Evento_Equipo)dgbEvento_Equipo.Rows[e.RowIndex].DataBoundItem;

                this.cbEvento.SelectedValue = objEve_Acti.id_evento;
                this.cbEquipo.SelectedValue = objEve_Acti.id_equipo;

                if (dgbEvento_Equipo.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está Seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEvento_EquipoService.EliminarEvento_Equipos(objEve_Acti.id_evento_equipo);
                        this.cargar_evento_equipo();
                    }
                }
            }
        }
        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
            Evento_Equipo objEvento_equipo = new Evento_Equipo();
          
            objEvento_equipo.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
            objEvento_equipo.id_equipo = Convert.ToInt32(cbEquipo.SelectedValue);

            MyEvento_EquipoService.CrearEvento_Equipo(objEvento_equipo);
            cargar_evento_equipo();
            MessageBox.Show("El equipo ha sido guardado!", "Success");
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            List<Evento_Equipo> eventos_EquipoB = MyEvento_EquipoService.ListarPorEvento(Convert.ToInt32(cbEventobuscar.SelectedValue));
            dgbEvento_Equipo.DataSource = eventos_EquipoB;
        }

        private void btnbuscarEquipo_Click(object sender, EventArgs e)
        {
            List<Evento_Equipo> eventos_EquipoB = MyEvento_EquipoService.ListarPorEquipo(Convert.ToInt32(cbEquipoBuscar.SelectedValue));
            dgbEvento_Equipo.DataSource = eventos_EquipoB;
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            cargar_evento_equipo();
        }

        private void cbEventobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
