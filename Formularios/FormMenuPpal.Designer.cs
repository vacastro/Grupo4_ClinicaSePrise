namespace Grupo4_ClinicaSePrise
{
    partial class FormMenuPpal
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
            SolicitudTurnoButton = new Button();
            AgendaTurnoButton = new Button();
            SuspendLayout();
            // 
            // SolicitudTurnoButton
            // 
            SolicitudTurnoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SolicitudTurnoButton.Location = new Point(309, 71);
            SolicitudTurnoButton.Name = "SolicitudTurnoButton";
            SolicitudTurnoButton.Size = new Size(187, 91);
            SolicitudTurnoButton.TabIndex = 0;
            SolicitudTurnoButton.Text = "Turnos";
            SolicitudTurnoButton.UseVisualStyleBackColor = true;
            SolicitudTurnoButton.Click += SolicitudTurnoButton_Click;
            // 
            // AgendaTurnoButton
            // 
            AgendaTurnoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgendaTurnoButton.Location = new Point(309, 221);
            AgendaTurnoButton.Name = "AgendaTurnoButton";
            AgendaTurnoButton.Size = new Size(187, 91);
            AgendaTurnoButton.TabIndex = 1;
            AgendaTurnoButton.Text = "Agenda de turnos";
            AgendaTurnoButton.UseVisualStyleBackColor = true;
            AgendaTurnoButton.Click += AgendaTurnoButton_Click;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(AgendaTurnoButton);
            Controls.Add(SolicitudTurnoButton);
            Name = "FormMenuPpal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuPpal";
            Load += FormMenuPpal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SolicitudTurnoButton;
        private Button AgendaTurnoButton;
    }
}