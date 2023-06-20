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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // campoCodigo
            // 
            campoCodigo.BackColor = SystemColors.Window;
            campoCodigo.Location = new Point(100, 23);
            campoCodigo.Name = "campoCodigo";
            campoCodigo.Size = new Size(125, 27);
            campoCodigo.TabIndex = 1;
            // 
            // campoName
            // 
            campoName.Location = new Point(112, 66);
            campoName.Name = "campoName";
            campoName.Size = new Size(334, 27);
            campoName.TabIndex = 2;
            // 
            // campoDescripcion
            // 
            campoDescripcion.Location = new Point(145, 105);
            campoDescripcion.Name = "campoDescripcion";
            campoDescripcion.Size = new Size(301, 27);
            campoDescripcion.TabIndex = 3;
            // 
            // campoCategoria
            // 
            campoCategoria.Location = new Point(360, 23);
            campoCategoria.Name = "campoCategoria";
            campoCategoria.Size = new Size(86, 27);
            campoCategoria.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(0, 64, 0);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Location = new Point(284, 138);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(162, 41);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "AGREGAR";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 50);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(473, 0);
            button1.Name = "button1";
            button1.Size = new Size(48, 50);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 69);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 26);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 112);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 10;
            label5.Text = "Descripción";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(campoCodigo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(campoName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(campoDescripcion);
            panel2.Controls.Add(campoCategoria);
            panel2.Controls.Add(btnAgregarProducto);
            panel2.Location = new Point(16, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 202);
            panel2.TabIndex = 11;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(521, 295);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
        private Button button1;
    }
}