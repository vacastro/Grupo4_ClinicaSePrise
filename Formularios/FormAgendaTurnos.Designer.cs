namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormAgendaTurnos
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
            lblTurnos = new Label();
            BoxTrurnos = new ComboBox();
            dateAgendaTrunos = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnTurnosVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTurnos
            // 
            lblTurnos.AutoSize = true;
            lblTurnos.Location = new Point(211, 104);
            lblTurnos.Name = "lblTurnos";
            lblTurnos.Size = new Size(46, 15);
            lblTurnos.TabIndex = 0;
            lblTurnos.Text = "Turnos:";
            // 
            // BoxTrurnos
            // 
            BoxTrurnos.FormattingEnabled = true;
            BoxTrurnos.Location = new Point(211, 136);
            BoxTrurnos.Name = "BoxTrurnos";
            BoxTrurnos.Size = new Size(121, 23);
            BoxTrurnos.TabIndex = 1;
            BoxTrurnos.SelectedIndexChanged += BoxTrurnos_SelectedIndexChanged;
            // 
            // dateAgendaTrunos
            // 
            dateAgendaTrunos.Location = new Point(379, 136);
            dateAgendaTrunos.Name = "dateAgendaTrunos";
            dateAgendaTrunos.Size = new Size(200, 23);
            dateAgendaTrunos.TabIndex = 2;
            dateAgendaTrunos.ValueChanged += dateAgendaTrunos_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(368, 162);
            dataGridView1.TabIndex = 3;
            // 
            // btnTurnosVolver
            // 
            btnTurnosVolver.Location = new Point(504, 360);
            btnTurnosVolver.Name = "btnTurnosVolver";
            btnTurnosVolver.Size = new Size(75, 23);
            btnTurnosVolver.TabIndex = 4;
            btnTurnosVolver.Text = "Volver";
            btnTurnosVolver.UseVisualStyleBackColor = true;
            btnTurnosVolver.Click += btnTurnosVolver_Click;
            // 
            // FormAgendaTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnTurnosVolver);
            Controls.Add(dataGridView1);
            Controls.Add(dateAgendaTrunos);
            Controls.Add(BoxTrurnos);
            Controls.Add(lblTurnos);
            Name = "FormAgendaTurnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgendaTurnos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTurnos;
        private ComboBox BoxTrurnos;
        private DateTimePicker dateAgendaTrunos;
        private DataGridView dataGridView1;
        private Button btnTurnosVolver;
    }
}
