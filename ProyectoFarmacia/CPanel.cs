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

namespace ProyectoFarmacia
{
    public partial class CPanel : Form
    {
        private static int id = 0;
        private string UserName;
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al obtener la lista de productos: {ex.Message}");
                }
            }
        }
        //Llama a todos los usuarios de la API usuarios
        private async void GetAllUsers()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:7159/api/Users"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var users = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<UserDto>>(users);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de usuarios: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener la lista de usuarios: {ex.Message}");
            }
        }

        private async void GetAllClients()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:7159/api/Provider"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var clients = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<ClientDto>>(clients);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de clientes: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al obtener la lista de usuarios: {ex.Message}");
            }
        }


        private async void GetAllProviders()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:7159/api/Client"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var providers = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<List<UserDto>>(providers);
                            cargaDatos.DataSource = result.ToList();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener la lista de proveedores: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener la lista de usuarios: {ex.Message}");
            }
        }
        private async void btnProductos_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                tituloUrl.Text = "/Productos";
                GetAllProducts();
            }
            GetAllProducts();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked == true)
            {
                tituloUrl.Text = "/Empleados";
                GetAllUsers();
            }
            GetAllUsers();
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
            else if (rbClientes.Checked == true)
            {
                AddClient addClient = new AddClient();
                addClient.ShowDialog();
                GetAllClients();
            }
            else if (rbProveedores.Checked == true)
            {
                AddProvider addProvider = new AddProvider();
                addProvider.ShowDialog();
                GetAllProviders();
            }

        }

        //se encarga de modificar dependiendo de que opcion este seleccionada
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (rbClientes.Checked == true)
            {
                tituloUrl.Text = "/Clientes";
                GetAllClients();
            }
            GetAllClients();
        }
        //:V
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (rbClientes.Checked == true)
            {
                tituloUrl.Text = "/Proveedores";
                GetAllProviders();
            }
            GetAllProviders();
        }
    }
}
