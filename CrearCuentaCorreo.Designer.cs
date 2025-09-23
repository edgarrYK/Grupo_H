
namespace WinFormsApp3
{
    partial class CrearCuentaCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private void descripcionIS1_Click(object sender, EventArgs e)
        {
            // Ejemplo: abrir Form4
            CrearCuentaNombre f4 = new CrearCuentaNombre();
            f4.Show();
            this.Hide();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuentaCorreo));
            fondoGS = new Panel();
            logoGS = new PictureBox();
            descripcionIS1 = new Label();
            botonIS = new Button();
            textBoxIS = new TextBox();
            títuloIS = new Label();
            fondoGS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            SuspendLayout();
            // 
            // fondoGS
            // 
            fondoGS.BackColor = SystemColors.HighlightText;
            fondoGS.Controls.Add(logoGS);
            fondoGS.Controls.Add(descripcionIS1);
            fondoGS.Controls.Add(botonIS);
            fondoGS.Controls.Add(textBoxIS);
            fondoGS.Controls.Add(títuloIS);
            fondoGS.Location = new Point(10, 81);
            fondoGS.Margin = new Padding(3, 2, 3, 2);
            fondoGS.Name = "fondoGS";
            fondoGS.Size = new Size(466, 394);
            fondoGS.TabIndex = 18;
            fondoGS.Paint += fondoGS_Paint;
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(49, 39);
            logoGS.Margin = new Padding(3, 2, 3, 2);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(191, 33);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 16;
            logoGS.TabStop = false;
            // 
            // descripcionIS1
            // 
            descripcionIS1.AutoSize = true;
            descripcionIS1.BackColor = SystemColors.ControlLightLight;
            descripcionIS1.Font = new Font("Segoe UI", 10F);
            descripcionIS1.Location = new Point(49, 106);
            descripcionIS1.Name = "descripcionIS1";
            descripcionIS1.Size = new Size(314, 19);
            descripcionIS1.TabIndex = 20;
            descripcionIS1.Text = "Ingresa tu correo electrónico para crear tu cuenta.";
            descripcionIS1.Click += descripcionIS1_Click;
            // 
            // botonIS
            // 
            botonIS.BackColor = SystemColors.HotTrack;
            botonIS.FlatStyle = FlatStyle.Flat;
            botonIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonIS.ForeColor = SystemColors.ControlLightLight;
            botonIS.Location = new Point(350, 209);
            botonIS.Margin = new Padding(3, 2, 3, 2);
            botonIS.Name = "botonIS";
            botonIS.Size = new Size(82, 30);
            botonIS.TabIndex = 19;
            botonIS.Text = "Siguiente";
            botonIS.UseVisualStyleBackColor = false;
            botonIS.Click += botonIS_Click;
            // 
            // textBoxIS
            // 
            textBoxIS.Location = new Point(49, 151);
            textBoxIS.Margin = new Padding(3, 2, 3, 2);
            textBoxIS.Name = "textBoxIS";
            textBoxIS.PlaceholderText = "ejemplo@outlook.es";
            textBoxIS.Size = new Size(371, 23);
            textBoxIS.TabIndex = 19;
            textBoxIS.TextChanged += textBoxIS_TextChanged;
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            títuloIS.Location = new Point(49, 74);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(148, 30);
            títuloIS.TabIndex = 6;
            títuloIS.Text = "Crear Cuenta";
            títuloIS.Click += títuloIS_Click;
            // 
            // CrearCuentaCorreo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(487, 557);
            Controls.Add(fondoGS);
            Name = "CrearCuentaCorreo";
            Text = "Registrarse";
            Load += Form3_Load;
            fondoGS.ResumeLayout(false);
            fondoGS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel fondoGS;
        private Label títuloIS;
        private PictureBox logoGS;
        private TextBox textBoxIS;
        private Button botonIS;
        private Label descripcionIS1;
        //private EventHandler descripcionIS1_Click;
    }
}