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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 57);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione especialidad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(433, 131);
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
            dgvListaTurnos.Location = new Point(172, 198);
            dgvListaTurnos.Name = "dgvListaTurnos";
            dgvListaTurnos.RowTemplate.Height = 25;
            dgvListaTurnos.Size = new Size(412, 160);
            dgvListaTurnos.TabIndex = 7;
            dgvListaTurnos.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 168);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 6;
            label2.Text = "Próximos turnos disponibles:";
            label2.Visible = false;
            // 
            // FormEstudiosMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(dgvListaTurnos);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormEstudiosMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudios Médicos";
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnBuscar;
        private DataGridView dgvListaTurnos;
        private Label label2;
    }
}