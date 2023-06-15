namespace ProyectoFarmacia
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            carga = new System.Windows.Forms.Timer(components);
            progressBarInicio = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // carga
            // 
            carga.Enabled = true;
            carga.Tick += carga_Tick;
            // 
            // progressBarInicio
            // 
            progressBarInicio.Location = new Point(74, 145);
            progressBarInicio.Name = "progressBarInicio";
            progressBarInicio.Size = new Size(390, 42);
            progressBarInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 190);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 1;
            label1.Text = "0%";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 296);
            Controls.Add(label1);
            Controls.Add(progressBarInicio);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer carga;
        private ProgressBar progressBarInicio;
        private Label label1;
    }
}