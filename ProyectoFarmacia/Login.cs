using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using ProyectoProgramacionIIAPI;
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
            try
            {

                conexion.Open();
                string consulta = "select * from Users where EmployeeCode = '" + campoCode.Text + "' and UserName='" + campoName.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    this.Hide();
                    string userName = campoName.Text;
                    CPanel cont = new CPanel(userName);
                    cont.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o codigo incorrecto");
                }
                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }


}
