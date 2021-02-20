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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.CenterToScreen();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "1234" && TxtUsuario.Text == "admin")
            {

                MessageBox.Show("Bienvenidos al sistema", "Bibliosoft", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InicioApp frm = new InicioApp();
                this.Hide();
                frm.Show();


            }
            else
            {
                if (TxtPassword.Text == "" && TxtUsuario.Text == "")
                {
                    MessageBox.Show("Usuario y Contraseña no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TxtPassword.Text == "")
                    {
                        MessageBox.Show("Usuario no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (TxtUsuario.Text == "")
                        {
                            MessageBox.Show("Contraseña no ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }

}
