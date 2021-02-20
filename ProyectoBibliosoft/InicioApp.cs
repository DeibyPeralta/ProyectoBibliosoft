using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBibliosoft
{
    public partial class InicioApp : Form
    {
        public InicioApp()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistroLibro frm = new RegistroLibro();
            this.Hide();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {    
            Prestamo presta = new Prestamo();
            presta.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void InicioApp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {
            ListaPrestamos prueba = new ListaPrestamos();
            prueba.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ListadoLibros mirar = new ListadoLibros();
            mirar.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RegistroUsuarios usuario = new RegistroUsuarios();
            this.Hide();
            usuario.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            ListaUsuarios usuario = new ListaUsuarios();
            usuario.Show();
            this.Hide();
        }
    }
}
