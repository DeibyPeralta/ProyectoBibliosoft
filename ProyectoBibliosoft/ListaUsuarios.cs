using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace ProyectoBibliosoft
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ServicePrestamo usuario = new ServicePrestamo();
        private void button6_Click(object sender, EventArgs e)
        {
            IList<Persona> usu = new List<Persona>();

            usu = usuario.ConsultarUsuario();

            Mostrar.DataSource = usu;
            Mostrar.Refresh();
        }
    }
}
