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
            campoCodigo = new TextBox();
            campoName = new TextBox();
            campoDescripcion = new TextBox();
            campoCategoria = new TextBox();
            btnAgregarProducto = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // campoCodigo
            // 
            campoCodigo.BackColor = SystemColors.Window;
            campoCodigo.Location = new Point(61, 89);
            campoCodigo.Margin = new Padding(3, 2, 3, 2);
            campoCodigo.Name = "campoCodigo";
            campoCodigo.Size = new Size(110, 23);
            campoCodigo.TabIndex = 1;
            // 
            // campoName
            // 
            campoName.Location = new Point(282, 89);
            campoName.Margin = new Padding(3, 2, 3, 2);
            campoName.Name = "campoName";
            campoName.Size = new Size(110, 23);
            campoName.TabIndex = 2;
            // 
            // campoDescripcion
            // 
            campoDescripcion.Location = new Point(282, 166);
            campoDescripcion.Margin = new Padding(3, 2, 3, 2);
            campoDescripcion.Name = "campoDescripcion";
            campoDescripcion.Size = new Size(110, 23);
            campoDescripcion.TabIndex = 3;
            // 
            // campoCategoria
            // 
            campoCategoria.Location = new Point(61, 166);
            campoCategoria.Margin = new Padding(3, 2, 3, 2);
            campoCategoria.Name = "campoCategoria";
            campoCategoria.Size = new Size(110, 23);
            campoCategoria.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.ForestGreen;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Location = new Point(182, 225);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(93, 39);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 42);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 72);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 149);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 149);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Descripción";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(456, 301);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(campoCategoria);
            Controls.Add(campoDescripcion);
            Controls.Add(campoName);
            Controls.Add(campoCodigo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProduct";
            Text = "AddProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox campoCodigo;
        private TextBox campoName;
        private TextBox campoDescripcion;
        private TextBox campoCategoria;
        private Button btnAgregarProducto;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}