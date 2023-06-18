using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ProyectoProgramacionIIAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ProyectoFarmacia.Dto;
using ProyectoFarmacia.FormsAdd;
using System.Globalization;

namespace ProyectoFarmacia
{
    public partial class CPanel : Form
    {
        private static int id = 0;
        private string UserName;
        public DataGridView WinData { get { return cargaDatos; } }
        public CPanel(string userName)
        {
            InitializeComponent();
            this.UserName = userName;
        }

        private void CPanel_Load(object sender, EventArgs e)
        {
            userActive.Text = UserName;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Llama a todos lo productos de la API productos
        private async void GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync("http://localhost:5226/api/Products"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var products = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<ProductDto>>(products);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de productos: {response.StatusCode}");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error al obtener la lista de productos: {ex.Message}");
                }
                catch (TaskCanceledException ex)
                {
                    MessageBox.Show($"Tiempo de espera agotado al obtener la lista de productos: {ex.Message}");
                }
            }
        }
        //Llama a todos los usuarios de la API usuarios
        private async void GetAllUsers()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync("https://localhost:7159/api/Users"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var users = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<UserDtofarm>>(users);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de usuarios: {response.StatusCode}");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error al obtener la lista de usuarios: {ex.Message}");
                }
                catch (TaskCanceledException ex)
                {
                    MessageBox.Show($"Tiempo de espera agotado al obtener la lista de usuarios: {ex.Message}");
                }
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                tituloUrl.Text = "/Productos";
                GetAllProducts();
            }
            else if (rbEmpleados.Checked == true)
            {
                GetAllProducts();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (rbEmpleados.Checked == true)
            {
                tituloUrl.Text = "/Empleados";
                GetAllUsers();
            }
            else if (rbEmpleados.Checked == true)
            {
                GetAllUsers();
            }
        }
        //se encarga de agregar dependiendo de que boton esta seleccionado
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                AddProduct addproduct = new AddProduct();
                addproduct.ShowDialog();
                GetAllProducts();
            }
            else if (rbEmpleados.Checked == true)
            {
                AddUser adduser = new AddUser();
                adduser.ShowDialog();
                GetAllUsers();
            }

        }

        //se encarga de modificar dependiendo de que opcion este seleccionada

        private void cargaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in cargaDatos.Rows)
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
            string fechaTexto = "18/06/2023";
            string formatoFecha = "dd/MM/yyyy";
            DateTime fecha;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "http://localhost:5226/api/Products", id));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    ProductDtofarm productDtofarm = JsonConvert.DeserializeObject<ProductDtofarm>(data);
                    campoId.Text = productDtofarm.ProductId.ToString();
                    campoCodigo.Text = productDtofarm.ProductCode.ToString();
                    campoName.Text = productDtofarm.ProductName.ToString();
                    campoDescripcion.Text = productDtofarm.ProductDescription.ToString();
                    campoCategoia.Text = productDtofarm.CategoryId.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                if (id != 0)
                {
                    UpdateProduct();
                }
            }
        }

        private async void UpdateProduct()
        {
            ProductUpdateDtofarm productDto = new ProductUpdateDtofarm();
            productDto.ProductId = id;
            productDto.ProductCode = campoCodigo.Text;
            productDto.ProductName = campoName.Text;
            productDto.ProductDescription = campoDescripcion.Text;
            productDto.CategoryId = Convert.ToInt32(campoCategoia.Text);

            using (var client = new HttpClient())
            {
                var student = JsonConvert.SerializeObject(productDto);
                var content = new StringContent(student, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "http://localhost:5226/api/Products", id), content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado");

                else
                    MessageBox.Show($"Error al actualizar el Producto: {response.StatusCode}");
            }
        }
    }
}
