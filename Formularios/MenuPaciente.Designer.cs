﻿namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class MenuPaciente
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(101, 120);
            button1.Name = "button1";
            button1.Size = new Size(132, 94);
            button1.TabIndex = 0;
            button1.Text = "Actualizar Datos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(323, 120);
            button2.Name = "button2";
            button2.Size = new Size(132, 94);
            button2.TabIndex = 1;
            button2.Text = "Turnos Solicitados";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(542, 120);
            button3.Name = "button3";
            button3.Size = new Size(132, 94);
            button3.TabIndex = 2;
            button3.Text = "Solicitar Nuevo Turno";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MenuPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPaciente";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}