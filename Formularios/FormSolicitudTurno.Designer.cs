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
            buttonConsultoriosExternos = new Button();
            buttonEstudiosMedicos = new Button();
            SuspendLayout();
            // 
            // buttonConsultoriosExternos
            // 
            buttonConsultoriosExternos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultoriosExternos.Location = new Point(186, 124);
            buttonConsultoriosExternos.Name = "buttonConsultoriosExternos";
            buttonConsultoriosExternos.Size = new Size(162, 91);
            buttonConsultoriosExternos.TabIndex = 0;
            buttonConsultoriosExternos.Text = "Consultorios Externos";
            buttonConsultoriosExternos.UseVisualStyleBackColor = true;
            buttonConsultoriosExternos.Click += buttonConsultoriosExternos_Click;
            // 
            // buttonEstudiosMedicos
            // 
            buttonEstudiosMedicos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEstudiosMedicos.Location = new Point(432, 124);
            buttonEstudiosMedicos.Name = "buttonEstudiosMedicos";
            buttonEstudiosMedicos.Size = new Size(162, 91);
            buttonEstudiosMedicos.TabIndex = 1;
            buttonEstudiosMedicos.Text = "Estudios Médicos";
            buttonEstudiosMedicos.UseVisualStyleBackColor = true;
            buttonEstudiosMedicos.Click += buttonEstudiosMedicos_Click;
            // 
            // FormSolicitudTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(buttonEstudiosMedicos);
            Controls.Add(buttonConsultoriosExternos);
            Name = "FormSolicitudTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitud de Turnos";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConsultoriosExternos;
        private Button buttonEstudiosMedicos;
    }
}