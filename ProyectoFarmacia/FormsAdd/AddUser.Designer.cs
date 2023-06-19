namespace ProyectoFarmacia.FormsAdd
{
    partial class AddUser
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
            txtEmpCode = new TextBox();
            txtEmpName = new TextBox();
            txtEmpLastName = new TextBox();
            btnAgregarEmpleado = new Button();
            txtEmpEmail = new TextBox();
            txtEmpPhone = new TextBox();
            txtEmpAdress = new TextBox();
            txtEmpSalary = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EMPLEADOS";
            // 
            // txtEmpCode
            // 
            txtEmpCode.Location = new Point(42, 95);
            txtEmpCode.Name = "txtEmpCode";
            txtEmpCode.Size = new Size(100, 23);
            txtEmpCode.TabIndex = 1;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(196, 100);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(100, 23);
            txtEmpName.TabIndex = 2;
            // 
            // txtEmpLastName
            // 
            txtEmpLastName.Location = new Point(365, 104);
            txtEmpLastName.Name = "txtEmpLastName";
            txtEmpLastName.Size = new Size(100, 23);
            txtEmpLastName.TabIndex = 3;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.ForestGreen;
            btnAgregarEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnAgregarEmpleado.Location = new Point(207, 225);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(89, 39);
            btnAgregarEmpleado.TabIndex = 4;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // txtEmpEmail
            // 
            txtEmpEmail.Location = new Point(42, 165);
            txtEmpEmail.Name = "txtEmpEmail";
            txtEmpEmail.Size = new Size(100, 23);
            txtEmpEmail.TabIndex = 5;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(196, 165);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(100, 23);
            txtEmpPhone.TabIndex = 6;
            // 
            // txtEmpAdress
            // 
            txtEmpAdress.Location = new Point(365, 165);
            txtEmpAdress.Name = "txtEmpAdress";
            txtEmpAdress.Size = new Size(100, 23);
            txtEmpAdress.TabIndex = 7;
            // 
            // txtEmpSalary
            // 
            txtEmpSalary.Location = new Point(42, 234);
            txtEmpSalary.Name = "txtEmpSalary";
            txtEmpSalary.Size = new Size(100, 23);
            txtEmpSalary.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 43);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 77);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 82);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 82);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 147);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 147);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "N° de teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 147);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 15;
            label7.Text = "Dirección";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 216);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 16;
            label8.Text = "Salario";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(485, 338);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtEmpSalary);
            Controls.Add(txtEmpAdress);
            Controls.Add(txtEmpPhone);
            Controls.Add(txtEmpEmail);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(txtEmpLastName);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpCode);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddUser";
            Text = "Agregar empleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpCode;
        private TextBox txtEmpName;
        private TextBox txtEmpLastName;
        private Button btnAgregarEmpleado;
        private TextBox txtEmpEmail;
        private TextBox txtEmpPhone;
        private TextBox txtEmpAdress;
        private TextBox txtEmpSalary;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}