using Newtonsoft.Json;
using ProyectoFarmacia.Dto;
using ProyectoProgramacionIIAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFarmacia.FormsAdd
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private async Task btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            UserCreateDtofarm userCreateDtofarm = new UserCreateDtofarm();
            userCreateDtofarm.EmployeeCode = txtEmpCode.Text;
            userCreateDtofarm.UserName = txtEmpName.Text;
            userCreateDtofarm.LastName = txtEmpLastName.Text;
            userCreateDtofarm.Email = txtEmpEmail.Text;
            userCreateDtofarm.Phone = txtEmpPhone.Text;
            userCreateDtofarm.Adress = txtEmpAdress.Text;
            userCreateDtofarm.Salary = Convert.ToInt32(txtEmpSalary.Text);
            userCreateDtofarm.DateOfCreation = Convert.ToDateTime(dateTimePicker1.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(userCreateDtofarm);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7159/api/Users", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Empleado agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al guardar el Empleado {response.Content.ReadAsStringAsync().Result}");
                }

            }
        }
    }
}
