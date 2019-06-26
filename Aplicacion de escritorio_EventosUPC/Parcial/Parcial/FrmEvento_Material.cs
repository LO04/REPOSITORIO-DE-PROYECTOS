using BussinesLogic.BLEvento;
using BussinesLogic.BLEvento_Material;
using BussinesLogic.BLMaterial;
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
    public partial class FrmEvento_Material : Form
    {
        IEvento_MaterialService objEvento_MaterialService;
        IMaterialService objMaterialService;
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
        IMaterialService MyMaterialService
        {
            get
            {
                if (objMaterialService == null)
                {
                    objMaterialService = new MaterialService();
                }
                return objMaterialService;
            }
        }
        IEvento_MaterialService MyEvento_MaterialService
        {
            get
            {
                if (objEvento_MaterialService == null)
                {
                    objEvento_MaterialService = new Evento_MaterialService();
                }
                return objEvento_MaterialService;
            }
        }
        public FrmEvento_Material()
        {
            InitializeComponent();
        }

        private void FrmEvento_Material_Load(object sender, EventArgs e)
        {
            List<Evento> evento = MyEventoService.ObtenerEventos();
            cbEvento.DataSource = evento;
            List<Material> material =MyMaterialService.ObtenerMateriales();
            cbMaterial.DataSource = material;

            List<Evento> eventob = MyEventoService.ObtenerEventos();
            cbEventobuscar.DataSource = eventob;
            List<Material> materialb = MyMaterialService.ObtenerMateriales();
            cbMaterialbuscar.DataSource = materialb;

            cargar_evento_material();
        }
        private void cargar_evento_material()
        {
            List<Evento_Material> evento_Material = MyEvento_MaterialService.ObtenerEvento_Materiales();
            dgbEvento_Material.DataSource = evento_Material;
        }
        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {
            Evento_Material objEvento_material = new Evento_Material();

            objEvento_material.id_evento = Convert.ToInt32(cbEvento.SelectedValue);
            objEvento_material.id_material = Convert.ToInt32(cbMaterial.SelectedValue);

            MyEvento_MaterialService.CrearEvento_Material(objEvento_material);
            cargar_evento_material();
            MessageBox.Show("El material ha sido guardado!", "Success");
        }

       
        private void dgbEvento_Material_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Evento_Material objEve_Acti =
                    (Evento_Material)dgbEvento_Material.Rows[e.RowIndex].DataBoundItem;

                this.cbEvento.SelectedValue = objEve_Acti.id_evento;
                this.cbMaterial.SelectedValue = objEve_Acti.id_material;

                if (dgbEvento_Material.Columns[e.ColumnIndex].HeaderText
                    == "Eliminar")
                {
                    if (MessageBox
                        .Show("¿Está Seguro que desea eliminar la opcion seleccionada?",
                        "Warning!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        MyEvento_MaterialService.EliminarEvento_Materiales(objEve_Acti.id_evento_material);
                        this.cargar_evento_material();
                    }
                }
            }
        }

        private void cbEventobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            List<Evento_Material> eventos_MaterialB = MyEvento_MaterialService.ListarPorEvento(Convert.ToInt32(cbEventobuscar.SelectedValue));
            dgbEvento_Material.DataSource = eventos_MaterialB;
        }

        private void btnbuscarActividad_Click(object sender, EventArgs e)
        {
            List<Evento_Material> eventos_MaterialB = MyEvento_MaterialService.ListarPorMaterial(Convert.ToInt32(cbMaterialbuscar.SelectedValue));
            dgbEvento_Material.DataSource = eventos_MaterialB;
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            cargar_evento_material();
        }
    }
}
