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
    public partial class ListaPrestamos : Form
    {
        public ListaPrestamos()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'biblioSoftDataSet2.Libro' Puede moverla o quitarla según sea necesario.
//            this.libroTableAdapter1.Fill(this.biblioSoftDataSet2.Libro);
            // TODO: esta línea de código carga datos en la tabla 'biblioSoftDataSet1.Libro' Puede moverla o quitarla según sea necesario.
 //           this.libroTableAdapter.Fill(this.biblioSoftDataSet1.Libro);
            // TODO: esta línea de código carga datos en la tabla 'biblioSoftDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
  //          this.prestamoTableAdapter.Fill(this.biblioSoftDataSet.Prestamo);
            // TODO: esta línea de código carga datos en la tabla 'biblioSoftDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
            //            this.prestamoTableAdapter.Fill(this.biblioSoftDataSet.Prestamo);
            // TODO: esta línea de código carga datos en la tabla 'pruebaProyectoDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
            //           this.prestamoTableAdapter.Fill(this.pruebaProyectoDataSet.Prestamo);
            // TODO: esta línea de código carga datos en la tabla 'biblioSoftDataSet1.Libro' Puede moverla o quitarla según sea necesario.
            //           this.libroTableAdapter.Fill(this.biblioSoftDataSet1.Libro);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.UsuarioPres' Puede moverla o quitarla según sea necesario.
            //          this.usuarioPresTableAdapter.Fill(this.proyectoDataSet.UsuarioPres);

        }

        ServicePrestamo servicio = new ServicePrestamo();
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        ServiceLibros servicioLibros = new ServiceLibros();
        private void button2_Click(object sender, EventArgs e)
        {
      /*      IList<Libro> obj = new List<Libro>();
            obj = servicioLibros.Consultar();

            VerLibros.DataSource = obj;
            VerLibros.Refresh();
     */   }

        private void Ver_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Ver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ver.Refresh();
            IList<PrestamoLibros> libros = new List<PrestamoLibros>();
            libros = servicio.Consultar();

            Ver.DataSource = libros;
            Ver.Refresh();
        }
    }
}
