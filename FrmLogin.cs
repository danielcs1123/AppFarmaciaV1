using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppFarmaciaV1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Acceso objAcceso = new Acceso();
            objAcceso.Usuario = txtUsuario.Text;
            objAcceso.Password = txtPassword.Text;

            if (objAcceso.Login()>0)
            {
                this.Visible = false;
                FrmPrincipal ofrm = new FrmPrincipal();
                ofrm.Show();
            }
            else
            {
                MessageBox.Show("Error al ingresar:\r\n Verificar su Usuario y Contraseña", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
