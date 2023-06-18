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
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EMPLEADOS";
            // 
            // txtEmpCode
            // 
            txtEmpCode.Location = new Point(42, 73);
            txtEmpCode.Name = "txtEmpCode";
            txtEmpCode.Size = new Size(100, 23);
            txtEmpCode.TabIndex = 1;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(196, 78);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(100, 23);
            txtEmpName.TabIndex = 2;
            // 
            // txtEmpLastName
            // 
            txtEmpLastName.Location = new Point(365, 82);
            txtEmpLastName.Name = "txtEmpLastName";
            txtEmpLastName.Size = new Size(100, 23);
            txtEmpLastName.TabIndex = 3;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(196, 271);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(75, 23);
            btnAgregarEmpleado.TabIndex = 4;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;

            // 
            // txtEmpEmail
            // 
            txtEmpEmail.Location = new Point(42, 143);
            txtEmpEmail.Name = "txtEmpEmail";
            txtEmpEmail.Size = new Size(100, 23);
            txtEmpEmail.TabIndex = 5;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Location = new Point(196, 143);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(100, 23);
            txtEmpPhone.TabIndex = 6;
            // 
            // txtEmpAdress
            // 
            txtEmpAdress.Location = new Point(365, 143);
            txtEmpAdress.Name = "txtEmpAdress";
            txtEmpAdress.Size = new Size(100, 23);
            txtEmpAdress.TabIndex = 7;
            // 
            // txtEmpSalary
            // 
            txtEmpSalary.Location = new Point(42, 212);
            txtEmpSalary.Name = "txtEmpSalary";
            txtEmpSalary.Size = new Size(100, 23);
            txtEmpSalary.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(196, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 338);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtEmpSalary);
            Controls.Add(txtEmpAdress);
            Controls.Add(txtEmpPhone);
            Controls.Add(txtEmpEmail);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(txtEmpLastName);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpCode);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dateTimePicker1;
    }
}