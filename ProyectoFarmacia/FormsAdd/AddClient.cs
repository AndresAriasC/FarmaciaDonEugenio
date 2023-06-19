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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateClientDtofarm createClientDtofarm = new CreateClientDtofarm();
            createClientDtofarm.ClientName = txtClientName.Text;
            createClientDtofarm.ClientLastName = txtClientLastName.Text;
            createClientDtofarm.ClientEmail = txtClientEmail.Text;
            createClientDtofarm.ClientPhone = int.Parse(txtClientPhone.Text);
            createClientDtofarm.ClientAdress = txtClientAdress.Text;
            createClientDtofarm.ClientDate = DateTime.Parse(dtpClient.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(createClientDtofarm);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
               //CAMBIAR LINK DE ESTA VAINA
                var response = await client.PostAsync("https://localhost:7159/api/Users", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al guardar el Cliente {response.Content.ReadAsStringAsync().Result}");
                }

            }
        }
    }
}
