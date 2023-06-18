namespace ProyectoFarmacia.FormsAdd
{
    partial class AddProduct
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
            campoCodigo = new TextBox();
            campoName = new TextBox();
            campoDescripcion = new TextBox();
            campoCategoria = new TextBox();
            btnAgregarProducto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 7);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar Producto";
            // 
            // campoCodigo
            // 
            campoCodigo.Location = new Point(6, 89);
            campoCodigo.Margin = new Padding(3, 2, 3, 2);
            campoCodigo.Name = "campoCodigo";
            campoCodigo.Size = new Size(110, 23);
            campoCodigo.TabIndex = 1;
            // 
            // campoName
            // 
            campoName.Location = new Point(143, 89);
            campoName.Margin = new Padding(3, 2, 3, 2);
            campoName.Name = "campoName";
            campoName.Size = new Size(110, 23);
            campoName.TabIndex = 2;
            // 
            // campoDescripcion
            // 
            campoDescripcion.Location = new Point(280, 89);
            campoDescripcion.Margin = new Padding(3, 2, 3, 2);
            campoDescripcion.Name = "campoDescripcion";
            campoDescripcion.Size = new Size(110, 23);
            campoDescripcion.TabIndex = 3;
            // 
            // campoCategoria
            // 
            campoCategoria.Location = new Point(143, 142);
            campoCategoria.Margin = new Padding(3, 2, 3, 2);
            campoCategoria.Name = "campoCategoria";
            campoCategoria.Size = new Size(110, 23);
            campoCategoria.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(189, 242);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(82, 22);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 381);
            Controls.Add(btnAgregarProducto);
            Controls.Add(campoCategoria);
            Controls.Add(campoDescripcion);
            Controls.Add(campoName);
            Controls.Add(campoCodigo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox campoCodigo;
        private TextBox campoName;
        private TextBox campoDescripcion;
        private TextBox campoCategoria;
        private Button btnAgregarProducto;
    }
}