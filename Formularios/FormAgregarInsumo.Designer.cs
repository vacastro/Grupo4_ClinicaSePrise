namespace Grupo4_ClinicaSePrise.Formularios
{
    partial class FormAgregarInsumo
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
            confirmarAgregarInsumo = new Button();
            nombreTxt = new TextBox();
            cantidadTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // confirmarAgregarInsumo
            // 
            confirmarAgregarInsumo.Location = new Point(297, 170);
            confirmarAgregarInsumo.Name = "confirmarAgregarInsumo";
            confirmarAgregarInsumo.Size = new Size(102, 29);
            confirmarAgregarInsumo.TabIndex = 0;
            confirmarAgregarInsumo.Text = "Agregar";
            confirmarAgregarInsumo.UseVisualStyleBackColor = true;
            confirmarAgregarInsumo.Click += confirmarAgregarInsumo_Click;
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(172, 42);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(127, 23);
            nombreTxt.TabIndex = 1;
            // 
            // cantidadTxt
            // 
            cantidadTxt.Location = new Point(172, 81);
            cantidadTxt.Name = "cantidadTxt";
            cantidadTxt.Size = new Size(127, 23);
            cantidadTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 81);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // FormAgregarInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 211);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cantidadTxt);
            Controls.Add(nombreTxt);
            Controls.Add(confirmarAgregarInsumo);
            Name = "FormAgregarInsumo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Insumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmarAgregarInsumo;
        private TextBox nombreTxt;
        private TextBox cantidadTxt;
        private Label label1;
        private Label label2;
    }
}