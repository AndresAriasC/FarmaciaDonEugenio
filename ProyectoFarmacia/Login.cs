﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFarmacia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conexion = new SqlConnection("Server=LAPTOP-7TMN5ABO;Database=DBFarmaciaDonEugenio;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

        private void btnLogin_Click(object sender, EventArgs e)
        {


            conexion.Open();

            string consulta = "select * from Users where EmployeeCode = '" + camCode.Text + "' and UserName='"+camName.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                this.Hide();
                ContainerFarmaciaAccess cont = new ContainerFarmaciaAccess();
                cont.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o codigo incorrecto");
            }
            conexion.Close();
        }
    }


}
