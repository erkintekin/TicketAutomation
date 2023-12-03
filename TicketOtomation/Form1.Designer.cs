namespace TicketOtomation
{
    partial class Pamukkale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pamukkale));
            guzergah = new TextBox();
            leftseat = new TextBox();
            ciro = new TextBox();
            olustur = new Button();
            guzergah_ara = new Label();
            koltuk_sayisi = new NumericUpDown();
            button3 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            fiyat = new TextBox();
            label7 = new Label();
            label8 = new Label();
            yas = new TextBox();
            label9 = new Label();
            biletler = new ListBox();
            user_Delete = new TextBox();
            label10 = new Label();
            bilet_verification = new Button();
            groupBox1 = new GroupBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)koltuk_sayisi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // guzergah
            // 
            guzergah.Location = new Point(158, 41);
            guzergah.Margin = new Padding(6, 4, 6, 4);
            guzergah.Name = "guzergah";
            guzergah.Size = new Size(213, 29);
            guzergah.TabIndex = 0;
            guzergah.TextChanged += guzergah_TextChanged;
            // 
            // leftseat
            // 
            leftseat.Cursor = Cursors.No;
            leftseat.Location = new Point(191, 37);
            leftseat.Margin = new Padding(6, 4, 6, 4);
            leftseat.Name = "leftseat";
            leftseat.ReadOnly = true;
            leftseat.Size = new Size(213, 29);
            leftseat.TabIndex = 2;
            leftseat.TextAlign = HorizontalAlignment.Center;
            leftseat.TextChanged += leftseat_TextChanged;
            // 
            // ciro
            // 
            ciro.Cursor = Cursors.No;
            ciro.Location = new Point(190, 82);
            ciro.Margin = new Padding(6, 4, 6, 4);
            ciro.Name = "ciro";
            ciro.ReadOnly = true;
            ciro.Size = new Size(213, 29);
            ciro.TabIndex = 3;
            ciro.TextAlign = HorizontalAlignment.Center;
            // 
            // olustur
            // 
            olustur.Cursor = Cursors.Hand;
            olustur.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            olustur.Location = new Point(133, 258);
            olustur.Margin = new Padding(6, 4, 6, 4);
            olustur.Name = "olustur";
            olustur.Size = new Size(274, 58);
            olustur.TabIndex = 5;
            olustur.Text = "Bilet Satın Al";
            olustur.UseVisualStyleBackColor = true;
            olustur.Click += button2_Click;
            // 
            // guzergah_ara
            // 
            guzergah_ara.AutoSize = true;
            guzergah_ara.Location = new Point(56, 44);
            guzergah_ara.Margin = new Padding(6, 0, 6, 0);
            guzergah_ara.Name = "guzergah_ara";
            guzergah_ara.Size = new Size(100, 21);
            guzergah_ara.TabIndex = 6;
            guzergah_ara.Text = "Güzergah:";
            // 
            // koltuk_sayisi
            // 
            koltuk_sayisi.Cursor = Cursors.Hand;
            koltuk_sayisi.Location = new Point(158, 151);
            koltuk_sayisi.Margin = new Padding(6, 4, 6, 4);
            koltuk_sayisi.Name = "koltuk_sayisi";
            koltuk_sayisi.Size = new Size(213, 29);
            koltuk_sayisi.TabIndex = 7;
            koltuk_sayisi.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(10, 77);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(97, 33);
            button3.TabIndex = 8;
            button3.Text = "İade Et";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(106, 225);
            checkBox1.Margin = new Padding(6, 4, 6, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(329, 25);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "İndirim (18 yaşından küçükler)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 153);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 10;
            label1.Text = "Koltuk Sayısı:\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 85);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 11;
            label2.Text = "Ciro :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 40);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 12;
            label3.Text = "Kalan Koltuk :";
            // 
            // name
            // 
            name.Location = new Point(158, 78);
            name.Margin = new Padding(6, 4, 6, 4);
            name.Name = "name";
            name.Size = new Size(213, 29);
            name.TabIndex = 16;
            // 
            // fiyat
            // 
            fiyat.Location = new Point(158, 188);
            fiyat.Margin = new Padding(6, 4, 6, 4);
            fiyat.Name = "fiyat";
            fiyat.Size = new Size(213, 29);
            fiyat.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 191);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 18;
            label7.Text = "Tekli Fiyat:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 81);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 19;
            label8.Text = "Ad-Soyad:";
            label8.Click += label8_Click;
            // 
            // yas
            // 
            yas.Location = new Point(158, 115);
            yas.Margin = new Padding(6, 4, 6, 4);
            yas.Name = "yas";
            yas.Size = new Size(213, 29);
            yas.TabIndex = 20;
            yas.TextChanged += yas_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 118);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 21;
            label9.Text = "Yaş:";
            // 
            // biletler
            // 
            biletler.FormattingEnabled = true;
            biletler.ItemHeight = 21;
            biletler.Items.AddRange(new object[] { "", "", "", "", "", "", "     ", "   ", "    ", "  Biletiniz hakkında detaylı bilgi burada görüntülenecektir..." });
            biletler.Location = new Point(584, 357);
            biletler.Margin = new Padding(6, 4, 6, 4);
            biletler.Name = "biletler";
            biletler.Size = new Size(635, 403);
            biletler.TabIndex = 22;
            biletler.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // user_Delete
            // 
            user_Delete.Location = new Point(137, 40);
            user_Delete.Margin = new Padding(6, 4, 6, 4);
            user_Delete.Name = "user_Delete";
            user_Delete.Size = new Size(213, 29);
            user_Delete.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 43);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 21);
            label10.TabIndex = 24;
            label10.Text = "Ad-Soyad:\r\n";
            label10.Click += label10_Click;
            // 
            // bilet_verification
            // 
            bilet_verification.Cursor = Cursors.Hand;
            bilet_verification.Location = new Point(120, 77);
            bilet_verification.Margin = new Padding(6, 4, 6, 4);
            bilet_verification.Name = "bilet_verification";
            bilet_verification.Size = new Size(249, 33);
            bilet_verification.TabIndex = 25;
            bilet_verification.Text = "Biletimi kontrol et!";
            bilet_verification.UseVisualStyleBackColor = true;
            bilet_verification.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(yas);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(fiyat);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(koltuk_sayisi);
            groupBox1.Controls.Add(guzergah_ara);
            groupBox1.Controls.Add(olustur);
            groupBox1.Controls.Add(guzergah);
            groupBox1.Location = new Point(12, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 338);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilet Satın Alma İşlemleri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonHighlight;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(349, 271);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(382, 41);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(386, 151);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bilet_verification);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(user_Delete);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(33, 782);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 135);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilet İptal İşlemleri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox8);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(ciro);
            groupBox3.Controls.Add(leftseat);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Location = new Point(721, 782);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 124);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kontrol Ekranı";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(59, 76);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 38);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 37);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-98, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(975, 100);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(309, 217);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Pamukkale
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1264, 921);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(biletler);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Font = new Font("Red Hat Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(6, 4, 6, 4);
            Name = "Pamukkale";
            Text = "Pamukkale Seyahat";
            ((System.ComponentModel.ISupportInitialize)koltuk_sayisi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox guzergah;
        private TextBox leftseat;
        private TextBox ciro;
        private Button olustur;
        private Label guzergah_ara;
        private NumericUpDown koltuk_sayisi;
        private Button button3;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox fiyat;
        private Label label7;
        private Label label8;
        private TextBox yas;
        private Label label9;
        private ListBox biletler;
        private TextBox user_Delete;
        private Label label10;
        private Button bilet_verification;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
    }
}
