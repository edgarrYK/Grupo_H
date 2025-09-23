namespace WinFormsApp3
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            Store = new Button();
            Library = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            vScrollBar1 = new VScrollBar();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Store
            // 
            Store.BackColor = Color.Red;
            Store.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            Store.ForeColor = Color.White;
            Store.Location = new Point(16, 80);
            Store.Margin = new Padding(3, 2, 3, 2);
            Store.Name = "Store";
            Store.Size = new Size(128, 40);
            Store.TabIndex = 1;
            Store.Text = "Tienda";
            Store.UseVisualStyleBackColor = false;
            Store.Click += Store_Click;
            // 
            // Library
            // 
            Library.BackColor = Color.Red;
            Library.ForeColor = Color.White;
            Library.Location = new Point(16, 128);
            Library.Margin = new Padding(3, 2, 3, 2);
            Library.Name = "Library";
            Library.Size = new Size(128, 40);
            Library.TabIndex = 2;
            Library.Text = "Librería";
            Library.UseVisualStyleBackColor = false;
            Library.Click += Library_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 224);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(235, 22);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 25;
            label2.Text = "🡨";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(160, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 456);
            panel1.TabIndex = 26;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(928, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(16, 440);
            vScrollBar1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(224, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 224);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(232, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Buscar";
            textBox1.Size = new Size(440, 30);
            textBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(192, 8);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 28;
            button1.Text = "🔎︎";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(8, -24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 112);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(928, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(984, 24);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 30;
            label1.Text = "Andrés Joven";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1104, 505);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(Store);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Library);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "GameStop";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Library;
        private PictureBox pictureBox1;
        private Label label2;
        public Button Store;
        private Panel panel1;
        private PictureBox pictureBox2;
        private VScrollBar vScrollBar1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
    }
}