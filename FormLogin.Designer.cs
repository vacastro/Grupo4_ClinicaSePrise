namespace Grupo4_ClinicaSePrise
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            loginBtn = new System.Windows.Forms.Button();
            userLb = new System.Windows.Forms.Label();
            passLb = new System.Windows.Forms.Label();
            mensajeLb1 = new System.Windows.Forms.Label();
            mensajeLb2 = new System.Windows.Forms.Label();
            recordarmeCb = new System.Windows.Forms.CheckBox();
            olvidoPassLink = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            alertaLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(309, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(245, 29);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(309, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(245, 29);
            textBox2.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = System.Drawing.Color.Transparent;
            loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loginBtn.Location = new System.Drawing.Point(309, 294);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new System.Drawing.Size(245, 33);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Ingresar";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // userLb
            // 
            userLb.AutoSize = true;
            userLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            userLb.Location = new System.Drawing.Point(309, 100);
            userLb.Name = "userLb";
            userLb.Size = new System.Drawing.Size(64, 21);
            userLb.TabIndex = 3;
            userLb.Text = "Usuario";
            // 
            // passLb
            // 
            passLb.AutoSize = true;
            passLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            passLb.Location = new System.Drawing.Point(309, 176);
            passLb.Name = "passLb";
            passLb.Size = new System.Drawing.Size(89, 21);
            passLb.TabIndex = 4;
            passLb.Text = "Contraseña";
            // 
            // mensajeLb1
            // 
            mensajeLb1.AutoSize = true;
            mensajeLb1.ForeColor = System.Drawing.Color.Red;
            mensajeLb1.Location = new System.Drawing.Point(309, 156);
            mensajeLb1.Name = "mensajeLb1";
            mensajeLb1.Size = new System.Drawing.Size(143, 15);
            mensajeLb1.TabIndex = 5;
            mensajeLb1.Text = "Este campo es obligatorio";
            // 
            // mensajeLb2
            // 
            mensajeLb2.AutoSize = true;
            mensajeLb2.ForeColor = System.Drawing.Color.Red;
            mensajeLb2.Location = new System.Drawing.Point(309, 232);
            mensajeLb2.Name = "mensajeLb2";
            mensajeLb2.Size = new System.Drawing.Size(143, 15);
            mensajeLb2.TabIndex = 6;
            mensajeLb2.Text = "Este campo es obligatorio";
            // 
            // recordarmeCb
            // 
            recordarmeCb.AutoSize = true;
            recordarmeCb.ForeColor = System.Drawing.Color.Gray;
            recordarmeCb.Location = new System.Drawing.Point(386, 260);
            recordarmeCb.Name = "recordarmeCb";
            recordarmeCb.Size = new System.Drawing.Size(90, 19);
            recordarmeCb.TabIndex = 7;
            recordarmeCb.Text = "Recordarme";
            recordarmeCb.UseVisualStyleBackColor = true;
            // 
            // olvidoPassLink
            // 
            olvidoPassLink.AutoSize = true;
            olvidoPassLink.DisabledLinkColor = System.Drawing.Color.Gray;
            olvidoPassLink.LinkColor = System.Drawing.Color.DimGray;
            olvidoPassLink.Location = new System.Drawing.Point(367, 260);
            olvidoPassLink.Name = "olvidoPassLink";
            olvidoPassLink.Size = new System.Drawing.Size(128, 15);
            olvidoPassLink.TabIndex = 8;
            olvidoPassLink.TabStop = true;
            olvidoPassLink.Text = "¿Olvidó su contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(252, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 42);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(252, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(42, 42);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(alertaLb);
            panel1.Location = new System.Drawing.Point(238, 29);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(341, 45);
            panel1.TabIndex = 11;
            // 
            // alertaLb
            // 
            alertaLb.AutoSize = true;
            alertaLb.ForeColor = System.Drawing.SystemColors.HotTrack;
            alertaLb.Location = new System.Drawing.Point(19, 14);
            alertaLb.Name = "alertaLb";
            alertaLb.Size = new System.Drawing.Size(297, 15);
            alertaLb.TabIndex = 0;
            alertaLb.Text = "Usuario y/o contraseña incorrecta. Intente nuevamente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(olvidoPassLink);
            Controls.Add(recordarmeCb);
            Controls.Add(mensajeLb2);
            Controls.Add(mensajeLb1);
            Controls.Add(passLb);
            Controls.Add(userLb);
            Controls.Add(loginBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.Label mensajeLb1;
        private System.Windows.Forms.Label mensajeLb2;
        private System.Windows.Forms.CheckBox recordarmeCb;
        private System.Windows.Forms.LinkLabel olvidoPassLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alertaLb;
    }
}
