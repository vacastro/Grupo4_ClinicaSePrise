namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class SinLocalizarPaciente
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
            btnVolver = new Button();
            btnCensar = new Button();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(230, 130);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(417, 28);
            txtBuscarCliente.TabIndex = 6;
            txtBuscarCliente.Text = "No se encontró al paciente en la base de datos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(187, 370);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(137, 51);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnCensar
            // 
            btnCensar.Location = new Point(576, 370);
            btnCensar.Margin = new Padding(3, 4, 3, 4);
            btnCensar.Name = "btnCensar";
            btnCensar.Size = new Size(137, 51);
            btnCensar.TabIndex = 12;
            btnCensar.Text = "Censar";
            btnCensar.UseVisualStyleBackColor = true;
            btnCensar.Click += btnCensar_Click_1;
            // 
            // SinLocalizarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 548);
            Controls.Add(btnCensar);
            Controls.Add(btnVolver);
            Controls.Add(txtBuscarCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SinLocalizarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinLocalizarPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtBuscarCliente;
        private Button btnVolver;
        private Button btnCensar;
    }
}