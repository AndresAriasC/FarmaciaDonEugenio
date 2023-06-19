using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProyectoFarmacia.Dto;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoFarmacia.FormsAdd
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            ProductCreateDtofarm productCreateDtofarm = new ProductCreateDtofarm();
            productCreateDtofarm.ProductCode = campoCodigo.Text;
            productCreateDtofarm.ProductName = campoName.Text;
            productCreateDtofarm.ProductDescription = campoDescripcion.Text;
            productCreateDtofarm.CategoryId = Convert.ToInt32(campoCategoria.Text);
            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(productCreateDtofarm);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5226/api/Products", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al guardar el Producto {response.Content.ReadAsStringAsync().Result}");
                }

            }
        }
    }
}
