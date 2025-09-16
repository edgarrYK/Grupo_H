﻿namespace WinFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botonIS = new Button();
            laExito = new Label();
            títuloIS = new Label();
            descripcionIS1 = new Label();
            logoGS = new PictureBox();
            descripcionIS2 = new Label();
            textBoxIS = new TextBox();
            descripcionIS3 = new Label();
            fondoGS = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoGS).BeginInit();
            fondoGS.SuspendLayout();
            SuspendLayout();
            // 
            // botonIS
            // 
            botonIS.BackColor = SystemColors.HotTrack;
            botonIS.FlatStyle = FlatStyle.Flat;
            botonIS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonIS.ForeColor = SystemColors.ControlLightLight;
            botonIS.Location = new Point(337, 310);
            botonIS.Margin = new Padding(3, 2, 3, 2);
            botonIS.Name = "botonIS";
            botonIS.Size = new Size(82, 30);
            botonIS.TabIndex = 0;
            botonIS.Text = "Iniciar";
            botonIS.UseVisualStyleBackColor = false;
            botonIS.Click += button1_Click;
            // 
            // laExito
            // 
            laExito.AutoSize = true;
            laExito.Location = new Point(329, 238);
            laExito.Name = "laExito";
            laExito.Size = new Size(43, 15);
            laExito.TabIndex = 5;
            laExito.Text = "            ";
            laExito.Click += label1_Click_1;
            // 
            // títuloIS
            // 
            títuloIS.AutoSize = true;
            títuloIS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            títuloIS.Location = new Point(38, 61);
            títuloIS.Name = "títuloIS";
            títuloIS.Size = new Size(171, 30);
            títuloIS.TabIndex = 6;
            títuloIS.Text = "Inicio de sesión";
            títuloIS.Click += label1_Click_2;
            // 
            // descripcionIS1
            // 
            descripcionIS1.AutoSize = true;
            descripcionIS1.BackColor = SystemColors.ControlLightLight;
            descripcionIS1.Font = new Font("Segoe UI", 10F);
            descripcionIS1.Location = new Point(49, 190);
            descripcionIS1.Name = "descripcionIS1";
            descripcionIS1.Size = new Size(340, 19);
            descripcionIS1.TabIndex = 9;
            descripcionIS1.Text = "Compra tus videojuegos favoritos utilizando tu cuenta";
            descripcionIS1.Click += label3_Click;
            // 
            // logoGS
            // 
            logoGS.Image = (Image)resources.GetObject("logoGS.Image");
            logoGS.Location = new Point(49, 98);
            logoGS.Margin = new Padding(3, 2, 3, 2);
            logoGS.Name = "logoGS";
            logoGS.Size = new Size(191, 33);
            logoGS.SizeMode = PictureBoxSizeMode.StretchImage;
            logoGS.TabIndex = 10;
            logoGS.TabStop = false;
            logoGS.Click += logoGS_Click;
            // 
            // descripcionIS2
            // 
            descripcionIS2.AutoSize = true;
            descripcionIS2.BackColor = SystemColors.ControlLightLight;
            descripcionIS2.Font = new Font("Segoe UI", 10F);
            descripcionIS2.Location = new Point(49, 207);
            descripcionIS2.Name = "descripcionIS2";
            descripcionIS2.Size = new Size(76, 19);
            descripcionIS2.TabIndex = 11;
            descripcionIS2.Text = "GameStop.";
            descripcionIS2.Click += label2_Click_2;
            // 
            // textBoxIS
            // 
            textBoxIS.Location = new Point(49, 238);
            textBoxIS.Margin = new Padding(3, 2, 3, 2);
            textBoxIS.Name = "textBoxIS";
            textBoxIS.Size = new Size(371, 23);
            textBoxIS.TabIndex = 12;
            textBoxIS.Text = "Correo electrónico";
            textBoxIS.TextChanged += textBox1_TextChanged;
            // 
            // descripcionIS3
            // 
            descripcionIS3.AutoSize = true;
            descripcionIS3.BackColor = SystemColors.ControlLightLight;
            descripcionIS3.Font = new Font("Segoe UI", 10F);
            descripcionIS3.Location = new Point(49, 275);
            descripcionIS3.Name = "descripcionIS3";
            descripcionIS3.Size = new Size(151, 19);
            descripcionIS3.TabIndex = 13;
            descripcionIS3.Text = "¿No tienes una cuenta?";
            descripcionIS3.Click += descripcionIS3_Click;
            // 
            // fondoGS
            // 
            fondoGS.BackColor = SystemColors.HighlightText;
            fondoGS.Controls.Add(títuloIS);
            fondoGS.Location = new Point(10, 73);
            fondoGS.Margin = new Padding(3, 2, 3, 2);
            fondoGS.Name = "fondoGS";
            fondoGS.Size = new Size(466, 394);
            fondoGS.TabIndex = 14;
            fondoGS.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(487, 557);
            Controls.Add(descripcionIS3);
            Controls.Add(textBoxIS);
            Controls.Add(descripcionIS2);
            Controls.Add(logoGS);
            Controls.Add(descripcionIS1);
            Controls.Add(laExito);
            Controls.Add(botonIS);
            Controls.Add(fondoGS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoGS).EndInit();
            fondoGS.ResumeLayout(false);
            fondoGS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonIS;
        private Label laExito;
        private Label títuloIS;
        private Label descripcionIS1;
        private PictureBox logoGS;
        private Label descripcionIS2;
        private TextBox textBoxIS;
        private Label descripcionIS3;
        private Panel fondoGS;
    }
}
