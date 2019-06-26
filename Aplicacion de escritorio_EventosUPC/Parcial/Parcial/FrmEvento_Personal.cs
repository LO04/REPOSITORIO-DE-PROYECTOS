using BussinesLogic.BLEquipo;
using BussinesLogic.BLEvento;
using BussinesLogic.BLEvento_Personal;
using BussinesLogic.BLPersonal;
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
    public partial class FrmEvento_Personal : Form
    {
        IEvento_PersonalService objEvento_PersonalService;
        IPersonalService objPersonalService;
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
        IPersonalService MyPersonalService
        {
            get
            {
                if (objPersonalService == null)
                {
                    objPersonalService = new PersonalService();
                }
                return objPersonalService;
            }
        }
        IEvento_PersonalService MyEvento_PersonalService
        {
            get
            {
                if (objEvento_PersonalService == null)
                {
                    objEvento_PersonalService = new Evento_PersonalService();
                }
                return objEvento_PersonalService;
            }
        }
        public FrmEvento_Personal()
        {
            InitializeComponent();
        }

        private void FrmEvento_Personal_Load(object sender, EventArgs e)
        {
            List<Evento> evento = MyEventoService.ObtenerEventos();  
            cbEvento.DataSource = evento;
            List<Personal> Personal = MyPersonalService.ObtenerPersonales();
            cbPersonal.DataSource = Personal;

            List<Evento> eventob = MyEventoService.ObtenerEventos();
            cbEventobuscar.DataSource = eventob;
            List<Personal> Personalb = MyPersonalService.ObtenerPersonales();
            cbPersonalBuscar.DataSource = Personalb;

            cargar_evento_Personal();
        }
        private void cargar_evento_Personal()
        {
            List<Evento_Personal> evento_personal = MyEvento_PersonalService.ObtenerEvento_Personales();
            dgbEvento_Personal.DataSource = evento_personal;
        }
        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            borrarValidaciom();
            if (ValidarDatos())
            {
                Evento_Personal objEvento_Personal = new Evento_Personal();

                objEvento_Personal.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
                objEvento_Personal.id_personal = Convert.ToInt32(cbPersonal.SelectedValue);
                objEvento_Personal.horas_trab = Convert.ToInt32(txtNroHorastrabajo.Text);

                MyEvento_PersonalService.CrearEvento_Personal(objEvento_Personal);
                cargar_evento_Personal();
                txtNroHorastrabajo.Clear();
                MessageBox.Show("El Personal ha sido guardado!", "Success");
            }
        }

        private void dgbEvento_Equipo_CellClick(object sender, DataGridViewCellEventArgs e)
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
        public bool ValidarDatos()
        {
            bool result = true;

    
            if (txtNroHorastrabajo.Text == "")
            {
                result = false;
                errorProviderPersonal.SetError(txtNroHorastrabajo, "ingrese Horas de trabajo");
            }
            return result;
        }
        public void borrarValidaciom()
        {
            errorProviderPersonal.SetError(txtNroHorastrabajo, "");
         
        }

        private void txtNroHorastrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void txtNroHorastrabajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgbEvento_Personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                Evento_Personal objEve_Acti =
                    (Evento_Personal)dgbEvento_Personal.Rows[e.RowIndex].DataBoundItem;

                this.cbEvento.SelectedValue = objEve_Acti.id_evento;
                this.cbPersonal.SelectedValue = objEve_Acti.id_personal;
                this.txtNroHorastrabajo.Text = objEve_Acti.horas_trab.ToString();

                if (dgbEvento_Personal.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está Seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEvento_PersonalService.EliminarEvento_Personales(objEve_Acti.id_evento_personal);
                        txtNroHorastrabajo.Clear();
                        this.cargar_evento_Personal();
                    }
                }
            }
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            List<Evento_Personal> eventos_PersonalB = MyEvento_PersonalService.ListarPorEvento(Convert.ToInt32(cbEventobuscar.SelectedValue));
            dgbEvento_Personal.DataSource = eventos_PersonalB;
        }

        private void btnbuscarEquipo_Click(object sender, EventArgs e)
        {
            List<Evento_Personal> eventos_PersonalB = MyEvento_PersonalService.ListarPorPersonal(Convert.ToInt32(cbPersonalBuscar.SelectedValue));
            dgbEvento_Personal.DataSource = eventos_PersonalB;
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            cargar_evento_Personal();
        }
    }
}
