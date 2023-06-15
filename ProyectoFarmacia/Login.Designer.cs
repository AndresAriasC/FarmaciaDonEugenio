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
            camName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            camCode = new TextBox();
            label4 = new Label();
            btnLogin = new Button();
            label5 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // camName
            // 
            camName.BackColor = Color.White;
            camName.BorderStyle = BorderStyle.FixedSingle;
            camName.Location = new Point(20, 76);
            camName.Name = "camName";
            camName.Size = new Size(364, 27);
            camName.TabIndex = 1;
            camName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(20, 124);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 2;
            label1.Text = "CODE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(134, 322);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 4;
            label3.Text = "Olvidó su contraseña?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(20, 45);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 5;
            label2.Text = "NAME";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(camCode);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(camName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(44, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 383);
            panel2.TabIndex = 8;
            // 
            // camCode
            // 
            camCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            camCode.BackColor = Color.White;
            camCode.BorderStyle = BorderStyle.FixedSingle;
            camCode.Location = new Point(20, 155);
            camCode.Name = "camCode";
            camCode.PasswordChar = '*';
            camCode.Size = new Size(364, 27);
            camCode.TabIndex = 8;
            camCode.TextAlign = HorizontalAlignment.Center;
            camCode.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(147, 344);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 7;
            label4.Text = "De ser asi... que mal!";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(124, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 48);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "CONTINUAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(191, 170);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 9;
            label5.Text = "L O G I N";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(421, 17);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 48);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(501, 616);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox camName;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Button btnLogin;
        private TextBox camCode;
        private Label label5;
        private Button btnSalir;
    }
}