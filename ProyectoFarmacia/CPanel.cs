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

        private void Clear()
        {
            campoId.Text = string.Empty;
            campoCodigo.Text = string.Empty;
            campoName.Text = string.Empty;
            campoDescripcion.Text = string.Empty;
            campoCategoia.Text = string.Empty;
            campotxt6.Text = string.Empty;
            campotxt7.Text = string.Empty;
            campotxt8.Text = string.Empty;
            id = 0;
        }
        private void Desabilitar()
        {
            campoId.Enabled = false;
            campoName.Enabled = false;
            campoCodigo.Enabled = false;
            campoDescripcion.Enabled = false;
            campoCategoia.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////

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

        //Llama a todos los usuarios de la API categorias
        private async void GetAllCategories()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync("https://localhost:7159/api/Category"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var categories = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<CategoryDtofarm>>(categories);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de categorias: {response.StatusCode}");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error al obtener la lista de categorias: {ex.Message}");
                }
                catch (TaskCanceledException ex)
                {
                    MessageBox.Show($"Tiempo de espera agotado al obtener la lista de categorias: {ex.Message}");
                }
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////
     
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                lbl1.Text = "Product Id";
                lbl2.Text = "Product Name";
                lbl3.Text = "Product Code";
                lbl4.Text = "Product Desc.";
                lbl5.Text = "Product Category";
                tituloUrl.Text = "/Productos";
                lbl6.Text = "Empty";
                lbl7.Text = "Empty";
                lbl8.Text = "Empty";
                campotxt6.Enabled = false;
                campotxt7.Enabled = false;
                campotxt8.Enabled = false;

                Clear();
                GetAllProducts();
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if(rbCategory.Checked == true)
            {
                tituloUrl.Text = "/Categorias";
                lbl1.Text = "Category Id";
                lbl2.Text = "Category Name";
                lbl3.Text = "Empty";
                lbl4.Text = "Empty";
                lbl5.Text = "Empty";
                lbl6.Text = "Empty";
                lbl7.Text = "Empty";
                lbl8.Text = "Empty";
                campoCodigo.Enabled = false;
                campoDescripcion.Enabled = false;
                campoCategoia.Enabled = false;
                campotxt6.Enabled = false;
                campotxt7.Enabled = false;
                campotxt8.Enabled = false;

                Clear();
                GetAllCategories();
            }
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (rbEmpleados.Checked == true)
            {
                tituloUrl.Text = "/Empleados";
                lbl1.Text = "User Id";
                lbl2.Text = "User Name";
                lbl3.Text = "User Code";
                lbl4.Text = "User Email";
                lbl5.Text = "User Phone";
                lbl6.Text = "User LastName";
                lbl7.Text = "User Salary";
                lbl8.Text = "User Addres";
                campotxt6.Enabled = true;
                campotxt7.Enabled = true;
                campotxt8.Enabled = true;

                Clear();
                GetAllUsers();
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////


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
            else if (rbCategory.Checked == true)
            {
                AddCategory addcategory = new AddCategory();
                addcategory.ShowDialog();
                GetAllCategories();
            }
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////
        //se encarga de modificar dependiendo de que opcion este seleccionada

        private void cargaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in cargaDatos.Rows)
            {
                if (rbProductos.Checked == true)
                {
                    if (row.Index == e.RowIndex)
                    {
                        id = int.Parse(row.Cells[0].Value?.ToString());
                        GetProductById(id);
                    }
                }
                else if (rbEmpleados.Checked == true)
                {
                    if (row.Index == e.RowIndex)
                    {
                        id = int.Parse(row.Cells[0].Value?.ToString());
                        GetUserById(id);
                    }
                }
                else if (rbCategory.Checked== true)
                {
                    if(row.Index == e.RowIndex)
                    {
                        id = int.Parse(row.Cells[0].Value?.ToString());
                        GetCategoryById(id);
                    }

                }

            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////
        private async void GetProductById(int id)
        {

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
        private async void GetUserById(int id)
        {

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Users", id));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    UserDtofarm userDtofarm = JsonConvert.DeserializeObject<UserDtofarm>(data);
                    campoId.Text = userDtofarm.UserId.ToString();
                    campoCodigo.Text = userDtofarm.EmployeeCode.ToString();
                    campoName.Text = userDtofarm.UserName.ToString();
                    campoDescripcion.Text = userDtofarm.Email.ToString();
                    campoCategoia.Text = userDtofarm.Phone.ToString();
                    campotxt6.Text = userDtofarm.LastName.ToString();
                    campotxt7.Text = userDtofarm.Salary.ToString();
                    campotxt8.Text = userDtofarm.Adress.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el usuario: {response.StatusCode}");
                }
            }
        }

        private async void GetCategoryById(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Category", id));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    CategoryDtofarm categoryDtofarm = JsonConvert.DeserializeObject<CategoryDtofarm>(data);
                    campoId.Text = categoryDtofarm.CategoryId.ToString();
                    campoName.Text = categoryDtofarm.CategoryName.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la categoria: {response.StatusCode}");
                }
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                if (id != 0)
                {
                    UpdateProduct();
                }
            }
            else if (rbEmpleados.Checked == true)
            {
                if (id != 0)
                {
                    UpdateEmpleado();
                }
            }
            else if (rbCategory.Checked == true)
            {
                if (id != 0)
                {
                    UpdateCategory();
                }
            }
        }

        private async void UpdateEmpleado()
        {
            UserUpdateDtofarm userDto = new UserUpdateDtofarm();
            userDto.UserId = id;
            userDto.EmployeeCode = campoCodigo.Text;
            userDto.UserName = campoName.Text;
            userDto.LastName = campotxt6.Text;
            userDto.Email = campoDescripcion.Text;
            userDto.Phone = campoCategoia.Text;
            userDto.Adress = campotxt8.Text;
            userDto.Salary = Convert.ToInt32(campotxt7.Text);



            using (var client = new HttpClient())
            {
                var user = JsonConvert.SerializeObject(userDto);
                var content = new StringContent(user, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Users", id), content);

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Usuario actualizado");
                    GetAllUsers();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el Usuario: {response.StatusCode}");
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
                var product = JsonConvert.SerializeObject(productDto);
                var content = new StringContent(product, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "http://localhost:5226/api/Products", id), content);

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Producto actualizado");
                    GetAllProducts();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el Producto: {response.StatusCode}");
                }
            }
        }

        private async void UpdateCategory()
        {
            UpdateCategoryDtoFarm updateCategoryDtoFarm = new UpdateCategoryDtoFarm();
            updateCategoryDtoFarm.CategoryName = campoName.Text;
            updateCategoryDtoFarm.CategoryId = id;

            using (var client = new HttpClient())
            {
                var category = JsonConvert.SerializeObject(updateCategoryDtoFarm);
                var content = new StringContent(category, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Category", id), content);

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Categoria actualizada");
                    GetAllCategories();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar la categoria: {response.StatusCode}");
                }
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                if (id != 0)
                {
                    DeleteProduct();
                }
            }
            else if (rbEmpleados.Checked == true)
            {
                if (id != 0)
                {
                    DeleteEmpleado();
                }
            }
            else if (rbCategory.Checked == true)
            {
                if (id != 0)
                {
                    DeleteCategory();
                }
            }

        }

        private async void DeleteCategory()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7159/api/Category");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Category", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Categoria eliminada con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar la categoria: {response.StatusCode}");
            }
            Clear();
            GetAllCategories();
        }

        private async void DeleteEmpleado()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7159/api/Users");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:7159/api/Users", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el empleado: {response.StatusCode}");
            }
            Clear();
            GetAllUsers();
        }

        private async void DeleteProduct()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5226/api/Products");
                var response = await client.DeleteAsync(String.Format("{0}/{1}",
                    "http://localhost:5226/api/Products", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el producto: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
