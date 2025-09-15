namespace WinFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            logoGS = new PictureBox();
            fondoGS = new Panel();
            descripcionIS1 = new Label();
            botonIS = new Button();
            textBoxIS = new TextBox();
            títuloIS = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            fondoGS.SuspendLayout();
            SuspendLayout();
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(49, 53);
            logoGS.Margin = new Padding(3, 2, 3, 2);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(191, 33);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 19;
            logoGS.TabStop = false;
            // 
            // fondoGS
            // 
            fondoGS.BackColor = SystemColors.HighlightText;
            fondoGS.Controls.Add(textBox1);
            fondoGS.Controls.Add(label2);
            fondoGS.Controls.Add(label1);
            fondoGS.Controls.Add(descripcionIS1);
            fondoGS.Controls.Add(botonIS);
            fondoGS.Controls.Add(textBoxIS);
            fondoGS.Controls.Add(títuloIS);
            fondoGS.Location = new Point(10, 28);
            fondoGS.Margin = new Padding(3, 2, 3, 2);
            fondoGS.Name = "fondoGS";
            fondoGS.Size = new Size(466, 394);
            fondoGS.TabIndex = 20;
            // 
            // descripcionIS1
            // 
            descripcionIS1.AutoSize = true;
            descripcionIS1.BackColor = SystemColors.ControlLightLight;
            descripcionIS1.Font = new Font("Segoe UI", 10F);
            descripcionIS1.Location = new Point(39, 150);
            descripcionIS1.Name = "descripcionIS1";
            descripcionIS1.Size = new Size(374, 38);
            descripcionIS1.TabIndex = 20;
            descripcionIS1.Text = "Necesitamos un poco más de información para terminar de \r\nconfigurar tu cuenta.\r\n";
            // 
            // botonIS
            // 
            botonIS.BackColor = SystemColors.HotTrack;
            botonIS.FlatStyle = FlatStyle.Flat;
            botonIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonIS.ForeColor = SystemColors.ControlLightLight;
            botonIS.Location = new Point(331, 295);
            botonIS.Margin = new Padding(3, 2, 3, 2);
            botonIS.Name = "botonIS";
            botonIS.Size = new Size(82, 30);
            botonIS.TabIndex = 19;
            botonIS.Text = "Siguiente";
            botonIS.UseVisualStyleBackColor = false;
            // 
            // textBoxIS
            // 
            textBoxIS.Location = new Point(41, 213);
            textBoxIS.Margin = new Padding(3, 2, 3, 2);
            textBoxIS.Name = "textBoxIS";
            textBoxIS.Size = new Size(371, 23);
            textBoxIS.TabIndex = 19;
            textBoxIS.Text = "Primer Nombre";
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            títuloIS.Location = new Point(39, 105);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(192, 30);
            títuloIS.TabIndex = 6;
            títuloIS.Text = "¿Cómo te llamas?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(56, 70);
            label1.Name = "label1";
            label1.Size = new Size(286, 19);
            label1.TabIndex = 21;
            label1.Text = "aquiVaElCorreoIngresadoAntes@hotmail.com";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 74);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 22;
            label2.Text = "🡨";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 249);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 23);
            textBox1.TabIndex = 23;
            textBox1.Text = "Primer Apellido";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(logoGS);
            Controls.Add(fondoGS);
            Name = "Form4";
            Text = "Sign up";
            ((System.ComponentModel.ISupportInitialize)logoGS).EndInit();
            fondoGS.ResumeLayout(false);
            fondoGS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoGS;
        private Panel fondoGS;
        private Label label1;
        private Label descripcionIS1;
        private Button botonIS;
        private TextBox textBoxIS;
        private Label títuloIS;
        private Label label2;
        private TextBox textBox1;
    }
}