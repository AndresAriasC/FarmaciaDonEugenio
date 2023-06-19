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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 12);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EMPLEADOS";
            // 
            // txtEmpCode
            // 
            txtEmpCode.Location = new Point(48, 97);
            txtEmpCode.Margin = new Padding(3, 4, 3, 4);
            txtEmpCode.Name = "txtEmpCode";
            txtEmpCode.Size = new Size(114, 27);
            txtEmpCode.TabIndex = 1;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(224, 104);
            txtEmpName.Margin = new Padding(3, 4, 3, 4);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(114, 27);
            txtEmpName.TabIndex = 2;
            // 
            // txtEmpLastName
            // 
            txtEmpLastName.Location = new Point(417, 109);
            txtEmpLastName.Margin = new Padding(3, 4, 3, 4);
            txtEmpLastName.Name = "txtEmpLastName";
            txtEmpLastName.Size = new Size(114, 27);
            txtEmpLastName.TabIndex = 3;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(224, 361);
            btnAgregarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(86, 31);
            btnAgregarEmpleado.TabIndex = 4;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // txtEmpEmail
            // 
            txtEmpEmail.Location = new Point(48, 191);
            txtEmpEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmpEmail.Name = "txtEmpEmail";
            txtEmpEmail.Size = new Size(114, 27);
            txtEmpEmail.TabIndex = 5;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(224, 191);
            txtEmpPhone.Margin = new Padding(3, 4, 3, 4);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(114, 27);
            txtEmpPhone.TabIndex = 6;
            // 
            // txtEmpAdress
            // 
            txtEmpAdress.Location = new Point(417, 191);
            txtEmpAdress.Margin = new Padding(3, 4, 3, 4);
            txtEmpAdress.Name = "txtEmpAdress";
            txtEmpAdress.Size = new Size(114, 27);
            txtEmpAdress.TabIndex = 7;
            // 
            // txtEmpSalary
            // 
            txtEmpSalary.Location = new Point(48, 283);
            txtEmpSalary.Margin = new Padding(3, 4, 3, 4);
            txtEmpSalary.Name = "txtEmpSalary";
            txtEmpSalary.Size = new Size(114, 27);
            txtEmpSalary.TabIndex = 8;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 451);
            Controls.Add(txtEmpSalary);
            Controls.Add(txtEmpAdress);
            Controls.Add(txtEmpPhone);
            Controls.Add(txtEmpEmail);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(txtEmpLastName);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpCode);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "Agregar empleados";
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
    }
}