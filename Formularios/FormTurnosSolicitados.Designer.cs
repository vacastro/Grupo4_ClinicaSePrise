namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormTurnosSolicitados
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
            dgvTurnosSolicitados = new DataGridView();
            label1 = new Label();
            lbPaciente = new Label();
            label2 = new Label();
            btnCancelarTurno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTurnosSolicitados).BeginInit();
            SuspendLayout();
            // 
            // dgvTurnosSolicitados
            // 
            dgvTurnosSolicitados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnosSolicitados.Location = new Point(157, 146);
            dgvTurnosSolicitados.Name = "dgvTurnosSolicitados";
            dgvTurnosSolicitados.RowTemplate.Height = 25;
            dgvTurnosSolicitados.Size = new Size(502, 154);
            dgvTurnosSolicitados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 53);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Paciente:";
            // 
            // lbPaciente
            // 
            lbPaciente.AutoSize = true;
            lbPaciente.Location = new Point(167, 53);
            lbPaciente.Name = "lbPaciente";
            lbPaciente.Size = new Size(51, 15);
            lbPaciente.TabIndex = 2;
            lbPaciente.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(340, 95);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 3;
            label2.Text = "Turnos Solicitados:";
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Location = new Point(555, 338);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(93, 42);
            btnCancelarTurno.TabIndex = 4;
            btnCancelarTurno.Text = "Cancelar Turno";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // FormTurnosSolicitados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnCancelarTurno);
            Controls.Add(label2);
            Controls.Add(lbPaciente);
            Controls.Add(label1);
            Controls.Add(dgvTurnosSolicitados);
            Name = "FormTurnosSolicitados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTurnosSolicitados";
            Load += FormTurnosSolicitados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnosSolicitados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurnosSolicitados;
        private Label label1;
        private Label lbPaciente;
        private Label label2;
        private Button btnCancelarTurno;
    }
}