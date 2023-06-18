namespace ProyectoFarmacia
{
    partial class CPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPanel));
            panel1 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            userActive = new Label();
            btnProductos = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            rbProveedores = new RadioButton();
            rbClientes = new RadioButton();
            rbEmpleados = new RadioButton();
            rbProductos = new RadioButton();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            btnProveedores = new Button();
            pictureBox6 = new PictureBox();
            btnClientes = new Button();
            btnEmpleados = new Button();
            cargaDatos = new DataGridView();
            label2 = new Label();
            tituloUrl = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            titulo = new Label();
            campoCodigo = new TextBox();
            campoName = new TextBox();
            campoDescripcion = new TextBox();
            campoCategoia = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            campoId = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cargaDatos).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 67);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1267, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 48);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 31);
            label1.TabIndex = 0;
            label1.Text = "Cpanel";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1202, 73);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // userActive
            // 
            userActive.AutoSize = true;
            userActive.BackColor = Color.Transparent;
            userActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userActive.ForeColor = Color.FromArgb(64, 64, 64);
            userActive.Location = new Point(1237, 72);
            userActive.Name = "userActive";
            userActive.Size = new Size(54, 28);
            userActive.TabIndex = 1;
            userActive.Text = "User";
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(0, 0, 64);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(88, 165);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(179, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 327);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(rbProveedores);
            panel7.Controls.Add(rbClientes);
            panel7.Controls.Add(rbEmpleados);
            panel7.Controls.Add(rbProductos);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(btnProveedores);
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(btnClientes);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(btnEmpleados);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(btnProductos);
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(294, 592);
            panel7.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(0, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 57);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 533);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 59);
            panel3.TabIndex = 20;
            // 
            // rbProveedores
            // 
            rbProveedores.AutoSize = true;
            rbProveedores.Location = new Point(23, 377);
            rbProveedores.Name = "rbProveedores";
            rbProveedores.Size = new Size(112, 24);
            rbProveedores.TabIndex = 17;
            rbProveedores.TabStop = true;
            rbProveedores.Text = "Proveedores";
            rbProveedores.UseVisualStyleBackColor = true;
            // 
            // rbClientes
            // 
            rbClientes.AutoSize = true;
            rbClientes.Location = new Point(23, 299);
            rbClientes.Name = "rbClientes";
            rbClientes.Size = new Size(82, 24);
            rbClientes.TabIndex = 16;
            rbClientes.TabStop = true;
            rbClientes.Text = "Clientes";
            rbClientes.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados
            // 
            rbEmpleados.AutoSize = true;
            rbEmpleados.Location = new Point(23, 217);
            rbEmpleados.Name = "rbEmpleados";
            rbEmpleados.Size = new Size(104, 24);
            rbEmpleados.TabIndex = 15;
            rbEmpleados.TabStop = true;
            rbEmpleados.Text = "Empleados";
            rbEmpleados.UseVisualStyleBackColor = true;
            // 
            // rbProductos
            // 
            rbProductos.AutoSize = true;
            rbProductos.Location = new Point(23, 136);
            rbProductos.Name = "rbProductos";
            rbProductos.Size = new Size(96, 24);
            rbProductos.TabIndex = 14;
            rbProductos.TabStop = true;
            rbProductos.Text = "Productos";
            rbProductos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 130);
            panel2.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(72, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(0, 0, 64);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(88, 407);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(179, 45);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(23, 407);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(0, 0, 64);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(88, 327);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(179, 45);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(0, 0, 64);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(88, 247);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(179, 45);
            btnEmpleados.TabIndex = 2;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // cargaDatos
            // 
            cargaDatos.AllowUserToAddRows = false;
            cargaDatos.AllowUserToDeleteRows = false;
            cargaDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cargaDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargaDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            cargaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cargaDatos.Location = new Point(302, 266);
            cargaDatos.Name = "cargaDatos";
            cargaDatos.ReadOnly = true;
            cargaDatos.RowHeadersWidth = 51;
            cargaDatos.RowTemplate.Height = 29;
            cargaDatos.Size = new Size(845, 344);
            cargaDatos.TabIndex = 12;
            cargaDatos.CellClick += cargaDatos_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(299, 69);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 13;
            label2.Text = "CPanel";
            // 
            // tituloUrl
            // 
            tituloUrl.AutoSize = true;
            tituloUrl.BackColor = Color.Transparent;
            tituloUrl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tituloUrl.ForeColor = Color.Gray;
            tituloUrl.Location = new Point(379, 69);
            tituloUrl.Name = "tituloUrl";
            tituloUrl.Size = new Size(24, 31);
            tituloUrl.TabIndex = 14;
            tituloUrl.Text = "/";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1151, 263);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(179, 45);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 0, 64);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1151, 314);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(179, 45);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Gray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1151, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(179, 45);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1151, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(179, 45);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.ForeColor = Color.Gray;
            titulo.Location = new Point(298, 232);
            titulo.Name = "titulo";
            titulo.Size = new Size(87, 31);
            titulo.TabIndex = 19;
            titulo.Text = "DATOS";
            // 
            // campoCodigo
            // 
            campoCodigo.Location = new Point(77, 40);
            campoCodigo.Name = "campoCodigo";
            campoCodigo.Size = new Size(125, 27);
            campoCodigo.TabIndex = 20;
            // 
            // campoName
            // 
            campoName.Location = new Point(210, 6);
            campoName.Name = "campoName";
            campoName.Size = new Size(217, 27);
            campoName.TabIndex = 21;
            // 
            // campoDescripcion
            // 
            campoDescripcion.Location = new Point(106, 75);
            campoDescripcion.Name = "campoDescripcion";
            campoDescripcion.Size = new Size(321, 27);
            campoDescripcion.TabIndex = 22;
            // 
            // campoCategoia
            // 
            campoCategoia.Location = new Point(291, 40);
            campoCategoia.Name = "campoCategoia";
            campoCategoia.Size = new Size(81, 27);
            campoCategoia.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(13, 43);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 26;
            label3.Text = "Codigo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(146, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 27;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(13, 78);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 28;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(211, 43);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 29;
            label6.Text = "Categoria";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(campoId);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(campoCodigo);
            panel5.Controls.Add(campoName);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(campoCategoia);
            panel5.Controls.Add(campoDescripcion);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(302, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(447, 115);
            panel5.TabIndex = 31;
            // 
            // campoId
            // 
            campoId.Location = new Point(77, 6);
            campoId.Name = "campoId";
            campoId.Size = new Size(53, 27);
            campoId.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(13, 6);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 32;
            label8.Text = "Id";
            // 
            // CPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1342, 659);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            Controls.Add(userActive);
            Controls.Add(titulo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(tituloUrl);
            Controls.Add(label2);
            Controls.Add(cargaDatos);
            Controls.Add(panel7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CPanel";
            Load += CPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)cargaDatos).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnProductos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel7;
        private Button btnProveedores;
        private PictureBox pictureBox6;
        private Button btnClientes;
        private Button btnEmpleados;
        private Label userActive;
        private Button btnSalir;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridView cargaDatos;
        private Label label2;
        private Label tituloUrl;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label titulo;
        private RadioButton rbProveedores;
        private RadioButton rbClientes;
        private RadioButton rbEmpleados;
        private RadioButton rbProductos;
        private Panel panel3;
        private Panel panel4;
        private TextBox campoCodigo;
        private TextBox campoName;
        private TextBox campoDescripcion;
        private TextBox campoCategoia;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private TextBox campoId;
        private Label label8;
    }
}