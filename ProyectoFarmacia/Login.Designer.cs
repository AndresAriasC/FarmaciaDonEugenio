namespace ProyectoFarmacia
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            campoCode = new RichTextBox();
            campoName = new RichTextBox();
            btnLogin = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(38, 202);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 2;
            label1.Text = "CODE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(247, 324);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
            label3.TabIndex = 4;
            label3.Text = "Olvidó su contraseña?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(38, 123);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 5;
            label2.Text = "NAME";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(campoCode);
            panel2.Controls.Add(campoName);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 394);
            panel2.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(520, 14);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 48);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // campoCode
            // 
            campoCode.BackColor = Color.WhiteSmoke;
            campoCode.BorderStyle = BorderStyle.None;
            campoCode.Location = new Point(142, 199);
            campoCode.Name = "campoCode";
            campoCode.Size = new Size(387, 42);
            campoCode.TabIndex = 10;
            campoCode.Text = "";
            // 
            // campoName
            // 
            campoName.BackColor = Color.WhiteSmoke;
            campoName.BorderStyle = BorderStyle.None;
            campoName.Location = new Point(142, 118);
            campoName.Name = "campoName";
            campoName.Size = new Size(387, 41);
            campoName.TabIndex = 9;
            campoName.Text = "";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Cursor = Cursors.AppStarting;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(196, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 48);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(597, 398);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += Login_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button btnLogin;
        private Button btnSalir;
        private RichTextBox campoCode;
        private RichTextBox campoName;
    }
}