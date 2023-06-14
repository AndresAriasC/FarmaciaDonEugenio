namespace Farmaciaajeje
{
    partial class frmProducto
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
            label1 = new Label();
            txtProId = new TextBox();
            txtProName = new TextBox();
            dgvProducts = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            txtProCode = new TextBox();
            txtProDesc = new TextBox();
            txtCate = new TextBox();
            dtpProCreate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE PRODUCTOS";
            // 
            // txtProId
            // 
            txtProId.Location = new Point(80, 63);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(100, 23);
            txtProId.TabIndex = 1;
            // 
            // txtProName
            // 
            txtProName.Location = new Point(397, 66);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(100, 23);
            txtProName.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 230);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(800, 220);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(105, 165);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(256, 165);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(413, 165);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(567, 165);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtProCode
            // 
            txtProCode.Location = new Point(244, 66);
            txtProCode.Name = "txtProCode";
            txtProCode.Size = new Size(100, 23);
            txtProCode.TabIndex = 8;
            // 
            // txtProDesc
            // 
            txtProDesc.Location = new Point(567, 66);
            txtProDesc.Name = "txtProDesc";
            txtProDesc.Size = new Size(100, 23);
            txtProDesc.TabIndex = 9;
            // 
            // txtCate
            // 
            txtCate.Location = new Point(80, 121);
            txtCate.Name = "txtCate";
            txtCate.Size = new Size(100, 23);
            txtCate.TabIndex = 10;
            // 
            // dtpProCreate
            // 
            dtpProCreate.Format = DateTimePickerFormat.Short;
            dtpProCreate.Location = new Point(244, 118);
            dtpProCreate.Name = "dtpProCreate";
            dtpProCreate.Size = new Size(119, 23);
            dtpProCreate.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 45);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 12;
            label2.Text = "ID producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 45);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 13;
            label3.Text = "Código Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 45);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 14;
            label4.Text = "Nombre producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 48);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 15;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 103);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 16;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 98);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha añadido";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpProCreate);
            Controls.Add(txtCate);
            Controls.Add(txtProDesc);
            Controls.Add(txtProCode);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProducts);
            Controls.Add(txtProName);
            Controls.Add(txtProId);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "Productos";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProId;
        private TextBox txtProName;
        private DataGridView dgvProducts;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private TextBox txtProCode;
        private TextBox txtProDesc;
        private TextBox txtCate;
        private DateTimePicker dtpProCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}