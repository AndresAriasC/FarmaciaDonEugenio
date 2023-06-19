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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateCategoryDtofarm createCategoryDtofarm = new CreateCategoryDtofarm();
            createCategoryDtofarm.CategoryName = txtCateName.Text;

            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(createCategoryDtofarm);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7159/api/Category", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Categoria agregada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al guardar la categoria {response.Content.ReadAsStringAsync().Result}");
                }

            }
        }
    }
}
