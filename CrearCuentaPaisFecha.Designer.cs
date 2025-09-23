namespace WinFormsApp3
{
    partial class CrearCuentaPaisFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuentaPaisFecha));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            Pais = new ComboBox();
            BotonNext = new Button();
            label2 = new Label();
            Descripcion3 = new TextBox();
            FechaTitulo = new Label();
            PaisTitulo = new Label();
            logoGS = new PictureBox();
            títuloIS = new Label();
            Email = new Label();
            Descripcion1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(Pais);
            panel1.Controls.Add(BotonNext);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Descripcion3);
            panel1.Controls.Add(FechaTitulo);
            panel1.Controls.Add(PaisTitulo);
            panel1.Controls.Add(logoGS);
            panel1.Controls.Add(títuloIS);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Descripcion1);
            panel1.Location = new Point(10, 81);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 394);
            panel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(48, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 23);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Pais
            // 
            Pais.FormattingEnabled = true;
            Pais.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Esuatini", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guinea", "Guinea-Bisáu", "Guinea Ecuatorial", "Guyana", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Vaticano", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            Pais.Location = new Point(48, 200);
            Pais.Name = "Pais";
            Pais.Size = new Size(144, 23);
            Pais.TabIndex = 25;
            Pais.SelectedIndexChanged += Pais_SelectedIndexChanged_1;
            // 
            // BotonNext
            // 
            BotonNext.BackColor = SystemColors.HotTrack;
            BotonNext.FlatStyle = FlatStyle.Flat;
            BotonNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonNext.ForeColor = SystemColors.ControlLightLight;
            BotonNext.Location = new Point(350, 330);
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
            // Descripcion3
            // 
            Descripcion3.BorderStyle = BorderStyle.None;
            Descripcion3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion3.Location = new Point(48, 296);
            Descripcion3.Margin = new Padding(3, 2, 3, 2);
            Descripcion3.Multiline = true;
            Descripcion3.Name = "Descripcion3";
            Descripcion3.Size = new Size(304, 54);
            Descripcion3.TabIndex = 20;
            Descripcion3.Text = resources.GetString("Descripcion3.Text");
            // 
            // FechaTitulo
            // 
            FechaTitulo.AutoSize = true;
            FechaTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaTitulo.Location = new Point(49, 232);
            FechaTitulo.Name = "FechaTitulo";
            FechaTitulo.Size = new Size(146, 19);
            FechaTitulo.TabIndex = 13;
            FechaTitulo.Text = "Fecha de nacimiento";
            // 
            // PaisTitulo
            // 
            PaisTitulo.AutoSize = true;
            PaisTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaisTitulo.Location = new Point(49, 180);
            PaisTitulo.Name = "PaisTitulo";
            PaisTitulo.Size = new Size(89, 19);
            PaisTitulo.TabIndex = 12;
            PaisTitulo.Text = "País/Región";
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
            logoGS.Click += logoGS_Click;
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            títuloIS.Location = new Point(49, 98);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(349, 30);
            títuloIS.TabIndex = 3;
            títuloIS.Text = "¿Cuál es tu fecha de nacimiento?";
            títuloIS.Click += label3_Click;
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
            Descripcion1.Size = new Size(325, 38);
            Descripcion1.TabIndex = 1;
            Descripcion1.Text = "Si un niño utiliza este dispositivo, seleccione la fecha\r\nde nacimiento para crear una cuenta infantil.";
            // 
            // CrearCuentaPaisFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(487, 557);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearCuentaPaisFecha";
            Text = "Sign Up";
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
        private TextBox Descripcion3;
        private Label label2;
        private ComboBox Pais;
        private DateTimePicker dateTimePicker1;
    }
}