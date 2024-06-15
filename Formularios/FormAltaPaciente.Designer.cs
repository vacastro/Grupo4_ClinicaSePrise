namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormAltaPaciente
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
            btnLimpiar = new Button();
            btnInscribir = new Button();
            txtBuscarCliente = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtFechaNac = new TextBox();
            lblFechaNac = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(91, 413);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 51);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(623, 413);
            btnInscribir.Margin = new Padding(3, 4, 3, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(137, 51);
            btnInscribir.TabIndex = 13;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click_1;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.AutoSize = true;
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(289, 68);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(282, 28);
            txtBuscarCliente.TabIndex = 15;
            txtBuscarCliente.Text = "Formulario de alta de paciente:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(440, 208);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(251, 27);
            txtDni.TabIndex = 17;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(178, 212);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(46, 28);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(440, 243);
            txtFechaNac.Margin = new Padding(3, 4, 3, 4);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(251, 27);
            txtFechaNac.TabIndex = 19;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(178, 243);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(191, 28);
            lblFechaNac.TabIndex = 18;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(440, 348);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(251, 27);
            txtTelefono.TabIndex = 21;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(178, 348);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 28);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(440, 313);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(178, 313);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(440, 173);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 27);
            txtApellido.TabIndex = 25;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(178, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 28);
            lblApellido.TabIndex = 24;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(440, 138);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 27);
            txtNombre.TabIndex = 27;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(178, 142);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(440, 278);
            txtDomicilio.Margin = new Padding(3, 4, 3, 4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(251, 27);
            txtDomicilio.TabIndex = 29;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDomicilio.Location = new Point(178, 278);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(96, 28);
            lblDomicilio.TabIndex = 28;
            lblDomicilio.Text = "Domicilio";
            // 
            // FormAltaPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 511);
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
            Controls.Add(btnInscribir);
            Controls.Add(btnLimpiar);
            Name = "FormAltaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnInscribir;
        private Label txtBuscarCliente;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtFechaNac;
        private Label lblFechaNac;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
    }
}