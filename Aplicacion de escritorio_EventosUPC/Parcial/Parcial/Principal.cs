using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Principal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnrestaurar.Visible = true;
            WindowState = FormWindowState.Maximized;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnrestaurar.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelC_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TRetirarMenu_Tick(object sender, EventArgs e)
        {
            if(panelM.Width<=60)
            {
                TRetirarMenu.Enabled = false;

            }
            else
            {
                panelM.Width = panelM.Width - 20;
            }
        }

        private void TmostrarMenu_Tick(object sender, EventArgs e)
        {
            if(panelM.Width>=220)
            {
                TmostrarMenu.Enabled = false;
            }
            else{
                panelM.Width = panelM.Width + 20;
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if(panelM.Width==220)
            {
                TRetirarMenu.Enabled = true;
            }else if(panelM.Width==60)
            {
                TmostrarMenu.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void pERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void llamarFormulario(object formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }
            Form frmh = formHijo as Form;
            frmh.TopLevel = false;
            frmh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmh);
            panelContenedor.Tag = frmh;
            frmh.Show();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmPersonal());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            llamarFormulario(new FrmCliente());
        }

        private void PanelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarLocal_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmLocal());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento_Actividad());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento_Equipo());
        }

        private void btnOpcionMaterial_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento_Material());
        }

        private void btnOpcionPersonalElementos_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento_Personal());
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            llamarFormulario(new FrmEvento_Servicio());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
   
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
    
        }
    }
}
