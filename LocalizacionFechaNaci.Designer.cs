namespace WinFormsApp3
{
    partial class LocalizacionFechaNaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizacionFechaNaci));
            panel1 = new Panel();
            Descripcion3 = new TextBox();
            Año = new ListBox();
            Día = new ListBox();
            Mes = new ListBox();
            Pais = new ListBox();
            FechaTitulo = new Label();
            PaisTitulo = new Label();
            logoGS = new PictureBox();
            títuloIS = new Label();
            Email = new Label();
            Descripcion1 = new Label();
            BotonNext = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(BotonNext);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Descripcion3);
            panel1.Controls.Add(Año);
            panel1.Controls.Add(Día);
            panel1.Controls.Add(Mes);
            panel1.Controls.Add(Pais);
            panel1.Controls.Add(FechaTitulo);
            panel1.Controls.Add(PaisTitulo);
            panel1.Controls.Add(logoGS);
            panel1.Controls.Add(títuloIS);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Descripcion1);
            panel1.Location = new Point(12, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 526);
            panel1.TabIndex = 2;
            // 
            // Descripcion3
            // 
            Descripcion3.BorderStyle = BorderStyle.None;
            Descripcion3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion3.Location = new Point(56, 385);
            Descripcion3.Multiline = true;
            Descripcion3.Name = "Descripcion3";
            Descripcion3.Size = new Size(393, 72);
            Descripcion3.TabIndex = 20;
            Descripcion3.Text = resources.GetString("Descripcion3.Text");
            // 
            // Año
            // 
            Año.FormattingEnabled = true;
            Año.Location = new Point(358, 340);
            Año.Name = "Año";
            Año.Size = new Size(136, 24);
            Año.TabIndex = 19;
            // 
            // Día
            // 
            Día.FormattingEnabled = true;
            Día.Location = new Point(206, 340);
            Día.Name = "Día";
            Día.Size = new Size(136, 24);
            Día.TabIndex = 18;
            // 
            // Mes
            // 
            Mes.FormattingEnabled = true;
            Mes.Location = new Point(56, 340);
            Mes.Name = "Mes";
            Mes.Size = new Size(136, 24);
            Mes.TabIndex = 17;
            // 
            // Pais
            // 
            Pais.FormattingEnabled = true;
            Pais.Location = new Point(56, 270);
            Pais.Name = "Pais";
            Pais.Size = new Size(438, 24);
            Pais.TabIndex = 16;
            // 
            // FechaTitulo
            // 
            FechaTitulo.AutoSize = true;
            FechaTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaTitulo.Location = new Point(56, 310);
            FechaTitulo.Name = "FechaTitulo";
            FechaTitulo.Size = new Size(174, 23);
            FechaTitulo.TabIndex = 13;
            FechaTitulo.Text = "Fecha de nacimiento";
            // 
            // PaisTitulo
            // 
            PaisTitulo.AutoSize = true;
            PaisTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaisTitulo.Location = new Point(56, 240);
            PaisTitulo.Name = "PaisTitulo";
            PaisTitulo.Size = new Size(105, 23);
            PaisTitulo.TabIndex = 12;
            PaisTitulo.Text = "País/Región";
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(56, 34);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(218, 44);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 11;
            logoGS.TabStop = false;
            logoGS.Click += logoGS_Click;
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            títuloIS.Location = new Point(56, 131);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(443, 38);
            títuloIS.TabIndex = 3;
            títuloIS.Text = "¿Cuál es tu fecha de nacimiento?";
            títuloIS.Click += label3_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10F);
            Email.Location = new Point(81, 100);
            Email.Name = "Email";
            Email.Size = new Size(181, 23);
            Email.TabIndex = 2;
            Email.Text = "pepepepe@gmail.com";
            // 
            // Descripcion1
            // 
            Descripcion1.AutoSize = true;
            Descripcion1.Font = new Font("Segoe UI", 10F);
            Descripcion1.Location = new Point(56, 180);
            Descripcion1.Name = "Descripcion1";
            Descripcion1.Size = new Size(409, 46);
            Descripcion1.TabIndex = 1;
            Descripcion1.Text = "Si un niño utiliza este dispositivo, seleccione la fecha\r\nde nacimiento para crear una cuenta infantil.";
            // 
            // BotonNext
            // 
            BotonNext.BackColor = SystemColors.HotTrack;
            BotonNext.FlatStyle = FlatStyle.Flat;
            BotonNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonNext.ForeColor = SystemColors.ControlLightLight;
            BotonNext.Location = new Point(400, 440);
            BotonNext.Name = "BotonNext";
            BotonNext.Size = new Size(94, 40);
            BotonNext.TabIndex = 0;
            BotonNext.Text = "Siguiente";
            BotonNext.UseVisualStyleBackColor = false;
            BotonNext.Click += BotonNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 102);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 24;
            label2.Text = "🡨";
            // 
            // LocalizacionFechaNaci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(557, 743);
            Controls.Add(panel1);
            Name = "LocalizacionFechaNaci";
            Text = "LocalizacionFechaNaci";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label FechaTitulo;
        private Label PaisTitulo;
        private PictureBox logoGS;
        private Label títuloIS;
        private Label Email;
        private Label Descripcion1;
        private Button BotonNext;
        private ListBox Mes;
        private ListBox Pais;
        private ListBox Año;
        private ListBox Día;
        private TextBox Descripcion3;
        private Label label2;
    }
}