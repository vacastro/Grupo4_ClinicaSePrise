namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormSolicitudTurno
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
            txtBuscarCliente = new Label();
            MensajeLabel1 = new Label();
            AsteriscoLabel1 = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            btnBuscarDni = new Button();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(359, 135);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(117, 21);
            txtBuscarCliente.TabIndex = 5;
            txtBuscarCliente.Text = "Buscar Paciente";
            // 
            // MensajeLabel1
            // 
            MensajeLabel1.AutoSize = true;
            MensajeLabel1.ForeColor = SystemColors.Highlight;
            MensajeLabel1.Location = new Point(267, 207);
            MensajeLabel1.Name = "MensajeLabel1";
            MensajeLabel1.Size = new Size(292, 15);
            MensajeLabel1.TabIndex = 8;
            MensajeLabel1.Text = "Formato inválido, el DNI debe contener solo números.";
            MensajeLabel1.Visible = false;
            // 
            // AsteriscoLabel1
            // 
            AsteriscoLabel1.AutoSize = true;
            AsteriscoLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AsteriscoLabel1.ForeColor = Color.Red;
            AsteriscoLabel1.Location = new Point(540, 181);
            AsteriscoLabel1.Name = "AsteriscoLabel1";
            AsteriscoLabel1.Size = new Size(21, 25);
            AsteriscoLabel1.TabIndex = 11;
            AsteriscoLabel1.Text = "*";
            AsteriscoLabel1.Visible = false;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(314, 181);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 23);
            txtDni.TabIndex = 10;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(271, 181);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 9;
            lblDni.Text = "DNI";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarDni.Location = new Point(392, 269);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(142, 44);
            btnBuscarDni.TabIndex = 12;
            btnBuscarDni.Text = "BUSCAR";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // FormSolicitudTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnBuscarDni);
            Controls.Add(MensajeLabel1);
            Controls.Add(AsteriscoLabel1);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtBuscarCliente);
            Name = "FormSolicitudTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSolicitudTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtBuscarCliente;
        private Label MensajeLabel1;
        private Label AsteriscoLabel1;
        private TextBox txtDni;
        private Label lblDni;
        private Button btnBuscarDni;
    }
}