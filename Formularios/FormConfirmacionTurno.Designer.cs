namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormConfirmacionTurno
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
            lbTurno = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbPaciente = new Label();
            lbFecha = new Label();
            lbHora = new Label();
            lbEspecialidad = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lbSobreTurno = new Label();
            SuspendLayout();
            // 
            // lbTurno
            // 
            lbTurno.AutoSize = true;
            lbTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTurno.Location = new Point(303, 66);
            lbTurno.Name = "lbTurno";
            lbTurno.Size = new Size(170, 21);
            lbTurno.TabIndex = 0;
            lbTurno.Text = "Confirmación de turno:";
            lbTurno.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(303, 123);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(303, 165);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(303, 209);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 3;
            label4.Text = "Hora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(303, 248);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Especialidad:";
            // 
            // lbPaciente
            // 
            lbPaciente.AutoSize = true;
            lbPaciente.Location = new Point(416, 125);
            lbPaciente.Name = "lbPaciente";
            lbPaciente.Size = new Size(38, 15);
            lbPaciente.TabIndex = 5;
            lbPaciente.Text = "label6";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(416, 167);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(38, 15);
            lbFecha.TabIndex = 6;
            lbFecha.Text = "label6";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Location = new Point(416, 209);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(38, 15);
            lbHora.TabIndex = 7;
            lbHora.Text = "label6";
            // 
            // lbEspecialidad
            // 
            lbEspecialidad.AutoSize = true;
            lbEspecialidad.Location = new Point(416, 252);
            lbEspecialidad.Name = "lbEspecialidad";
            lbEspecialidad.Size = new Size(38, 15);
            lbEspecialidad.TabIndex = 8;
            lbEspecialidad.Text = "label6";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(525, 308);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(171, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbSobreTurno
            // 
            lbSobreTurno.AutoSize = true;
            lbSobreTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSobreTurno.Location = new Point(303, 66);
            lbSobreTurno.Name = "lbSobreTurno";
            lbSobreTurno.Size = new Size(218, 21);
            lbSobreTurno.TabIndex = 11;
            lbSobreTurno.Text = "Confirmación de Sobre Turno:";
            lbSobreTurno.Visible = false;
            // 
            // FormConfirmacionTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(lbSobreTurno);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lbEspecialidad);
            Controls.Add(lbHora);
            Controls.Add(lbFecha);
            Controls.Add(lbPaciente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTurno);
            Name = "FormConfirmacionTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmacionTurno";
            Load += ConfirmacionTurno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTurno;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbPaciente;
        private Label lbFecha;
        private Label lbHora;
        private Label lbEspecialidad;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lbSobreTurno;
    }
}