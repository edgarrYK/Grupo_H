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
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            descripcionIS1 = new Label();
            botonIS = new Button();
            textBoxIS = new TextBox();
            títuloIS = new Label();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            fondoGS.SuspendLayout();
            SuspendLayout();
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(56, 34);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(218, 44);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 19;
            logoGS.TabStop = false;
            // 
            // fondoGS
            // 
            fondoGS.BackColor = SystemColors.HighlightText;
            fondoGS.Controls.Add(logoGS);
            fondoGS.Controls.Add(textBox1);
            fondoGS.Controls.Add(label2);
            fondoGS.Controls.Add(label1);
            fondoGS.Controls.Add(descripcionIS1);
            fondoGS.Controls.Add(botonIS);
            fondoGS.Controls.Add(textBoxIS);
            fondoGS.Controls.Add(títuloIS);
            fondoGS.Location = new Point(12, 108);
            fondoGS.Name = "fondoGS";
            fondoGS.Size = new Size(533, 525);
            fondoGS.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 27);
            textBox1.TabIndex = 23;
            textBox1.Text = "Primer Apellido";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 99);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 22;
            label2.Text = "🡨";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(80, 96);
            label1.Name = "label1";
            label1.Size = new Size(357, 23);
            label1.TabIndex = 21;
            label1.Text = "aquiVaElCorreoIngresadoAntes@hotmail.com";
            label1.Click += label1_Click;
            // 
            // descripcionIS1
            // 
            descripcionIS1.AutoSize = true;
            descripcionIS1.BackColor = SystemColors.ControlLightLight;
            descripcionIS1.Font = new Font("Segoe UI", 10F);
            descripcionIS1.Location = new Point(56, 200);
            descripcionIS1.Name = "descripcionIS1";
            descripcionIS1.Size = new Size(445, 46);
            descripcionIS1.TabIndex = 20;
            descripcionIS1.Text = "Necesitamos un poco más de información para terminar \r\nde configurar tu cuenta.\r\n";
            // 
            // botonIS
            // 
            botonIS.BackColor = SystemColors.HotTrack;
            botonIS.FlatStyle = FlatStyle.Flat;
            botonIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonIS.ForeColor = SystemColors.ControlLightLight;
            botonIS.Location = new Point(400, 400);
            botonIS.Name = "botonIS";
            botonIS.Size = new Size(94, 40);
            botonIS.TabIndex = 19;
            botonIS.Text = "Siguiente";
            botonIS.UseVisualStyleBackColor = false;
            botonIS.Click += botonIS_Click;
            // 
            // textBoxIS
            // 
            textBoxIS.Location = new Point(56, 284);
            textBoxIS.Name = "textBoxIS";
            textBoxIS.Size = new Size(423, 27);
            textBoxIS.TabIndex = 19;
            textBoxIS.Text = "Primer Nombre";
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            títuloIS.Location = new Point(56, 140);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(244, 38);
            títuloIS.TabIndex = 6;
            títuloIS.Text = "¿Cómo te llamas?";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(557, 743);
            Controls.Add(fondoGS);
            Margin = new Padding(3, 4, 3, 4);
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