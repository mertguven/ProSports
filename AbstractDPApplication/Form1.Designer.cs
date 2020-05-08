namespace AbstractDPApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.urunTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.markaTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.modelTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.profesyonelTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.menseiTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.fiyatTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.gozlukRBtn = new System.Windows.Forms.RadioButton();
            this.paletRBtn = new System.Windows.Forms.RadioButton();
            this.snorkelRBtn = new System.Windows.Forms.RadioButton();
            this.boneRBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.leftBtn = new System.Windows.Forms.PictureBox();
            this.rightBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urunGetirBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 71);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Ürün:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(82, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(72, 24);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Marka:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(93, 254);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(60, 24);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Fiyat:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(69, 218);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(84, 24);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Menşei:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(7, 183);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(146, 24);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Profesyonellik:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(80, 148);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(74, 24);
            this.bunifuCustomLabel6.TabIndex = 10;
            this.bunifuCustomLabel6.Text = "Model:";
            // 
            // urunTxt
            // 
            this.urunTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.urunTxt.Enabled = false;
            this.urunTxt.Location = new System.Drawing.Point(154, 73);
            this.urunTxt.Name = "urunTxt";
            this.urunTxt.Size = new System.Drawing.Size(198, 20);
            this.urunTxt.TabIndex = 11;
            this.urunTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // markaTxt
            // 
            this.markaTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.markaTxt.Enabled = false;
            this.markaTxt.Location = new System.Drawing.Point(154, 111);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.Size = new System.Drawing.Size(198, 20);
            this.markaTxt.TabIndex = 12;
            this.markaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelTxt
            // 
            this.modelTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.modelTxt.Enabled = false;
            this.modelTxt.Location = new System.Drawing.Point(154, 151);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(198, 20);
            this.modelTxt.TabIndex = 13;
            this.modelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profesyonelTxt
            // 
            this.profesyonelTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.profesyonelTxt.Enabled = false;
            this.profesyonelTxt.Location = new System.Drawing.Point(154, 186);
            this.profesyonelTxt.Name = "profesyonelTxt";
            this.profesyonelTxt.Size = new System.Drawing.Size(198, 20);
            this.profesyonelTxt.TabIndex = 14;
            this.profesyonelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menseiTxt
            // 
            this.menseiTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.menseiTxt.Enabled = false;
            this.menseiTxt.Location = new System.Drawing.Point(154, 222);
            this.menseiTxt.Name = "menseiTxt";
            this.menseiTxt.Size = new System.Drawing.Size(198, 20);
            this.menseiTxt.TabIndex = 15;
            this.menseiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.fiyatTxt.Enabled = false;
            this.fiyatTxt.Location = new System.Drawing.Point(154, 258);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(198, 20);
            this.fiyatTxt.TabIndex = 16;
            this.fiyatTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gozlukRBtn
            // 
            this.gozlukRBtn.AutoSize = true;
            this.gozlukRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gozlukRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.gozlukRBtn.Location = new System.Drawing.Point(48, 295);
            this.gozlukRBtn.Name = "gozlukRBtn";
            this.gozlukRBtn.Size = new System.Drawing.Size(77, 24);
            this.gozlukRBtn.TabIndex = 17;
            this.gozlukRBtn.TabStop = true;
            this.gozlukRBtn.Text = "Gözlük";
            this.gozlukRBtn.UseVisualStyleBackColor = true;
            // 
            // paletRBtn
            // 
            this.paletRBtn.AutoSize = true;
            this.paletRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paletRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.paletRBtn.Location = new System.Drawing.Point(131, 295);
            this.paletRBtn.Name = "paletRBtn";
            this.paletRBtn.Size = new System.Drawing.Size(63, 24);
            this.paletRBtn.TabIndex = 18;
            this.paletRBtn.TabStop = true;
            this.paletRBtn.Text = "Palet";
            this.paletRBtn.UseVisualStyleBackColor = true;
            // 
            // snorkelRBtn
            // 
            this.snorkelRBtn.AutoSize = true;
            this.snorkelRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.snorkelRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.snorkelRBtn.Location = new System.Drawing.Point(200, 295);
            this.snorkelRBtn.Name = "snorkelRBtn";
            this.snorkelRBtn.Size = new System.Drawing.Size(81, 24);
            this.snorkelRBtn.TabIndex = 19;
            this.snorkelRBtn.TabStop = true;
            this.snorkelRBtn.Text = "Şnorkel";
            this.snorkelRBtn.UseVisualStyleBackColor = true;
            // 
            // boneRBtn
            // 
            this.boneRBtn.AutoSize = true;
            this.boneRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boneRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.boneRBtn.Location = new System.Drawing.Point(289, 295);
            this.boneRBtn.Name = "boneRBtn";
            this.boneRBtn.Size = new System.Drawing.Size(65, 24);
            this.boneRBtn.TabIndex = 20;
            this.boneRBtn.TabStop = true;
            this.boneRBtn.Text = "Bone";
            this.boneRBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 42);
            this.panel1.TabIndex = 22;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(326, 7);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(121, 28);
            this.bunifuCustomLabel7.TabIndex = 24;
            this.bunifuCustomLabel7.Text = "Pro Sports";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel7;
            this.bunifuDragControl2.Vertical = true;
            // 
            // leftBtn
            // 
            this.leftBtn.BackColor = System.Drawing.Color.Transparent;
            this.leftBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftBtn.Image")));
            this.leftBtn.Location = new System.Drawing.Point(409, 217);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(40, 40);
            this.leftBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftBtn.TabIndex = 24;
            this.leftBtn.TabStop = false;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightBtn.Image = ((System.Drawing.Image)(resources.GetObject("rightBtn.Image")));
            this.rightBtn.Location = new System.Drawing.Point(701, 217);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(40, 40);
            this.rightBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightBtn.TabIndex = 25;
            this.rightBtn.TabStop = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(717, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AbstractDPApplication.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(455, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // urunGetirBtn
            // 
            this.urunGetirBtn.Active = false;
            this.urunGetirBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.urunGetirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.urunGetirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urunGetirBtn.BorderRadius = 7;
            this.urunGetirBtn.ButtonText = "Ürünleri Getir";
            this.urunGetirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urunGetirBtn.DisabledColor = System.Drawing.Color.Gray;
            this.urunGetirBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.urunGetirBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("urunGetirBtn.Iconimage")));
            this.urunGetirBtn.Iconimage_right = null;
            this.urunGetirBtn.Iconimage_right_Selected = null;
            this.urunGetirBtn.Iconimage_Selected = null;
            this.urunGetirBtn.IconMarginLeft = 0;
            this.urunGetirBtn.IconMarginRight = 0;
            this.urunGetirBtn.IconRightVisible = true;
            this.urunGetirBtn.IconRightZoom = 0D;
            this.urunGetirBtn.IconVisible = true;
            this.urunGetirBtn.IconZoom = 90D;
            this.urunGetirBtn.IsTab = false;
            this.urunGetirBtn.Location = new System.Drawing.Point(98, 337);
            this.urunGetirBtn.Name = "urunGetirBtn";
            this.urunGetirBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(128)))));
            this.urunGetirBtn.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.urunGetirBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.urunGetirBtn.selected = false;
            this.urunGetirBtn.Size = new System.Drawing.Size(254, 70);
            this.urunGetirBtn.TabIndex = 1;
            this.urunGetirBtn.Text = "Ürünleri Getir";
            this.urunGetirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.urunGetirBtn.Textcolor = System.Drawing.Color.White;
            this.urunGetirBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGetirBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(753, 439);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boneRBtn);
            this.Controls.Add(this.snorkelRBtn);
            this.Controls.Add(this.paletRBtn);
            this.Controls.Add(this.gozlukRBtn);
            this.Controls.Add(this.fiyatTxt);
            this.Controls.Add(this.menseiTxt);
            this.Controls.Add(this.profesyonelTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.urunTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.urunGetirBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton urunGetirBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.BunifuCustomTextbox urunTxt;
        private Bunifu.Framework.BunifuCustomTextbox markaTxt;
        private Bunifu.Framework.BunifuCustomTextbox modelTxt;
        private Bunifu.Framework.BunifuCustomTextbox profesyonelTxt;
        private Bunifu.Framework.BunifuCustomTextbox menseiTxt;
        private Bunifu.Framework.BunifuCustomTextbox fiyatTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox leftBtn;
        private System.Windows.Forms.PictureBox rightBtn;
        public System.Windows.Forms.RadioButton gozlukRBtn;
        public System.Windows.Forms.RadioButton paletRBtn;
        public System.Windows.Forms.RadioButton snorkelRBtn;
        public System.Windows.Forms.RadioButton boneRBtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

