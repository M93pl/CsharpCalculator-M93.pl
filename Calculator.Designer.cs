namespace CSharp_Calculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            wynik = new Label();
            guz7 = new Button();
            guz4 = new Button();
            guz8 = new Button();
            guz5 = new Button();
            guz6 = new Button();
            guz9 = new Button();
            guz1 = new Button();
            guz2 = new Button();
            guz3 = new Button();
            guz0 = new Button();
            guzPrzec = new Button();
            guzZmiana = new Button();
            guzPlus = new Button();
            guzMinus = new Button();
            guzRazy = new Button();
            guzDziel = new Button();
            guzWynik = new Button();
            guzC = new Button();
            SuspendLayout();
            // 
            // wynik
            // 
            wynik.BackColor = Color.MediumPurple;
            wynik.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            wynik.Location = new Point(29, 25);
            wynik.Name = "wynik";
            wynik.Size = new Size(561, 114);
            wynik.TabIndex = 0;
            wynik.Text = "000000000";
            wynik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guz7
            // 
            guz7.BackColor = Color.SlateBlue;
            guz7.BackgroundImageLayout = ImageLayout.Center;
            guz7.FlatAppearance.BorderSize = 0;
            guz7.FlatStyle = FlatStyle.Flat;
            guz7.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz7.Location = new Point(32, 319);
            guz7.Name = "guz7";
            guz7.Size = new Size(112, 120);
            guz7.TabIndex = 1;
            guz7.Text = "7";
            guz7.UseVisualStyleBackColor = false;
            guz7.Click += guz7_Click;
            // 
            // guz4
            // 
            guz4.BackColor = Color.SlateBlue;
            guz4.BackgroundImageLayout = ImageLayout.Center;
            guz4.FlatAppearance.BorderSize = 0;
            guz4.FlatStyle = FlatStyle.Flat;
            guz4.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz4.Location = new Point(32, 461);
            guz4.Name = "guz4";
            guz4.Size = new Size(112, 120);
            guz4.TabIndex = 2;
            guz4.Text = "4";
            guz4.UseVisualStyleBackColor = false;
            guz4.Click += guz4_Click;
            // 
            // guz8
            // 
            guz8.BackColor = Color.SlateBlue;
            guz8.BackgroundImageLayout = ImageLayout.Center;
            guz8.FlatAppearance.BorderSize = 0;
            guz8.FlatStyle = FlatStyle.Flat;
            guz8.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz8.Location = new Point(164, 319);
            guz8.Name = "guz8";
            guz8.Size = new Size(112, 120);
            guz8.TabIndex = 3;
            guz8.Text = "8";
            guz8.UseVisualStyleBackColor = false;
            guz8.Click += guz8_Click;
            // 
            // guz5
            // 
            guz5.BackColor = Color.SlateBlue;
            guz5.BackgroundImageLayout = ImageLayout.Center;
            guz5.FlatAppearance.BorderSize = 0;
            guz5.FlatStyle = FlatStyle.Flat;
            guz5.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz5.Location = new Point(164, 461);
            guz5.Name = "guz5";
            guz5.Size = new Size(112, 120);
            guz5.TabIndex = 4;
            guz5.Text = "5";
            guz5.UseVisualStyleBackColor = false;
            guz5.Click += guz5_Click;
            // 
            // guz6
            // 
            guz6.BackColor = Color.SlateBlue;
            guz6.BackgroundImageLayout = ImageLayout.Center;
            guz6.FlatAppearance.BorderSize = 0;
            guz6.FlatStyle = FlatStyle.Flat;
            guz6.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz6.Location = new Point(298, 461);
            guz6.Name = "guz6";
            guz6.Size = new Size(112, 120);
            guz6.TabIndex = 5;
            guz6.Text = "6";
            guz6.UseVisualStyleBackColor = false;
            guz6.Click += guz6_Click;
            // 
            // guz9
            // 
            guz9.BackColor = Color.SlateBlue;
            guz9.BackgroundImageLayout = ImageLayout.Center;
            guz9.FlatAppearance.BorderSize = 0;
            guz9.FlatStyle = FlatStyle.Flat;
            guz9.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz9.Location = new Point(298, 319);
            guz9.Name = "guz9";
            guz9.Size = new Size(112, 120);
            guz9.TabIndex = 6;
            guz9.Text = "9";
            guz9.UseVisualStyleBackColor = false;
            guz9.Click += guz9_Click;
            // 
            // guz1
            // 
            guz1.BackColor = Color.SlateBlue;
            guz1.BackgroundImageLayout = ImageLayout.Center;
            guz1.FlatAppearance.BorderSize = 0;
            guz1.FlatStyle = FlatStyle.Flat;
            guz1.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz1.Location = new Point(32, 607);
            guz1.Name = "guz1";
            guz1.Size = new Size(112, 120);
            guz1.TabIndex = 7;
            guz1.Text = "1";
            guz1.UseVisualStyleBackColor = false;
            guz1.Click += guz1_Click;
            // 
            // guz2
            // 
            guz2.BackColor = Color.SlateBlue;
            guz2.BackgroundImageLayout = ImageLayout.Center;
            guz2.FlatAppearance.BorderSize = 0;
            guz2.FlatStyle = FlatStyle.Flat;
            guz2.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz2.Location = new Point(164, 607);
            guz2.Name = "guz2";
            guz2.Size = new Size(112, 120);
            guz2.TabIndex = 8;
            guz2.Text = "2";
            guz2.UseVisualStyleBackColor = false;
            guz2.Click += guz2_Click;
            // 
            // guz3
            // 
            guz3.BackColor = Color.SlateBlue;
            guz3.BackgroundImageLayout = ImageLayout.Center;
            guz3.FlatAppearance.BorderSize = 0;
            guz3.FlatStyle = FlatStyle.Flat;
            guz3.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz3.Location = new Point(298, 607);
            guz3.Name = "guz3";
            guz3.Size = new Size(112, 120);
            guz3.TabIndex = 9;
            guz3.Text = "3";
            guz3.UseVisualStyleBackColor = false;
            guz3.Click += guz3_Click;
            // 
            // guz0
            // 
            guz0.BackColor = Color.SlateBlue;
            guz0.BackgroundImageLayout = ImageLayout.Center;
            guz0.FlatAppearance.BorderSize = 0;
            guz0.FlatStyle = FlatStyle.Flat;
            guz0.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guz0.Location = new Point(164, 756);
            guz0.Name = "guz0";
            guz0.Size = new Size(112, 120);
            guz0.TabIndex = 10;
            guz0.Text = "0";
            guz0.UseVisualStyleBackColor = false;
            guz0.Click += guz0_Click;
            // 
            // guzPrzec
            // 
            guzPrzec.BackColor = Color.SlateBlue;
            guzPrzec.BackgroundImageLayout = ImageLayout.Center;
            guzPrzec.FlatAppearance.BorderSize = 0;
            guzPrzec.FlatStyle = FlatStyle.Flat;
            guzPrzec.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzPrzec.Location = new Point(298, 756);
            guzPrzec.Name = "guzPrzec";
            guzPrzec.Size = new Size(112, 120);
            guzPrzec.TabIndex = 11;
            guzPrzec.Text = ",";
            guzPrzec.UseVisualStyleBackColor = false;
            guzPrzec.Click += guzPrzec_Click;
            // 
            // guzZmiana
            // 
            guzZmiana.BackColor = Color.SlateBlue;
            guzZmiana.BackgroundImageLayout = ImageLayout.Center;
            guzZmiana.FlatAppearance.BorderSize = 0;
            guzZmiana.FlatStyle = FlatStyle.Flat;
            guzZmiana.Font = new Font("Consolas", 23F, FontStyle.Bold);
            guzZmiana.Location = new Point(29, 756);
            guzZmiana.Name = "guzZmiana";
            guzZmiana.Size = new Size(112, 120);
            guzZmiana.TabIndex = 12;
            guzZmiana.Text = "+/-";
            guzZmiana.UseVisualStyleBackColor = false;
            guzZmiana.Click += guzZmiana_Click;
            // 
            // guzPlus
            // 
            guzPlus.BackColor = Color.SlateBlue;
            guzPlus.BackgroundImageLayout = ImageLayout.Center;
            guzPlus.FlatAppearance.BorderSize = 0;
            guzPlus.FlatStyle = FlatStyle.Flat;
            guzPlus.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzPlus.Location = new Point(478, 319);
            guzPlus.Name = "guzPlus";
            guzPlus.Size = new Size(112, 120);
            guzPlus.TabIndex = 13;
            guzPlus.Text = "+";
            guzPlus.UseVisualStyleBackColor = false;
            guzPlus.Click += guzPlus_Click;
            // 
            // guzMinus
            // 
            guzMinus.BackColor = Color.SlateBlue;
            guzMinus.BackgroundImageLayout = ImageLayout.Center;
            guzMinus.FlatAppearance.BorderSize = 0;
            guzMinus.FlatStyle = FlatStyle.Flat;
            guzMinus.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzMinus.Location = new Point(478, 461);
            guzMinus.Name = "guzMinus";
            guzMinus.Size = new Size(112, 120);
            guzMinus.TabIndex = 14;
            guzMinus.Text = "-";
            guzMinus.UseVisualStyleBackColor = false;
            guzMinus.Click += guzMinus_Click;
            // 
            // guzRazy
            // 
            guzRazy.BackColor = Color.SlateBlue;
            guzRazy.BackgroundImageLayout = ImageLayout.Center;
            guzRazy.FlatAppearance.BorderSize = 0;
            guzRazy.FlatStyle = FlatStyle.Flat;
            guzRazy.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzRazy.Location = new Point(478, 607);
            guzRazy.Name = "guzRazy";
            guzRazy.Size = new Size(112, 120);
            guzRazy.TabIndex = 15;
            guzRazy.Text = "x";
            guzRazy.UseVisualStyleBackColor = false;
            guzRazy.Click += guzRazy_Click;
            // 
            // guzDziel
            // 
            guzDziel.BackColor = Color.SlateBlue;
            guzDziel.BackgroundImageLayout = ImageLayout.Center;
            guzDziel.FlatAppearance.BorderSize = 0;
            guzDziel.FlatStyle = FlatStyle.Flat;
            guzDziel.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzDziel.Location = new Point(478, 756);
            guzDziel.Name = "guzDziel";
            guzDziel.Size = new Size(112, 120);
            guzDziel.TabIndex = 16;
            guzDziel.Text = "/";
            guzDziel.UseVisualStyleBackColor = false;
            guzDziel.Click += guzDziel_Click;
            // 
            // guzWynik
            // 
            guzWynik.BackColor = Color.YellowGreen;
            guzWynik.BackgroundImageLayout = ImageLayout.Center;
            guzWynik.FlatAppearance.BorderSize = 0;
            guzWynik.FlatStyle = FlatStyle.Flat;
            guzWynik.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzWynik.Location = new Point(32, 174);
            guzWynik.Name = "guzWynik";
            guzWynik.Size = new Size(378, 120);
            guzWynik.TabIndex = 17;
            guzWynik.Text = "=";
            guzWynik.UseVisualStyleBackColor = false;
            guzWynik.Click += guzWynik_Click;
            // 
            // guzC
            // 
            guzC.BackColor = Color.DarkViolet;
            guzC.BackgroundImageLayout = ImageLayout.Center;
            guzC.FlatAppearance.BorderSize = 0;
            guzC.FlatStyle = FlatStyle.Flat;
            guzC.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guzC.ImageAlign = ContentAlignment.TopCenter;
            guzC.Location = new Point(478, 173);
            guzC.Name = "guzC";
            guzC.Size = new Size(112, 120);
            guzC.TabIndex = 18;
            guzC.Text = "C";
            guzC.UseVisualStyleBackColor = false;
            guzC.Click += guzC_Click;
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.Indigo;
            ClientSize = new Size(618, 904);
            Controls.Add(guzC);
            Controls.Add(guzWynik);
            Controls.Add(guzDziel);
            Controls.Add(guzRazy);
            Controls.Add(guzMinus);
            Controls.Add(guzPlus);
            Controls.Add(guzZmiana);
            Controls.Add(guzPrzec);
            Controls.Add(guz0);
            Controls.Add(guz3);
            Controls.Add(guz2);
            Controls.Add(guz1);
            Controls.Add(guz9);
            Controls.Add(guz6);
            Controls.Add(guz5);
            Controls.Add(guz8);
            Controls.Add(guz4);
            Controls.Add(guz7);
            Controls.Add(wynik);
            Cursor = Cursors.Hand;
            Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by M93.pl";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label wynik;
        private Button guz7;
        private Button guz4;
        private Button guz8;
        private Button guz5;
        private Button guz6;
        private Button guz9;
        private Button guz1;
        private Button guz2;
        private Button guz3;
        private Button guz0;
        private Button guzPrzec;
        private Button guzZmiana;
        private Button guzPlus;
        private Button guzMinus;
        private Button guzRazy;
        private Button guzDziel;
        private Button guzWynik;
        private Button guzC;
    }
}
