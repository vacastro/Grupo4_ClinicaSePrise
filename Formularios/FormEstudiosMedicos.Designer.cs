namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormEstudiosMedicos
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnBuscar = new Button();
            dgvListaTurnos = new DataGridView();
            lbProximosTurnos = new Label();
            panelAnalisis = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnAgendar = new Button();
            lbSobreTurnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).BeginInit();
            panelAnalisis.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 45);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione especialidad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(265, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(432, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvListaTurnos
            // 
            dgvListaTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTurnos.Location = new Point(171, 186);
            dgvListaTurnos.Name = "dgvListaTurnos";
            dgvListaTurnos.RowTemplate.Height = 25;
            dgvListaTurnos.Size = new Size(412, 160);
            dgvListaTurnos.TabIndex = 7;
            dgvListaTurnos.Visible = false;
            // 
            // lbProximosTurnos
            // 
            lbProximosTurnos.AutoSize = true;
            lbProximosTurnos.Location = new Point(301, 156);
            lbProximosTurnos.Name = "lbProximosTurnos";
            lbProximosTurnos.Size = new Size(160, 15);
            lbProximosTurnos.TabIndex = 6;
            lbProximosTurnos.Text = "Próximos turnos disponibles:";
            lbProximosTurnos.Visible = false;
            // 
            // panelAnalisis
            // 
            panelAnalisis.BackColor = SystemColors.ActiveCaption;
            panelAnalisis.Controls.Add(label6);
            panelAnalisis.Controls.Add(label5);
            panelAnalisis.Controls.Add(label4);
            panelAnalisis.Controls.Add(label3);
            panelAnalisis.Location = new Point(171, 186);
            panelAnalisis.Name = "panelAnalisis";
            panelAnalisis.Size = new Size(412, 160);
            panelAnalisis.TabIndex = 8;
            panelAnalisis.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 110);
            label6.Name = "label6";
            label6.Size = new Size(146, 15);
            label6.TabIndex = 3;
            label6.Text = "Requiere ayuno de 8 horas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 81);
            label5.Name = "label5";
            label5.Size = new Size(227, 15);
            label5.TabIndex = 2;
            label5.Text = "Presentarse de lunes a viernes de 7 a 11 hs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 53);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 1;
            label4.Text = "No requiere turno previo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 25);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Análisis Clínicos:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(620, 335);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(78, 48);
            btnAgendar.TabIndex = 9;
            btnAgendar.Text = "Agendar Turno";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lbSobreTurnos
            // 
            lbSobreTurnos.AutoSize = true;
            lbSobreTurnos.Location = new Point(301, 156);
            lbSobreTurnos.Name = "lbSobreTurnos";
            lbSobreTurnos.Size = new Size(195, 15);
            lbSobreTurnos.TabIndex = 12;
            lbSobreTurnos.Text = "Próximos Sobre Turnos disponibles:";
            lbSobreTurnos.Visible = false;
            // 
            // FormEstudiosMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(lbSobreTurnos);
            Controls.Add(btnAgendar);
            Controls.Add(panelAnalisis);
            Controls.Add(dgvListaTurnos);
            Controls.Add(lbProximosTurnos);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormEstudiosMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudios Médicos";
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).EndInit();
            panelAnalisis.ResumeLayout(false);
            panelAnalisis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnBuscar;
        private DataGridView dgvListaTurnos;
        private Label lbProximosTurnos;
        private Panel panelAnalisis;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAgendar;
        private Label lbSobreTurnos;
    }
}