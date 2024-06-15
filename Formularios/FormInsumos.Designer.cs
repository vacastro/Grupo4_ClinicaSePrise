namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormInsumos
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
            dtgvInsumos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dtgvColNombre = new DataGridViewTextBoxColumn();
            dtgvColCantidad = new DataGridViewTextBoxColumn();
            lblTitleInsumos = new Label();
            backButton = new Button();
            guardarBtn = new Button();
            agregarInsumoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // dtgvInsumos
            // 
            dtgvInsumos.AllowUserToAddRows = false;
            dtgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInsumos.Columns.AddRange(new DataGridViewColumn[] { ID, dtgvColNombre, dtgvColCantidad });
            dtgvInsumos.Location = new Point(46, 84);
            dtgvInsumos.Name = "dtgvInsumos";
            dtgvInsumos.RowTemplate.Height = 25;
            dtgvInsumos.Size = new Size(463, 308);
            dtgvInsumos.TabIndex = 0;
            dtgvInsumos.CellContentClick += dtgvInsumos_CellContentClick;
            dtgvInsumos.CellEndEdit += dtgvInsumos_CellEndEdit;
            dtgvInsumos.RowsAdded += dtgvInsumos_RowsAdded;
            dtgvInsumos.UserAddedRow += dtgvInsumos_UserAddedRow;
            dtgvInsumos.UserDeletedRow += dtgvInsumos_UserDeletedRow;
            // 
            // ID
            // 
            ID.HeaderText = "ID_INSUMO";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // dtgvColNombre
            // 
            dtgvColNombre.HeaderText = "NOMBRE";
            dtgvColNombre.Name = "dtgvColNombre";
            // 
            // dtgvColCantidad
            // 
            dtgvColCantidad.HeaderText = "CANTIDAD";
            dtgvColCantidad.Name = "dtgvColCantidad";
            // 
            // lblTitleInsumos
            // 
            lblTitleInsumos.AutoSize = true;
            lblTitleInsumos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInsumos.Location = new Point(46, 25);
            lblTitleInsumos.Name = "lblTitleInsumos";
            lblTitleInsumos.Size = new Size(203, 30);
            lblTitleInsumos.TabIndex = 1;
            lblTitleInsumos.Text = "Gestión de Insumos";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(92, 23);
            backButton.TabIndex = 2;
            backButton.Text = "Volver";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(456, 415);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(92, 23);
            guardarBtn.TabIndex = 3;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // agregarInsumoBtn
            // 
            agregarInsumoBtn.Location = new Point(218, 415);
            agregarInsumoBtn.Name = "agregarInsumoBtn";
            agregarInsumoBtn.Size = new Size(114, 23);
            agregarInsumoBtn.TabIndex = 4;
            agregarInsumoBtn.Text = "Agregar Insumo";
            agregarInsumoBtn.UseVisualStyleBackColor = true;
            agregarInsumoBtn.Click += agregarInsumoBtn_Click;
            // 
            // FormInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(agregarInsumoBtn);
            Controls.Add(guardarBtn);
            Controls.Add(backButton);
            Controls.Add(lblTitleInsumos);
            Controls.Add(dtgvInsumos);
            Name = "FormInsumos";
            Text = "Insumos";
            ((System.ComponentModel.ISupportInitialize)dtgvInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvInsumos;
        private Label lblTitleInsumos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dtgvColNombre;
        private DataGridViewTextBoxColumn dtgvColCantidad;
        private Button backButton;
        private Button guardarBtn;
        private Button agregarInsumoBtn;
    }
}