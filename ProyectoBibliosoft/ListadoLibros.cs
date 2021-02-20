using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace ProyectoBibliosoft
{
    public partial class ListadoLibros : Form
    {
        public ListadoLibros()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listado_Libros_Load(object sender, EventArgs e)
        {

        }

        ServiceLibros servicio = new ServiceLibros();
        IList<Libro> lista = new List<Libro>();
        private void button6_Click(object sender, EventArgs e)
        {            
            lista = servicio.Consultar();

            VerLibros.DataSource = lista;
            VerLibros.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerLibros.CurrentCell = null;
            lista = servicio.Consultar();
            if (Filtro.Text.Equals("General"))
            {
                foreach (DataGridViewRow columna in VerLibros.Rows)
                {
                    columna.Visible = false;
                }

                foreach (DataGridViewRow columna in VerLibros.Rows)
                {
                    foreach (DataGridViewCell celda in columna.Cells)
                    {
                        if ((celda.Value.ToString().IndexOf(Filtro.Text)) != 0)
                        {
                            columna.Visible = true;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow columna in VerLibros.Rows)
                {
                    columna.Visible = false;
                }

                foreach (DataGridViewRow columna in VerLibros.Rows)
                {
                    foreach (DataGridViewCell celda in columna.Cells)
                    {
                        if ((celda.Value.ToString().IndexOf(Filtro.Text)) == 0)
                        {
                            columna.Visible = true;
                        }
                    }
                }
            }
            
        }
    }
}
