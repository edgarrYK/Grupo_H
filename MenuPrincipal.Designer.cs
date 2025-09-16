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
            button3 = new Button();
            Search = new TextBox();
            Wishlist = new Button();
            Cart = new Button();
            pictureBox1 = new PictureBox();
            Juego1 = new Button();
            Juego2 = new Button();
            Juego3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Store
            // 
            Store.BackColor = SystemColors.ActiveCaptionText;
            Store.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            Store.ForeColor = SystemColors.ControlDark;
            Store.Location = new Point(39, 68);
            Store.Name = "Store";
            Store.Size = new Size(143, 76);
            Store.TabIndex = 1;
            Store.Text = "Store";
            Store.UseVisualStyleBackColor = false;
            Store.Click += Store_Click;
            // 
            // Library
            // 
            Library.BackColor = SystemColors.ActiveCaptionText;
            Library.ForeColor = SystemColors.ControlDark;
            Library.Location = new Point(39, 171);
            Library.Name = "Library";
            Library.Size = new Size(143, 76);
            Library.TabIndex = 2;
            Library.Text = "Library";
            Library.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(39, 281);
            button3.Name = "button3";
            button3.Size = new Size(143, 76);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.BackColor = Color.DimGray;
            Search.Location = new Point(298, 27);
            Search.Name = "Search";
            Search.Size = new Size(151, 27);
            Search.TabIndex = 4;
            // 
            // Wishlist
            // 
            Wishlist.BackColor = SystemColors.ActiveCaptionText;
            Wishlist.ForeColor = SystemColors.ControlDark;
            Wishlist.Location = new Point(762, 27);
            Wishlist.Name = "Wishlist";
            Wishlist.Size = new Size(143, 76);
            Wishlist.TabIndex = 5;
            Wishlist.Text = "Wishlist";
            Wishlist.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            Cart.BackColor = SystemColors.ActiveCaptionText;
            Cart.ForeColor = SystemColors.ControlDark;
            Cart.Location = new Point(937, 27);
            Cart.Name = "Cart";
            Cart.Size = new Size(143, 76);
            Cart.TabIndex = 6;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(370, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 481);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Juego1
            // 
            Juego1.AutoSize = true;
            Juego1.BackColor = SystemColors.ActiveCaptionText;
            Juego1.ForeColor = SystemColors.Control;
            Juego1.Location = new Point(1070, 160);
            Juego1.Name = "Juego1";
            Juego1.Size = new Size(143, 76);
            Juego1.TabIndex = 8;
            Juego1.Text = "Juego1";
            Juego1.UseVisualStyleBackColor = false;
            // 
            // Juego2
            // 
            Juego2.BackColor = SystemColors.ActiveCaptionText;
            Juego2.ForeColor = SystemColors.Control;
            Juego2.Location = new Point(1070, 255);
            Juego2.Name = "Juego2";
            Juego2.Size = new Size(143, 76);
            Juego2.TabIndex = 9;
            Juego2.Text = "Juego2";
            Juego2.UseVisualStyleBackColor = false;
            // 
            // Juego3
            // 
            Juego3.BackColor = SystemColors.ActiveCaptionText;
            Juego3.ForeColor = SystemColors.Control;
            Juego3.Location = new Point(1070, 355);
            Juego3.Name = "Juego3";
            Juego3.Size = new Size(143, 76);
            Juego3.TabIndex = 10;
            Juego3.Text = "Juego3";
            Juego3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(269, 30);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 25;
            label2.Text = "🡨";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 673);
            Controls.Add(label2);
            Controls.Add(Juego3);
            Controls.Add(Juego2);
            Controls.Add(Juego1);
            Controls.Add(pictureBox1);
            Controls.Add(Cart);
            Controls.Add(Wishlist);
            Controls.Add(Search);
            Controls.Add(button3);
            Controls.Add(Library);
            Controls.Add(Store);
            Name = "MenuPrincipal";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Library;
        private Button button3;
        private TextBox Search;
        private Button Wishlist;
        private Button Cart;
        private PictureBox pictureBox1;
        private Button Juego1;
        private Button Juego2;
        private Button Juego3;
        private Label label2;
        public Button Store;
    }
}