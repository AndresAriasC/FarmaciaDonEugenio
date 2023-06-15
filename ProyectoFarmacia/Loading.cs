using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFarmacia
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void carga_Tick(object sender, EventArgs e)
        {
            progressBarInicio.Increment(4);
            label1.Text = progressBarInicio.Value.ToString() + "%";

            if (progressBarInicio.Value == progressBarInicio.Maximum)
            {
                carga.Stop();
                this.Hide();
                Login frmLogin = new Login();
                frmLogin.ShowDialog();
            }
        }
    }
}
