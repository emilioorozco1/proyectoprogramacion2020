using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Mecánico
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        Form2 login;
        menu menuprincipal;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void anadir_usuario_Click(object sender, EventArgs e)
        {
            login = new Form2();
            login.Show();
        }

        private void inicar_sesion_Click(object sender, EventArgs e)
        {
            if (Empleado.Autentificacion(txtUsuario.Text, txtContrasena.Text) > 0)
            {
                menuprincipal= new menu();
                menuprincipal.Show();
            }
            else
            {
                MessageBox.Show("Un dato introducido es incorrecto");
            }
        }
    }
}
