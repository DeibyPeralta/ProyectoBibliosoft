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
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatosLibro_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
            Editar.Visible = false;
            Eliminar.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar.Visible = false;
            Eliminar.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InicioApp frm = new InicioApp();
            this.Hide();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        

        public void limpiar()
        {
            TxtNombre.Text = "";
            TxtArea.Text = "";
            TxtNumPaginas.Text = "";
            TxtCodigo.Text = "";
            TxtAutor.Text = "";
            TxtAutor2.Text = "";
            TxtPais.Text = "";
            TxtEditorial.Text = "";
            TxtDireccion.Text = "";
            TxtId.Text = "";
            TxtCiudad.Text = "";
            TxtTelefono.Text = "";
            TxtCantidad.Text = "";
        }

        ServiceLibros servicios = new ServiceLibros();
        Libro ObjLibro = new Libro();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if(  (TxtCodigo.Text != "") && (TxtNombre.Text != "") && (TxtArea.Text != "") && (TxtNumPaginas.Text != "") && (TxtAutor.Text != "") && (TxtPais.Text != "") && (TxtCantidad.Text != "") && (TxtId.Text != "") && (TxtEditorial.Text != ""))     
                {
                    ObjLibro.Codigo = TxtCodigo.Text;
                    ObjLibro.Area = TxtArea.Text;                    
                    ObjLibro.Autor = TxtAutor.Text;
                    ObjLibro.Autor2 = TxtAutor2.Text;
                    ObjLibro.Nombre = TxtNombre.Text;
                    ObjLibro.Ciudad = TxtCiudad.Text;
                    ObjLibro.Pais = TxtPais.Text;
                    ObjLibro.NumeroPaginas = TxtNumPaginas.Text;                    
                    ObjLibro.FechaImpresion = TxtFecha.Text;
                    ObjLibro.Id = TxtId.Text;
                    ObjLibro.NombreEditorial = TxtEditorial.Text;
                    ObjLibro.Direccion = TxtDireccion.Text;
                    ObjLibro.Telefono = TxtTelefono.Text;
                    ObjLibro.Estado = "Disponible";
                    ObjLibro.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                    
                    limpiar();
                   string dato= servicios.GuardarLibros(ObjLibro);
                    TxtCodigo.Focus();
                    MessageBox.Show(dato, "Biblisoft", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Digite un los campos requeridos", "Biblisoft", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        Libro librox = new Libro();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string dato = TxtCodigo.Text;

            try
            {
                if (!TxtCodigo.Equals(string.Empty))
                {
                    librox = servicios.BuscarCodigo(dato);

                    if (librox != null)
                    {
                        TxtCodigo.Text = librox.Codigo;
                        TxtArea.Text = librox.Area;
                        TxtNumPaginas.Text = librox.NumeroPaginas;
                        TxtNombre.Text = librox.Nombre;
                        TxtAutor.Text = librox.Autor;
                        TxtAutor2.Text = librox.Autor2;
                        TxtPais.Text = librox.Pais;
                        TxtFecha.Text = librox.FechaImpresion;
                        TxtCantidad.Text = Convert.ToString(librox.Cantidad);
                        TxtEditorial.Text = librox.NombreEditorial;
                        TxtDireccion.Text = librox.Direccion;
                        TxtId.Text = librox.Id;
                        TxtCiudad.Text = librox.Ciudad;
                        TxtTelefono.Text = librox.Telefono;

                        Eliminar.Visible = true;
                        Editar.Visible = true;
                        Guardar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el codigo solicitado", "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        private void TxtNumPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (Char.IsLetter(e.KeyChar))
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
            }*/
        }

        private void TxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            try
            {
                resultado = MessageBox.Show("Esta seguro de eliminarlo?", "Bibliosoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    ObjLibro.Codigo = TxtCodigo.Text;
                    ObjLibro.Area = TxtArea.Text;
                    ObjLibro.NumeroPaginas = TxtNumPaginas.Text;
                    ObjLibro.Nombre = TxtNombre.Text;
                    ObjLibro.Autor = TxtAutor.Text;
                    ObjLibro.Autor2 = TxtAutor2.Text;
                    ObjLibro.Pais = TxtPais.Text;
                    ObjLibro.FechaImpresion = TxtFecha.Text;
                    ObjLibro.Cantidad = Int32.Parse(TxtCantidad.Text);
                    ObjLibro.Estado = "Disponible";

                    ObjLibro.NombreEditorial = TxtEditorial.Text;
                    ObjLibro.Direccion = TxtDireccion.Text;
                    ObjLibro.Id = TxtId.Text;
                    ObjLibro.Ciudad = TxtCiudad.Text;
                    ObjLibro.Telefono = TxtTelefono.Text;

                    servicios.Eliminar(ObjLibro);
                    MessageBox.Show("Se elimino el libro");
                    limpiar();
                    Guardar.Visible = true;
                    Eliminar.Visible = false;
                    Editar.Visible = false;

                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjLibro.Codigo = TxtCodigo.Text;
                ObjLibro.Area = TxtArea.Text;
                ObjLibro.NumeroPaginas = TxtNumPaginas.Text;
                ObjLibro.Nombre = TxtNombre.Text;
                ObjLibro.Autor = TxtAutor.Text;
                ObjLibro.Autor2 = TxtAutor2.Text;
                ObjLibro.Pais = TxtPais.Text;
                ObjLibro.FechaImpresion = TxtFecha.Text;
                ObjLibro.Estado = "Disponible";
                ObjLibro.Cantidad = Int32.Parse(TxtCantidad.Text);
                

                ObjLibro.NombreEditorial = TxtEditorial.Text;
                ObjLibro.Direccion = TxtDireccion.Text;
                ObjLibro.Id = TxtId.Text;
                ObjLibro.Ciudad = TxtCiudad.Text;
                ObjLibro.Telefono = TxtTelefono.Text;

                limpiar();
                servicios.Actualizar(ObjLibro);
                MessageBox.Show("Prestamo Actualizado", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                Guardar.Visible = true;
                Eliminar.Visible = false;
                Editar.Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message.ToString());
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEditorial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
