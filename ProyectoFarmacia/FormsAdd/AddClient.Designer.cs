namespace ProyectoFarmacia.FormsAdd
{
    partial class AddClient
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
            txtClientName = new TextBox();
            txtClientLastName = new TextBox();
            txtClientEmail = new TextBox();
            txtClientPhone = new TextBox();
            txtClientAdress = new TextBox();
            dtpClient = new DateTimePicker();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(44, 49);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(100, 23);
            txtClientName.TabIndex = 0;
            // 
            // txtClientLastName
            // 
            txtClientLastName.Location = new Point(179, 49);
            txtClientLastName.Name = "txtClientLastName";
            txtClientLastName.Size = new Size(100, 23);
            txtClientLastName.TabIndex = 1;
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(337, 49);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(100, 23);
            txtClientEmail.TabIndex = 2;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(44, 118);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(100, 23);
            txtClientPhone.TabIndex = 3;
            // 
            // txtClientAdress
            // 
            txtClientAdress.Location = new Point(179, 118);
            txtClientAdress.Name = "txtClientAdress";
            txtClientAdress.Size = new Size(100, 23);
            txtClientAdress.TabIndex = 4;
            // 
            // dtpClient
            // 
            dtpClient.Format = DateTimePickerFormat.Short;
            dtpClient.Location = new Point(308, 118);
            dtpClient.Name = "dtpClient";
            dtpClient.Size = new Size(88, 23);
            dtpClient.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(183, 195);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 324);
            Controls.Add(btnAgregar);
            Controls.Add(dtpClient);
            Controls.Add(txtClientAdress);
            Controls.Add(txtClientPhone);
            Controls.Add(txtClientEmail);
            Controls.Add(txtClientLastName);
            Controls.Add(txtClientName);
            Name = "AddClient";
            Text = "AddClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClientName;
        private TextBox txtClientLastName;
        private TextBox txtClientEmail;
        private TextBox txtClientPhone;
        private TextBox txtClientAdress;
        private DateTimePicker dtpClient;
        private Button btnAgregar;
    }
}