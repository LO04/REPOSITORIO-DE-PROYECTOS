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
    public partial class FrmPersonal : Form
    {   
        IPersonalService objPersonalService;
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
        public FrmPersonal()
        {

            InitializeComponent();

        }
        private void dgbPersonal_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
           
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            this.cargarPersonal();
        }
        private void cargarPersonal()
        {
            List<Personal> personal = MyPersonalService.ObtenerPersonales();
            dgbPersonal.DataSource = personal;
        }
        //////////////CREAR Y ACTUALIZAR-CREAR CAMPOS DEL FORMULARIO////////////////////////////////////7
        Personal actualizar = null;
        private void Actualizar_Crear(Personal objPersonal)
        {
            objPersonal.nombre = txtNombre.Text;
            objPersonal.DNI = Convert.ToInt32(txtDNI.Text);
            objPersonal.cargo = txtCargo.Text;
            objPersonal.sueldo = Convert.ToDecimal(txtSueldo.Text); ;

        }
        private void limpiar_formulario()
        {
            txtNombre.Clear();
            txtCargo.Clear();
            txtDNI.Clear();
            txtSueldo.Clear();

        }
        /// ////////////////////////////////////////////////////////////////
        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            borrarValidaciom();
            if (ValidarDatos())
            {
                Personal objpersonal = new Personal();
                Actualizar_Crear(objpersonal);

                MyPersonalService.CrearPersonal(objpersonal);
                this.cargarPersonal();
                MessageBox.Show("El personal ha sido registrado", "Success");
                limpiar_formulario();
            }

        }
        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            if(actualizar==null)
            {
                MessageBox.Show("Seleccione un personal para actualizar", "Success");
            }
            else
            if (ValidarDatos())
            {

                if (MessageBox.Show("¿Está seguro que desea actualizar la opcion seleccionada?",
                       "Warning!", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Personal objPersonal = actualizar;
                    Actualizar_Crear(objPersonal);
                    MyPersonalService.ActualizarPersonal(objPersonal);
                    this.cargarPersonal();
                    limpiar_formulario();
                }

            }
        }
        private void dgbPersonal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                actualizar =
                    (Personal)dgbPersonal.Rows[e.RowIndex].DataBoundItem;

                this.txtNombre.Text = actualizar.nombre.ToString();
                this.txtDNI.Text = actualizar.DNI.ToString();
                this.txtCargo.Text = actualizar.cargo.ToString();
                this.txtSueldo.Text = actualizar.sueldo.ToString();

                if (dgbPersonal.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyPersonalService.EliminarPersonal(actualizar.id_personal);
                        limpiar_formulario();
                        this.cargarPersonal();
                    }
                }
            }
        }
        private void dgbPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////VALIDACIONES

        public void validacion_numeros_decimal(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if((e.KeyChar == '.')&&(!txtSueldo.Text.Contains(".")))
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
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
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }else
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
            if (txtCargo.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtCargo, "Ingresar cargo");
            }

            if (txtDNI.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtDNI, "Ingresar DNI");
            }

            if (txtSueldo.Text == "")
            {
                result = false;
                errorProvider1.SetError(txtSueldo, "Ingresar sueldo");
            }

            return result;
        }
        public void borrarValidaciom()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtCargo, "");
            errorProvider1.SetError(txtDNI, "");
            errorProvider1.SetError(txtSueldo, "");
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros(e);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_letras(e);
        }

        private void txtSueldo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_numeros_decimal(e);
        }

        private void dgbPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgbPersonal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgbPersonal.Columns[e.ColumnIndex].HeaderText=="nombre")
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void btnNombreDescending_Click(object sender, EventArgs e)
        {
           
        }

        private void dgbPersonal_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void btnAscendenteNombre_Click(object sender, EventArgs e)
        {
            List<Personal> personal = MyPersonalService.NombreAscendente();
            dgbPersonal.DataSource = personal;
        }

        private void btnNombreDescending_Click_1(object sender, EventArgs e)
        {
            List<Personal> personal = MyPersonalService.NombreDescendente();
            dgbPersonal.DataSource = personal;
        }

      

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
