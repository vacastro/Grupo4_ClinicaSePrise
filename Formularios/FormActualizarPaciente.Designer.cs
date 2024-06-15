namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormActualizarPaciente
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
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtFechaNac = new TextBox();
            lblFechaNac = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtBuscarCliente = new Label();
            btnActualizar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(459, 269);
            txtDomicilio.Margin = new Padding(3, 4, 3, 4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(251, 27);
            txtDomicilio.TabIndex = 46;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDomicilio.Location = new Point(197, 269);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(96, 28);
            lblDomicilio.TabIndex = 45;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(459, 129);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 27);
            txtNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(197, 133);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 43;
            lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(459, 164);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 27);
            txtApellido.TabIndex = 42;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(197, 168);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 28);
            lblApellido.TabIndex = 41;
            lblApellido.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(459, 304);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 40;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(197, 304);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 39;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(459, 339);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(251, 27);
            txtTelefono.TabIndex = 38;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(197, 339);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 28);
            lblTelefono.TabIndex = 37;
            lblTelefono.Text = "Teléfono";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(459, 234);
            txtFechaNac.Margin = new Padding(3, 4, 3, 4);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(251, 27);
            txtFechaNac.TabIndex = 36;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(197, 234);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(191, 28);
            lblFechaNac.TabIndex = 35;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(459, 199);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(251, 27);
            txtDni.TabIndex = 34;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(197, 203);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(46, 28);
            lblDni.TabIndex = 33;
            lblDni.Text = "DNI";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(365, 61);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(181, 28);
            txtBuscarCliente.TabIndex = 32;
            txtBuscarCliente.Text = "Actualizar paciente:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(642, 404);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(137, 51);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(110, 404);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 51);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormActualizarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 514);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtFechaNac);
            Controls.Add(lblFechaNac);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Name = "FormActualizarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtFechaNac;
        private Label lblFechaNac;
        private TextBox txtDni;
        private Label lblDni;
        private Label txtBuscarCliente;
        private Button btnActualizar;
        private Button btnCancelar;
    }
}