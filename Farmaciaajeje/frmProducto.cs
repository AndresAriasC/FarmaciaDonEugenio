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

namespace Farmaciaajeje
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        private static int id = 0;
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCate.Text = string.Empty;
            txtProCode.Text = string.Empty;
            txtProDesc.Text = string.Empty;
            txtProId.Text = string.Empty;
            txtProName.Text = string.Empty;
            id = 0;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private async void GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                using (var response = await 
                    client.GetAsync("https://localhost:7159/api/ProyectoProgramacionIIAPI\r\n"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var products = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<ProductDto>>(products);
                        dgvProducts.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de productos: {response.StatusCode}");
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProducts();
        }

        private async void AddProducts()
        {
            CreateProductDto createProductDto = new CreateProductDto();
            createProductDto.ProductName = txtProName.Text;
            createProductDto.ProductCode = txtProCode.Text;
            createProductDto.ProductDescription = txtProDesc.Text;
            //createProductDto.CategoryId= txtCate.Text;
            //nose aqui cómoo se pone
            //createProductDto.DateOfCreation = dtpProCreate.Text;
            using (var client = new HttpClient())
            {
                var serializedStudent = JsonConvert.SerializeObject(createProductDto);
                var content = new StringContent(serializedStudent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7159/api/ProyectoProgramacionIIAPI", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto agregado");
                else
                    MessageBox.Show($"Error al guardar el producto {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetProductById(id);
                }
            }
        }

        private async void GetProductById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7184/api/ProyectoProgramacionIIAPI", id));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    ProductDto productDto = JsonConvert.DeserializeObject<ProductDto>(data);
                    txtProId.Text = productDto.ProductId.ToString();
                    txtProName.Text = productDto.ProductName;
                    txtProCode.Text = productDto.ProductCode;
                    txtProDesc.Text = productDto.ProductDescription;
                    txtCate.Text = productDto.CategoryId.ToString();
                    dtpProCreate.Text = productDto.DateOfCreation.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateProduct();
        }

        private async void UpdateProduct()
        {
            UpdateProductDto productDto = new UpdateProductDto();
            productDto.ProductId = id;
            productDto.ProductName = txtProName.Text;
            productDto.ProductCode = txtProCode.Text;
            productDto.ProductDescription = txtProDesc.Text;

            //creo que se puede reutilizar esa variable :vvv
            productDto.CategoryId = id;



            using (var client = new HttpClient())
            {
                var student = JsonConvert.SerializeObject(productDto);
                var content = new StringContent(student, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Students", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado");
                else
                    MessageBox.Show($"Error al actualizar el producto: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteProduct();
        }

        private async void DeleteProduct()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7159/api/Students");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7184/api/Students", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el producto: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }
    }
}
