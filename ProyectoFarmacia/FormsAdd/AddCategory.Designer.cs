namespace ProyectoFarmacia.FormsAdd
{
    partial class AddCategory
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
            txtCateName = new TextBox();
            label2 = new Label();
            btnAgregar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 0;
            label1.Text = "CATEGORÍAS DE PRODUCTO";
            // 
            // txtCateName
            // 
            txtCateName.Location = new Point(98, 84);
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(100, 23);
            txtCateName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(98, 160);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 41);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSpringGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 49);
            panel1.TabIndex = 4;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(308, 264);
            Controls.Add(panel1);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(txtCateName);
            Name = "AddCategory";
            Text = "Categorías";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCateName;
        private Label label2;
        private Button btnAgregar;
        private Panel panel1;
    }
}