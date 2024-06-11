namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormConsultoriosExternos
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
            lbProximosTurnos = new Label();
            dgvListaTurnos = new DataGridView();
            btnBuscar = new Button();
            btnAgendar = new Button();
            lbSobreTurnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 38);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione especialidad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbProximosTurnos
            // 
            lbProximosTurnos.AutoSize = true;
            lbProximosTurnos.Location = new Point(316, 153);
            lbProximosTurnos.Name = "lbProximosTurnos";
            lbProximosTurnos.Size = new Size(160, 15);
            lbProximosTurnos.TabIndex = 2;
            lbProximosTurnos.Text = "Próximos turnos disponibles:";
            lbProximosTurnos.Visible = false;
            // 
            // dgvListaTurnos
            // 
            dgvListaTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTurnos.Location = new Point(186, 183);
            dgvListaTurnos.Name = "dgvListaTurnos";
            dgvListaTurnos.RowTemplate.Height = 25;
            dgvListaTurnos.Size = new Size(412, 160);
            dgvListaTurnos.TabIndex = 3;
            dgvListaTurnos.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(446, 114);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(624, 335);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(78, 48);
            btnAgendar.TabIndex = 10;
            btnAgendar.Text = "Agendar Turno";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lbSobreTurnos
            // 
            lbSobreTurnos.AutoSize = true;
            lbSobreTurnos.Location = new Point(316, 153);
            lbSobreTurnos.Name = "lbSobreTurnos";
            lbSobreTurnos.Size = new Size(195, 15);
            lbSobreTurnos.TabIndex = 11;
            lbSobreTurnos.Text = "Próximos Sobre Turnos disponibles:";
            lbSobreTurnos.Visible = false;
            // 
            // FormConsultoriosExternos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(lbSobreTurnos);
            Controls.Add(btnAgendar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvListaTurnos);
            Controls.Add(lbProximosTurnos);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormConsultoriosExternos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultorios Externos";
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label lbProximosTurnos;
        private DataGridView dgvListaTurnos;
        private Button btnBuscar;
        private Button btnAgendar;
        private Label lbSobreTurnos;
    }
}