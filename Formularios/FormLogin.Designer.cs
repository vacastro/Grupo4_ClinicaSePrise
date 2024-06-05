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
            UsuarioTextBox = new TextBox();
            ContrasenaTextBox = new TextBox();
            LoginButton = new Button();
            userLb = new Label();
            passLb = new Label();
            MensajeLabel1 = new Label();
            MensajeLabel2 = new Label();
            recordarmeCb = new CheckBox();
            olvidoPassLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ErrorPanel = new Panel();
            MensajeLabel3 = new Label();
            AsteriscoLabel1 = new Label();
            AsteriscoLabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ErrorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioTextBox.Location = new Point(309, 124);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(245, 29);
            UsuarioTextBox.TabIndex = 0;
            UsuarioTextBox.TextChanged += UsuarioTextBox_TextChanged;
            // 
            // ContrasenaTextBox
            // 
            ContrasenaTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContrasenaTextBox.Location = new Point(309, 200);
            ContrasenaTextBox.Name = "ContrasenaTextBox";
            ContrasenaTextBox.Size = new Size(245, 29);
            ContrasenaTextBox.TabIndex = 1;
            ContrasenaTextBox.TextChanged += ContrasenaTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.FlatAppearance.BorderColor = Color.LightGray;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.White;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(309, 294);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(245, 33);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Ingresar";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // userLb
            // 
            userLb.AutoSize = true;
            userLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLb.Location = new Point(309, 100);
            userLb.Name = "userLb";
            userLb.Size = new Size(64, 21);
            userLb.TabIndex = 3;
            userLb.Text = "Usuario";
            // 
            // passLb
            // 
            passLb.AutoSize = true;
            passLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passLb.Location = new Point(309, 176);
            passLb.Name = "passLb";
            passLb.Size = new Size(89, 21);
            passLb.TabIndex = 4;
            passLb.Text = "Contraseña";
            // 
            // MensajeLabel1
            // 
            MensajeLabel1.AutoSize = true;
            MensajeLabel1.ForeColor = Color.Red;
            MensajeLabel1.Location = new Point(309, 156);
            MensajeLabel1.Name = "MensajeLabel1";
            MensajeLabel1.Size = new Size(143, 15);
            MensajeLabel1.TabIndex = 5;
            MensajeLabel1.Text = "Este campo es obligatorio";
            MensajeLabel1.Visible = false;
            // 
            // MensajeLabel2
            // 
            MensajeLabel2.AutoSize = true;
            MensajeLabel2.ForeColor = Color.Red;
            MensajeLabel2.Location = new Point(309, 232);
            MensajeLabel2.Name = "MensajeLabel2";
            MensajeLabel2.Size = new Size(143, 15);
            MensajeLabel2.TabIndex = 6;
            MensajeLabel2.Text = "Este campo es obligatorio";
            MensajeLabel2.Visible = false;
            // 
            // recordarmeCb
            // 
            recordarmeCb.AutoSize = true;
            recordarmeCb.ForeColor = Color.Gray;
            recordarmeCb.Location = new Point(309, 260);
            recordarmeCb.Name = "recordarmeCb";
            recordarmeCb.Size = new Size(90, 19);
            recordarmeCb.TabIndex = 7;
            recordarmeCb.Text = "Recordarme";
            recordarmeCb.UseVisualStyleBackColor = true;
            // 
            // olvidoPassLink
            // 
            olvidoPassLink.AutoSize = true;
            olvidoPassLink.DisabledLinkColor = Color.Gray;
            olvidoPassLink.LinkColor = Color.DimGray;
            olvidoPassLink.Location = new Point(426, 260);
            olvidoPassLink.Name = "olvidoPassLink";
            olvidoPassLink.Size = new Size(128, 15);
            olvidoPassLink.TabIndex = 8;
            olvidoPassLink.TabStop = true;
            olvidoPassLink.Text = "¿Olvidó su contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(252, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // ErrorPanel
            // 
            ErrorPanel.BackColor = SystemColors.GradientActiveCaption;
            ErrorPanel.BackgroundImageLayout = ImageLayout.None;
            ErrorPanel.Controls.Add(MensajeLabel3);
            ErrorPanel.Location = new Point(265, 28);
            ErrorPanel.Name = "ErrorPanel";
            ErrorPanel.Size = new Size(341, 45);
            ErrorPanel.TabIndex = 11;
            ErrorPanel.Visible = false;
            // 
            // MensajeLabel3
            // 
            MensajeLabel3.AutoSize = true;
            MensajeLabel3.ForeColor = SystemColors.HotTrack;
            MensajeLabel3.Location = new Point(19, 14);
            MensajeLabel3.Name = "MensajeLabel3";
            MensajeLabel3.Size = new Size(297, 15);
            MensajeLabel3.TabIndex = 0;
            MensajeLabel3.Text = "Usuario y/o contraseña incorrecta. Intente nuevamente";
            // 
            // AsteriscoLabel1
            // 
            AsteriscoLabel1.AutoSize = true;
            AsteriscoLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AsteriscoLabel1.ForeColor = Color.Red;
            AsteriscoLabel1.Location = new Point(559, 125);
            AsteriscoLabel1.Name = "AsteriscoLabel1";
            AsteriscoLabel1.Size = new Size(20, 28);
            AsteriscoLabel1.TabIndex = 12;
            AsteriscoLabel1.Text = "*";
            AsteriscoLabel1.Visible = false;
            // 
            // AsteriscoLabel2
            // 
            AsteriscoLabel2.AutoSize = true;
            AsteriscoLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AsteriscoLabel2.ForeColor = Color.Red;
            AsteriscoLabel2.Location = new Point(559, 201);
            AsteriscoLabel2.Name = "AsteriscoLabel2";
            AsteriscoLabel2.Size = new Size(20, 28);
            AsteriscoLabel2.TabIndex = 13;
            AsteriscoLabel2.Text = "*";
            AsteriscoLabel2.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AsteriscoLabel2);
            Controls.Add(AsteriscoLabel1);
            Controls.Add(ErrorPanel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(olvidoPassLink);
            Controls.Add(recordarmeCb);
            Controls.Add(MensajeLabel2);
            Controls.Add(MensajeLabel1);
            Controls.Add(passLb);
            Controls.Add(userLb);
            Controls.Add(LoginButton);
            Controls.Add(ContrasenaTextBox);
            Controls.Add(UsuarioTextBox);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinica SePrise - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ErrorPanel.ResumeLayout(false);
            ErrorPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsuarioTextBox;
        private TextBox ContrasenaTextBox;
        private Button LoginButton;
        private Label userLb;
        private Label passLb;
        private Label MensajeLabel1;
        private Label MensajeLabel2;
        private CheckBox recordarmeCb;
        private LinkLabel olvidoPassLink;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel ErrorPanel;
        private Label MensajeLabel3;
        private Label AsteriscoLabel1;
        private Label AsteriscoLabel2;
    }
}
