namespace ProyectoFarmacia.FormsAdd
{
    partial class AddProvider
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
            txtRutCode = new TextBox();
            txtProviderName = new TextBox();
            txtProviderEmail = new TextBox();
            txtProviderPhone = new TextBox();
            dtpProvider = new DateTimePicker();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtRutCode
            // 
            txtRutCode.Location = new Point(56, 38);
            txtRutCode.Name = "txtRutCode";
            txtRutCode.Size = new Size(100, 23);
            txtRutCode.TabIndex = 0;
            // 
            // txtProviderName
            // 
            txtProviderName.Location = new Point(217, 45);
            txtProviderName.Name = "txtProviderName";
            txtProviderName.Size = new Size(100, 23);
            txtProviderName.TabIndex = 1;
            // 
            // txtProviderEmail
            // 
            txtProviderEmail.Location = new Point(388, 46);
            txtProviderEmail.Name = "txtProviderEmail";
            txtProviderEmail.Size = new Size(100, 23);
            txtProviderEmail.TabIndex = 2;
            // 
            // txtProviderPhone
            // 
            txtProviderPhone.Location = new Point(56, 106);
            txtProviderPhone.Name = "txtProviderPhone";
            txtProviderPhone.Size = new Size(100, 23);
            txtProviderPhone.TabIndex = 3;
            // 
            // dtpProvider
            // 
            dtpProvider.Format = DateTimePickerFormat.Short;
            dtpProvider.Location = new Point(239, 111);
            dtpProvider.Name = "dtpProvider";
            dtpProvider.Size = new Size(200, 23);
            dtpProvider.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(199, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AddProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 318);
            Controls.Add(btnAgregar);
            Controls.Add(dtpProvider);
            Controls.Add(txtProviderPhone);
            Controls.Add(txtProviderEmail);
            Controls.Add(txtProviderName);
            Controls.Add(txtRutCode);
            Name = "AddProvider";
            Text = "AddProvider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRutCode;
        private TextBox txtProviderName;
        private TextBox txtProviderEmail;
        private TextBox txtProviderPhone;
        private DateTimePicker dtpProvider;
        private Button btnAgregar;
    }
}