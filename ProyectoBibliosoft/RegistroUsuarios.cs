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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
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
        //          guardar
        ServicePrestamo servicio = new ServicePrestamo();
        Persona Libros = new Persona();
        public void limpiar()
        {
            TxtTipoIdenti.Text = "";
            TxtTipoUsu.Text = "";
            TxtNombre.Text = "";
            TxtIdentificacion.Text = "";
            TxtApellido.Text = "";
        }
        public void Bloquear()
        {
            TxtTipoIdenti.Enabled = true;
            TxtTipoUsu.Enabled = true;
            TxtNombre.Enabled = true;
            TxtIdentificacion.Enabled = true;
            TxtApellido.Enabled = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resultado; Bloquear();
            try
            {
                if (TxtIdentificacion.Text != "")
                {
                    resultado = MessageBox.Show("Desea eliminar al usuario?", "Bibliosoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    string dato;
                    if (resultado == DialogResult.OK)
                    {
                        Libros.TipoIdentidad = TxtTipoIdenti.Text;
                        Libros.TipoUsuario = TxtTipoUsu.Text;
                        Libros.Nombre = TxtNombre.Text;
                        Libros.Identificacion = TxtIdentificacion.Text;
                        Libros.Apellido = TxtApellido.Text;      

                        dato = servicio.EliminarUsuario(Libros);
                        limpiar();                        
                        MessageBox.Show(dato, "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        limpiar();
                    }
                    TxtIdentificacion.Focus();

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
      /*      if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
       */ }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string dato;
                if ( (!TxtTipoIdenti.Equals(string.Empty)) && (TxtIdentificacion.Text != "" ) && (TxtNombre.Text != "") && (TxtApellido.Text != "") && (TxtTipoUsu.Text != "") )
                {
                    Libros.Identificacion = TxtIdentificacion.Text;                    
                    Libros.Nombre = TxtNombre.Text;                    
                    Libros.Apellido = TxtApellido.Text;
                    Libros.TipoIdentidad = TxtTipoIdenti.Text;
                    Libros.TipoUsuario = TxtTipoUsu.Text;

                    limpiar();
                    dato = servicio.GuardarUsuario(Libros);
                    MessageBox.Show(dato, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Digite un codigo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        Persona Mostrar = new Persona();


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string dato = TxtIdentificacion.Text;
            try
            {
                if (TxtIdentificacion.Text != "")
                {
                    Mostrar = servicio.BuscarUsuario(dato);

                    if (Mostrar != null)
                    {
                        TxtTipoIdenti.Text = Mostrar.TipoIdentidad;
                        TxtTipoUsu.Text = Mostrar.TipoUsuario;
                        TxtNombre.Text = Mostrar.Nombre;
                        TxtIdentificacion.Text = Mostrar.Identificacion;
                        TxtApellido.Text = Mostrar.Apellido;

                        Eliminar.Visible = true;
                        Editar.Visible = true;
                        Guardar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Digite un codigo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
            Guardar.Visible = true;
            Eliminar.Visible = false;
            Editar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TxtIdentificacion.Equals(string.Empty))
                {
                    Libros.TipoIdentidad = TxtTipoIdenti.Text;
                    Libros.TipoUsuario = TxtTipoUsu.Text;
                    Libros.Nombre = TxtNombre.Text;
                    Libros.Identificacion = TxtIdentificacion.Text;
                    Libros.Apellido = TxtApellido.Text;

                    limpiar();
                    servicio.ActualizarUsuario(Libros);
                    MessageBox.Show("usuario Actualizado", "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    Guardar.Visible = true;
                    Eliminar.Visible = false;
                    Editar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Digite un codigo", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show( error.Message.ToString() );
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            TxtIdentificacion.Focus();
            Eliminar.Visible = false;
            Editar.Visible = false;
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtTipoIdenti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtTipoUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
