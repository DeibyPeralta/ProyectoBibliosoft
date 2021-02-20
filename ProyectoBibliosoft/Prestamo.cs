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
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();
        }



//          guardar
        ServicePrestamo servicio = new ServicePrestamo();
 //       ServiceLibros ServicioLibros = new ServiceLibros();
        PrestamoLibros Libros = new PrestamoLibros();

        private void button9_Click(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bloquear();
            try
            {
                string dato;
                if ( (TxtCodigo.Text != "") && (TxtIdentificacion.Text != "") && (TxtNombre.Text != "") && (TxtApellido.Text != "") && (TxtTipoIdenti.Text != "") )
                {
                        Libros.Fechaprestamo = TxtFechaPrestamo.Text;
                        Libros.Fechaentrega = TxtFechaDevolucion.Text;                        
                        Libros.TipoUsuario = TxtTipoUsu.Text;
                        Libros.TipoIdentidad = TxtTipoIdenti.Text;
                        Libros.Identificacion = TxtIdentificacion.Text;
                        Libros.Nombre = TxtNombre.Text;                        
                        Libros.Apellido = TxtApellido.Text;
                        Libros.Codigo = TxtCodigo.Text;

                    limpiar();
                   dato = servicio.GuardarPrestamo(Libros);
                    MessageBox.Show(dato, "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if( (TxtCodigo.Text == "") || (TxtIdentificacion.Text == "") )
                {
                    MessageBox.Show("Complete los datos pedidos", "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }           

        }

        public void limpiar()
        {
            TxtTipoIdenti.Text = "";
            TxtTipoUsu.Text = "";
            TxtNombre.Text = "";
            TxtIdentificacion.Text = "";
            TxtApellido.Text = "";
            TxtCodigo.Text = "";
        }                
        public void Bloquear()
        {
            TxtTipoIdenti.Enabled = true;
            TxtTipoUsu.Enabled = true;
            TxtNombre.Enabled = true;
            TxtIdentificacion.Enabled = true;
            TxtApellido.Enabled = true;
        }

        public void Desbloquer()
        {            
            TxtTipoIdenti.Enabled = false;
            TxtTipoUsu.Enabled = false;
            TxtNombre.Enabled = false;
            TxtIdentificacion.Enabled = false;
            TxtApellido.Enabled = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar(); Bloquear();

            Guardar.Visible = true;
            Eliminar.Visible = false;
            Editar.Visible = false;
        }

        private void TxtTipoUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtTipoIdenti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if( (TxtIdentificacion.Text != "") && (TxtCodigo.Text != "") && (TxtNombre.Text != "") && (TxtApellido.Text != "") && (TxtTipoIdenti.Text != "") && (TxtTipoUsu.Text != "") )
                {
                    Libros.Fechaprestamo = TxtFechaPrestamo.Text;
                    Libros.Fechaentrega = TxtFechaDevolucion.Text;
                    Libros.TipoIdentidad = TxtTipoIdenti.Text;
                    Libros.TipoUsuario = TxtTipoUsu.Text;
                    Libros.Nombre = TxtNombre.Text;
                    Libros.Identificacion = TxtIdentificacion.Text;
                    Libros.Apellido = TxtApellido.Text;
                    Libros.Codigo = TxtCodigo.Text;

                    limpiar();
                    servicio.Actualizar(Libros);
                    MessageBox.Show("Prestamo Actualizado", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    Eliminar.Visible = false;
                    Editar.Visible = false;
                    Guardar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Digite un codigo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        PrestamoLibros Mostrar = new PrestamoLibros();
        Persona mostrarDatos = new Persona();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string dato = TxtIdentificacion.Text;
            string codigo = TxtCodigo.Text;
            
            try
            {
                if ( (TxtCodigo.Text != "") && (TxtIdentificacion.Text != ""))
                {
                    MessageBox.Show("Eliga la opcion con la que desea buscar los datos");
                    limpiar();
                    Bloquear();
                }
                else if (TxtIdentificacion.Text != "")
                {
                    mostrarDatos = servicio.BuscarUsuario(dato);                    
                  
                    if (Mostrar != null)
                    {
                   //      Desbloquer();

                        TxtTipoIdenti.Text = mostrarDatos.TipoIdentidad;
                        TxtTipoUsu.Text = mostrarDatos.TipoUsuario;
                        TxtNombre.Text = mostrarDatos.Nombre;
                        TxtIdentificacion.Text = mostrarDatos.Identificacion;
                        TxtApellido.Text = mostrarDatos.Apellido;
                    }                    
                    else
                    {
                        MessageBox.Show("No se encontraron los datos de el usuario", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        limpiar(); //Bloquear();
                    }
                }
                else if (TxtCodigo.Text != "")
                {
                    Mostrar = servicio.BuscarCodigoPrestado(codigo);
                    if (Mostrar != null)
                    {
                      //  Desbloquer();

                        TxtCodigo.Text = Convert.ToString(Mostrar.Codigo);
                        TxtIdentificacion.Text = Mostrar.Identificacion;
                        TxtNombre.Text = Mostrar.Nombre;                        
                        TxtApellido.Text = Mostrar.Apellido;
                        TxtTipoIdenti.Text = Mostrar.TipoIdentidad;
                        TxtTipoUsu.Text = Mostrar.TipoUsuario;


                        Eliminar.Visible = true;
                        Editar.Visible = true;
                        Guardar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro registro del prestamo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        limpiar();  //    Bloquear();
                    }
                }                
                else
                {
                    MessageBox.Show("Digite un codigo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, dato no encontrado " +error.Message.ToString() );
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            try
            {
                if (  (TxtIdentificacion.Text != "") && (TxtCodigo.Text != "") && (TxtNombre.Text != "") && (TxtApellido.Text != "") && (TxtTipoIdenti.Text != "") && (TxtTipoUsu.Text != "") )
                {

                    respuesta = MessageBox.Show("Esta seguro de eliminarlo", "Bibliosoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        Libros.Fechaprestamo = TxtFechaPrestamo.Text;
                        Libros.Fechaentrega = TxtFechaDevolucion.Text;
                        Libros.TipoIdentidad = TxtTipoIdenti.Text;
                        Libros.TipoUsuario = TxtTipoUsu.Text;
                        Libros.Nombre = TxtNombre.Text;
                        Libros.Identificacion = TxtIdentificacion.Text;
                        Libros.Apellido = TxtApellido.Text;
                        Libros.Codigo = TxtCodigo.Text;
                        Libros.Estado = "Prestado";

                        string dato = servicio.Eliminar(Libros);
                        limpiar();
                        TxtIdentificacion.Focus();
                        MessageBox.Show(dato, "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        limpiar();
                    }

                    Eliminar.Visible = false;
                    Editar.Visible = false;
                    Guardar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Identificacion no encontrada");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaPrestamos prueba = new ListaPrestamos();
            prueba.ShowDialog();
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            Eliminar.Visible = false;
            Editar.Visible = false;
        }
    }// no tocar
}
