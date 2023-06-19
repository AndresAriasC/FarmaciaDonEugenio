using Newtonsoft.Json;
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
    public partial class AddProvider : Form
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateProviderDtofarm createProviderDtofarm = new CreateProviderDtofarm();
            createProviderDtofarm.RUTCode = txtRutCode.Text;
            createProviderDtofarm.ProviderName=txtProviderName.Text;
            createProviderDtofarm.ProviderEmail = txtProviderEmail.Text;
            createProviderDtofarm.ProviderPhone = int.Parse(txtProviderPhone.Text);
            createProviderDtofarm.ProviderDate = DateTime.Parse(dtpProvider.Text);

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(createProviderDtofarm);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7159/api/Provider", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al guardar el Proveedor {response.Content.ReadAsStringAsync().Result}");
                }

            }
        }
    }
}
