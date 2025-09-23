namespace CapaPresentacion
{
    partial class CrearCuentaContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuentaContrasena));
            panel1 = new Panel();
            BotonNext = new Button();
            label2 = new Label();
            PaisTitulo = new Label();
            logoGS = new PictureBox();
            títuloIS = new Label();
            Email = new Label();
            Descripcion1 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BotonNext);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PaisTitulo);
            panel1.Controls.Add(logoGS);
            panel1.Controls.Add(títuloIS);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Descripcion1);
            panel1.Location = new Point(9, 81);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 359);
            panel1.TabIndex = 3;
            // 
            // BotonNext
            // 
            BotonNext.BackColor = SystemColors.HotTrack;
            BotonNext.FlatStyle = FlatStyle.Flat;
            BotonNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonNext.ForeColor = SystemColors.ControlLightLight;
            BotonNext.Location = new Point(350, 296);
            BotonNext.Margin = new Padding(3, 2, 3, 2);
            BotonNext.Name = "BotonNext";
            BotonNext.Size = new Size(82, 30);
            BotonNext.TabIndex = 0;
            BotonNext.Text = "Siguiente";
            BotonNext.UseVisualStyleBackColor = false;
            BotonNext.Click += BotonNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 76);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 24;
            label2.Text = "🡨";
            // 
            // PaisTitulo
            // 
            PaisTitulo.AutoSize = true;
            PaisTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaisTitulo.Location = new Point(49, 168);
            PaisTitulo.Name = "PaisTitulo";
            PaisTitulo.Size = new Size(153, 19);
            PaisTitulo.TabIndex = 12;
            PaisTitulo.Text = "Ingrese su contraseña";
            PaisTitulo.Click += PaisTitulo_Click;
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(49, 26);
            logoGS.Margin = new Padding(3, 2, 3, 2);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(191, 33);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 11;
            logoGS.TabStop = false;
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            títuloIS.Location = new Point(49, 98);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(240, 30);
            títuloIS.TabIndex = 3;
            títuloIS.Text = "Establecer contraseña";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10F);
            Email.Location = new Point(80, 72);
            Email.Name = "Email";
            Email.Size = new Size(144, 19);
            Email.TabIndex = 2;
            Email.Text = "pepepepe@gmail.com";
            // 
            // Descripcion1
            // 
            Descripcion1.AutoSize = true;
            Descripcion1.Font = new Font("Segoe UI", 10F);
            Descripcion1.Location = new Point(49, 135);
            Descripcion1.Name = "Descripcion1";
            Descripcion1.Size = new Size(296, 19);
            Descripcion1.TabIndex = 1;
            Descripcion1.Text = "8 caracteres mínimo. Sensible a las mayúsculas.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 25;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 224);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 26;
            label1.Text = "Confirme su contraseña";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 23);
            textBox2.TabIndex = 27;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // CrearCuentaContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(485, 519);
            Controls.Add(panel1);
            Name = "CrearCuentaContrasena";
            Text = "Registrarse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BotonNext;
        private Label label2;
        private Label PaisTitulo;
        private PictureBox logoGS;
        private Label títuloIS;
        private Label Email;
        private Label Descripcion1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}